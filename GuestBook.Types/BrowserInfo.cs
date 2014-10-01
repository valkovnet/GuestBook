using System.Runtime.Serialization;

namespace GuestBook.Types
{
    [DataContract(Name = "BrowserInfo")]
    public sealed class BrowserInfo
    {
        [DataMember(Name = "UserAgent", IsRequired = true, Order = 1)]
        public string UserAgent
        {
            get; 
            set;
        }

        [DataMember(Name = "BrowserName", IsRequired = false, Order = 2)]
        public string BrowserName
        {
            get;
            set;
        }

        [DataMember(Name = "BrowserVersion", IsRequired = false, Order = 3)]
        public string BrowserVersion
        {
            get;
            set;
        }
    }
}
