using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace GuestBook.Models
{
    public class ModelBase<TBindingModel> : INotifyPropertyChanged, INotifyDataErrorInfo
        where TBindingModel : ModelBase<TBindingModel>
    {        
        private Dictionary<string, List<string>> _errorMessages = new Dictionary<string, List<string>>();

        private readonly List<PropertyValidation<TBindingModel>> _validations = new List<PropertyValidation<TBindingModel>>();

        protected ModelBase()
		{
			PropertyChanged += (s, e) => { if (e.PropertyName != "HasErrors") ValidateProperty(e.PropertyName); };
		}

        #region Public Properties

        protected void ClearValidators()
        {
            this._validations.Clear();
            this._errorMessages.Clear();            
        }
        
        #endregion

        #region INotifyDataErrorInfo

        public IEnumerable GetErrors(string propertyName)
        {
            if (this._errorMessages.ContainsKey(propertyName))
            {
                return _errorMessages[propertyName];
            }

            return new string[0];
        }

        public bool HasErrors
        {
            get { return _errorMessages.Count > 0; }
        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged = delegate { };

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Potected Methods

        protected PropertyValidation<TBindingModel> AddValidationFor(Expression<Func<object>> expression)
        {
            return AddValidationFor(GetPropertyName(expression));
        }

        protected PropertyValidation<TBindingModel> AddValidationFor(string propertyName)
        {
            var validation = new PropertyValidation<TBindingModel>(propertyName);
            this._validations.Add(validation);

            return validation;
        }

        protected void AddAllAttributeValidators()
        {
            PropertyInfo[] propertyInfos = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                Attribute[] custom = Attribute.GetCustomAttributes(propertyInfo, typeof(ValidationAttribute), true);
                foreach (var attribute in custom)
                {
                    var property = propertyInfo;
                    var validationAttribute = attribute as ValidationAttribute;
                    if (validationAttribute == null)
                    {
                        throw new NotSupportedException("validationAttribute variable should be inherited from ValidationAttribute type");
                    }

                    string name = property.Name;

                    var displayAttribute = Attribute.GetCustomAttributes(propertyInfo, typeof(DisplayAttribute)).FirstOrDefault() as DisplayAttribute;
                    if (displayAttribute != null)
                    {
                        name = displayAttribute.GetName();
                    }

                    var message = validationAttribute.FormatErrorMessage(name);

                    AddValidationFor(propertyInfo.Name)
                        .When(x =>
                        {
                            var value = property.GetGetMethod().Invoke(this, new object[] { });
                            var result = validationAttribute.GetValidationResult(value,
                                                                    new ValidationContext(this, null, null) { MemberName = property.Name });
                            return result != ValidationResult.Success;
                        })
                        .Show(message);

                }
            }
        }

        public void ValidateAll()
        {
            var propertyNamesWithValidationErrors = _errorMessages.Keys;

            this._errorMessages = new Dictionary<string, List<string>>();
            this._validations.ForEach(PerformValidation);

            var propertyNamesThatMightHaveChangedValidation = this._errorMessages.Keys.Union(propertyNamesWithValidationErrors).ToList();

            propertyNamesThatMightHaveChangedValidation.ForEach(OnErrorsChanged);
            OnPropertyChanged(() => HasErrors);
        }

        public void ValidateProperty(Expression<Func<object>> expression)
        {
            ValidateProperty(GetPropertyName(expression));
        }

        private void ValidateProperty(string propertyName)
        {
            this._errorMessages.Remove(propertyName);
            this._validations.Where(v => v.PropertyName == propertyName).ToList().ForEach(PerformValidation);
            OnErrorsChanged(propertyName);
            OnPropertyChanged(() => HasErrors);
        }

        private void PerformValidation(PropertyValidation<TBindingModel> validation)
        {
            if (validation.IsInvalid((TBindingModel)this))
            {
                AddErrorMessageForProperty(validation.PropertyName, validation.GetErrorMessage());
            }
        }

        private void AddErrorMessageForProperty(string propertyName, string errorMessage)
        {
            if (this._errorMessages.ContainsKey(propertyName))
            {
                this._errorMessages[propertyName].Add(errorMessage);
            }
            else
            {
                this._errorMessages.Add(propertyName, new List<string> { errorMessage });
            }
        }

        private static string GetPropertyName(Expression<Func<object>> expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }

            MemberExpression memberExpression;
            if (expression.Body is UnaryExpression)
            {
                memberExpression = ((UnaryExpression)expression.Body).Operand as MemberExpression;
            }
            else
            {
                memberExpression = expression.Body as MemberExpression;
            }

            if (memberExpression == null)
            {
                throw new ArgumentException("The expression is not a member access expression", "expression");
            }

            var property = memberExpression.Member as PropertyInfo;
            if (property == null)
            {
                throw new ArgumentException("The member access expression does not access a property", "expression");
            }

            var getMethod = property.GetGetMethod(true);
            if (getMethod.IsStatic)
            {
                throw new ArgumentException("The referenced property is a static property", "expression");
            }

            return memberExpression.Member.Name;
        }

        #endregion

        #region Event Handlers

        protected void OnPropertyChanged(Expression<Func<object>> expression)
        {
            OnPropertyChanged(GetPropertyName(expression));
        }

        protected void OnCurrentPropertyChanged()
        {
            string methodName = string.Empty;

            var stackTrace = new StackTrace();
            StackFrame[] stackFrames = stackTrace.GetFrames();

            if (stackFrames != null && stackFrames.Length > 1)
            {
                methodName = stackFrames[1].GetMethod().Name;
            }

            if (!methodName.StartsWith("set_", StringComparison.OrdinalIgnoreCase))
            {
                throw new NotSupportedException("OnCurrentPropertyChanged should be invoked only in property setter");
            }

            string propertyName = methodName.Substring(4);
            OnPropertyChanged(propertyName);
        }

        #endregion
    }
}
