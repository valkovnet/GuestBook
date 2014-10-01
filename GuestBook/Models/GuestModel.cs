using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Input;
using GuestBook.Controls;
using GuestBook.Helpers;
using GuestBook.ServiceReference;

namespace GuestBook.Models
{
    public sealed class GuestModel : ModelBase<GuestModel>
    {
        private string _username;

        private string _usermail;

        private string _homepage;

        private string _messages;

        private string _capchaText;

        private string _capchaValue;

        private ObservableCollection<GuestRecord> _records = new ObservableCollection<GuestRecord>();

        public GuestModel()
        {
            SendProductsCommand = new DelegateCommand(OnSendRecord);
            AddAllAttributeValidators();

            AddValidationFor(() => CapchaText)
                .When(x => !string.IsNullOrEmpty(x.CapchaText) && string.CompareOrdinal(x.CapchaValue, x.CapchaText) != 0)
                .Show("The capcha does not match.");
        }

        public event EventHandler DoSendData;   

        public ICommand SendProductsCommand { get; private set; }

        public ObservableCollection<GuestRecord> Records
        {
            get { return this._records; }
            set
            {
                this._records = value;
                OnCurrentPropertyChanged();
            }
        }

        [Required]
        [Display(Name = "The user name is required")]        
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Max length of user name is 100 symbols.")]
        public string Username
        {
            get { return this._username; }
            set
            {
                this._username = value;
                OnCurrentPropertyChanged();
            }
        }

        [Required]
        [Display(Name = "The E-Mail is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Max length of mail is 100 symbols.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage="The E-Mail format is invalid.")]
        public string Usermail
        {
            get { return this._usermail; }
            set
            {
                this._usermail = value;
                OnCurrentPropertyChanged();
            }
        }

        [StringLength(100, ErrorMessage = "Max length of site is 100 symbols.")]
        public string Homepage
        {
            get { return this._homepage; }
            set 
            {
                this._homepage = value;
                OnCurrentPropertyChanged();
            }
        }

        [Required]
        [Display(Name = "The message is required")]
        [StringLength(1000, MinimumLength = 3, ErrorMessage = "Max length of user message is 1000 symbols.")]
        public string Messages
        {
            get { return this._messages; }
            set
            {
                this._messages = value;
                OnCurrentPropertyChanged();
            }
        }

        [Required]
        [Display(Name = "The capcha is required")]
        public string CapchaText
        {
            get { return this._capchaText; }
            set
            {
                this._capchaText = value;
                OnCurrentPropertyChanged();
            }
        }

        public string CapchaValue
        {
            get { return this._capchaValue; }
            set { this._capchaValue = value; }
        }

        public void ClearData()
        {
            ClearValidators();
            Username = Messages = Usermail = Homepage = String.Empty;
            AddAllAttributeValidators();
        }

        public GuestRecord ToGuestRecord()
        {
            var address = Application.Current.Resources["UserAddress"] as string;
            address = address ?? "Empty";
            
            return new GuestRecord
                {
                    UserMail = Usermail,
                    Homepage = Homepage,
                    IpAddres = address,
                    UserName = Username,
                    Messages = Messages,

                    BrowserInfo = new BrowserInfo
                        {
                            UserAgent = HtmlPage.BrowserInformation.UserAgent,
                            BrowserName = HtmlPage.BrowserInformation.Name,
                            BrowserVersion = HtmlPage.BrowserInformation.BrowserVersion.ToString()
                        }
                };
        }

        private void OnSendRecord(object obj)
        {
            ValidateAll();            
            if (!HasErrors && DoSendData != null)
            {
                DoSendData(obj, EventArgs.Empty);
            }
        }             
    }
}
