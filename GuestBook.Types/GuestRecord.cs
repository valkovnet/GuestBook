using System;
using System.Runtime.Serialization;

namespace GuestBook.Types
{
    [DataContract(Name = "GuestRecord")]
    public sealed class GuestRecord
    {
        public GuestRecord()
        {
            BrowserInfo = new BrowserInfo();
        }

        [DataMember(Name = "UserName", IsRequired = true, Order = 1)]
        public string UserName
        {
            get; 
            set;
        }

        [DataMember(Name = "UserMail", IsRequired = true, Order = 2)]
        public string UserMail
        {
            get; 
            set;
        }

        [DataMember(Name = "Messages", IsRequired = true, Order = 3)]
        public string Messages
        {
            get;
            set;
        }

        [DataMember(Name = "Homepage", IsRequired = false, Order = 4)]
        public string Homepage
        {
            get;
            set;
        }        

        [DataMember(Name = "IpAddres", IsRequired = false, Order = 5)]
        public string IpAddres
        {
            get;
            set;
        }

        [DataMember(Name = "BrowserInfo", IsRequired = false, Order = 6)]
        public BrowserInfo BrowserInfo
        {
            get;
            set;
        }

        [DataMember(Name = "PostedDate", IsRequired = true, Order = 7)]
        public DateTime PostedDate
        {
            get; 
            set;
        }
    }
}
