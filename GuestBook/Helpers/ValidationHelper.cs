using System;
using System.Collections.Generic;

namespace GuestBook.Helpers
{
    public class ValidationHandler
    {
        private Dictionary<string, string> BrokenRules { get; set; }

        public ValidationHandler()
        {
            BrokenRules = new Dictionary<string, string>();
        }
        
        public string this[string property]
        {
            get { return BrokenRules[property]; }
        }
        
        public bool BrokenRuleExists(string property)
        {
            return BrokenRules.ContainsKey(property);
        }
        
        public bool ValidateRule(string property, string message, Func<bool> ruleCheck)
        {
            bool check = ruleCheck();
            if (!check)
            {
                if (BrokenRuleExists(property))
                    RemoveBrokenRule(property);

                BrokenRules.Add(property, message);
            }
            else
            {
                RemoveBrokenRule(property);
            } return check;
        }
        
        public void RemoveBrokenRule(string property)
        {
            if (BrokenRules.ContainsKey(property))
            {
                BrokenRules.Remove(property);
            }
        }
        
        public void Clear()
        {
            BrokenRules.Clear();
        }
    }
}
