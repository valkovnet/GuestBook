﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace GuestBook.ServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GuestRecord", Namespace="http://schemas.datacontract.org/2004/07/GuestBook.Types")]
    public partial class GuestRecord : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string UserNameField;
        
        private string UserMailField;
        
        private string MessagesField;
        
        private string HomepageField;
        
        private string IpAddresField;
        
        private GuestBook.ServiceReference.BrowserInfo BrowserInfoField;
        
        private System.DateTime PostedDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public string UserMail {
            get {
                return this.UserMailField;
            }
            set {
                if ((object.ReferenceEquals(this.UserMailField, value) != true)) {
                    this.UserMailField = value;
                    this.RaisePropertyChanged("UserMail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public string Messages {
            get {
                return this.MessagesField;
            }
            set {
                if ((object.ReferenceEquals(this.MessagesField, value) != true)) {
                    this.MessagesField = value;
                    this.RaisePropertyChanged("Messages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string Homepage {
            get {
                return this.HomepageField;
            }
            set {
                if ((object.ReferenceEquals(this.HomepageField, value) != true)) {
                    this.HomepageField = value;
                    this.RaisePropertyChanged("Homepage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string IpAddres {
            get {
                return this.IpAddresField;
            }
            set {
                if ((object.ReferenceEquals(this.IpAddresField, value) != true)) {
                    this.IpAddresField = value;
                    this.RaisePropertyChanged("IpAddres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public GuestBook.ServiceReference.BrowserInfo BrowserInfo {
            get {
                return this.BrowserInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.BrowserInfoField, value) != true)) {
                    this.BrowserInfoField = value;
                    this.RaisePropertyChanged("BrowserInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.DateTime PostedDate {
            get {
                return this.PostedDateField;
            }
            set {
                if ((this.PostedDateField.Equals(value) != true)) {
                    this.PostedDateField = value;
                    this.RaisePropertyChanged("PostedDate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BrowserInfo", Namespace="http://schemas.datacontract.org/2004/07/GuestBook.Types")]
    public partial class BrowserInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string UserAgentField;
        
        private string BrowserNameField;
        
        private string BrowserVersionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string UserAgent {
            get {
                return this.UserAgentField;
            }
            set {
                if ((object.ReferenceEquals(this.UserAgentField, value) != true)) {
                    this.UserAgentField = value;
                    this.RaisePropertyChanged("UserAgent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string BrowserName {
            get {
                return this.BrowserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.BrowserNameField, value) != true)) {
                    this.BrowserNameField = value;
                    this.RaisePropertyChanged("BrowserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string BrowserVersion {
            get {
                return this.BrowserVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.BrowserVersionField, value) != true)) {
                    this.BrowserVersionField = value;
                    this.RaisePropertyChanged("BrowserVersion");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IGuestService")]
    public interface IGuestService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IGuestService/GetRecordsInfo", ReplyAction="http://tempuri.org/IGuestService/GetRecordsInfoResponse")]
        System.IAsyncResult BeginGetRecordsInfo(System.AsyncCallback callback, object asyncState);
        
        int EndGetRecordsInfo(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IGuestService/GetGuestRecords", ReplyAction="http://tempuri.org/IGuestService/GetGuestRecordsResponse")]
        System.IAsyncResult BeginGetGuestRecords(int from, int to, System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<GuestBook.ServiceReference.GuestRecord> EndGetGuestRecords(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IGuestService/AddRecord", ReplyAction="http://tempuri.org/IGuestService/AddRecordResponse")]
        System.IAsyncResult BeginAddRecord(string key, GuestBook.ServiceReference.GuestRecord record, System.AsyncCallback callback, object asyncState);
        
        void EndAddRecord(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGuestServiceChannel : GuestBook.ServiceReference.IGuestService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetRecordsInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetRecordsInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetGuestRecordsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetGuestRecordsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<GuestBook.ServiceReference.GuestRecord> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<GuestBook.ServiceReference.GuestRecord>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GuestServiceClient : System.ServiceModel.ClientBase<GuestBook.ServiceReference.IGuestService>, GuestBook.ServiceReference.IGuestService {
        
        private BeginOperationDelegate onBeginGetRecordsInfoDelegate;
        
        private EndOperationDelegate onEndGetRecordsInfoDelegate;
        
        private System.Threading.SendOrPostCallback onGetRecordsInfoCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetGuestRecordsDelegate;
        
        private EndOperationDelegate onEndGetGuestRecordsDelegate;
        
        private System.Threading.SendOrPostCallback onGetGuestRecordsCompletedDelegate;
        
        private BeginOperationDelegate onBeginAddRecordDelegate;
        
        private EndOperationDelegate onEndAddRecordDelegate;
        
        private System.Threading.SendOrPostCallback onAddRecordCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public GuestServiceClient() {
        }
        
        public GuestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GuestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GuestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GuestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetRecordsInfoCompletedEventArgs> GetRecordsInfoCompleted;
        
        public event System.EventHandler<GetGuestRecordsCompletedEventArgs> GetGuestRecordsCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> AddRecordCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult GuestBook.ServiceReference.IGuestService.BeginGetRecordsInfo(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetRecordsInfo(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        int GuestBook.ServiceReference.IGuestService.EndGetRecordsInfo(System.IAsyncResult result) {
            return base.Channel.EndGetRecordsInfo(result);
        }
        
        private System.IAsyncResult OnBeginGetRecordsInfo(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((GuestBook.ServiceReference.IGuestService)(this)).BeginGetRecordsInfo(callback, asyncState);
        }
        
        private object[] OnEndGetRecordsInfo(System.IAsyncResult result) {
            int retVal = ((GuestBook.ServiceReference.IGuestService)(this)).EndGetRecordsInfo(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetRecordsInfoCompleted(object state) {
            if ((this.GetRecordsInfoCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetRecordsInfoCompleted(this, new GetRecordsInfoCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetRecordsInfoAsync() {
            this.GetRecordsInfoAsync(null);
        }
        
        public void GetRecordsInfoAsync(object userState) {
            if ((this.onBeginGetRecordsInfoDelegate == null)) {
                this.onBeginGetRecordsInfoDelegate = new BeginOperationDelegate(this.OnBeginGetRecordsInfo);
            }
            if ((this.onEndGetRecordsInfoDelegate == null)) {
                this.onEndGetRecordsInfoDelegate = new EndOperationDelegate(this.OnEndGetRecordsInfo);
            }
            if ((this.onGetRecordsInfoCompletedDelegate == null)) {
                this.onGetRecordsInfoCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetRecordsInfoCompleted);
            }
            base.InvokeAsync(this.onBeginGetRecordsInfoDelegate, null, this.onEndGetRecordsInfoDelegate, this.onGetRecordsInfoCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult GuestBook.ServiceReference.IGuestService.BeginGetGuestRecords(int from, int to, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetGuestRecords(from, to, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<GuestBook.ServiceReference.GuestRecord> GuestBook.ServiceReference.IGuestService.EndGetGuestRecords(System.IAsyncResult result) {
            return base.Channel.EndGetGuestRecords(result);
        }
        
        private System.IAsyncResult OnBeginGetGuestRecords(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int from = ((int)(inValues[0]));
            int to = ((int)(inValues[1]));
            return ((GuestBook.ServiceReference.IGuestService)(this)).BeginGetGuestRecords(from, to, callback, asyncState);
        }
        
        private object[] OnEndGetGuestRecords(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<GuestBook.ServiceReference.GuestRecord> retVal = ((GuestBook.ServiceReference.IGuestService)(this)).EndGetGuestRecords(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetGuestRecordsCompleted(object state) {
            if ((this.GetGuestRecordsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetGuestRecordsCompleted(this, new GetGuestRecordsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetGuestRecordsAsync(int from, int to) {
            this.GetGuestRecordsAsync(from, to, null);
        }
        
        public void GetGuestRecordsAsync(int from, int to, object userState) {
            if ((this.onBeginGetGuestRecordsDelegate == null)) {
                this.onBeginGetGuestRecordsDelegate = new BeginOperationDelegate(this.OnBeginGetGuestRecords);
            }
            if ((this.onEndGetGuestRecordsDelegate == null)) {
                this.onEndGetGuestRecordsDelegate = new EndOperationDelegate(this.OnEndGetGuestRecords);
            }
            if ((this.onGetGuestRecordsCompletedDelegate == null)) {
                this.onGetGuestRecordsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetGuestRecordsCompleted);
            }
            base.InvokeAsync(this.onBeginGetGuestRecordsDelegate, new object[] {
                        from,
                        to}, this.onEndGetGuestRecordsDelegate, this.onGetGuestRecordsCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult GuestBook.ServiceReference.IGuestService.BeginAddRecord(string key, GuestBook.ServiceReference.GuestRecord record, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAddRecord(key, record, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void GuestBook.ServiceReference.IGuestService.EndAddRecord(System.IAsyncResult result) {
            base.Channel.EndAddRecord(result);
        }
        
        private System.IAsyncResult OnBeginAddRecord(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string key = ((string)(inValues[0]));
            GuestBook.ServiceReference.GuestRecord record = ((GuestBook.ServiceReference.GuestRecord)(inValues[1]));
            return ((GuestBook.ServiceReference.IGuestService)(this)).BeginAddRecord(key, record, callback, asyncState);
        }
        
        private object[] OnEndAddRecord(System.IAsyncResult result) {
            ((GuestBook.ServiceReference.IGuestService)(this)).EndAddRecord(result);
            return null;
        }
        
        private void OnAddRecordCompleted(object state) {
            if ((this.AddRecordCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.AddRecordCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void AddRecordAsync(string key, GuestBook.ServiceReference.GuestRecord record) {
            this.AddRecordAsync(key, record, null);
        }
        
        public void AddRecordAsync(string key, GuestBook.ServiceReference.GuestRecord record, object userState) {
            if ((this.onBeginAddRecordDelegate == null)) {
                this.onBeginAddRecordDelegate = new BeginOperationDelegate(this.OnBeginAddRecord);
            }
            if ((this.onEndAddRecordDelegate == null)) {
                this.onEndAddRecordDelegate = new EndOperationDelegate(this.OnEndAddRecord);
            }
            if ((this.onAddRecordCompletedDelegate == null)) {
                this.onAddRecordCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAddRecordCompleted);
            }
            base.InvokeAsync(this.onBeginAddRecordDelegate, new object[] {
                        key,
                        record}, this.onEndAddRecordDelegate, this.onAddRecordCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override GuestBook.ServiceReference.IGuestService CreateChannel() {
            return new GuestServiceClientChannel(this);
        }
        
        private class GuestServiceClientChannel : ChannelBase<GuestBook.ServiceReference.IGuestService>, GuestBook.ServiceReference.IGuestService {
            
            public GuestServiceClientChannel(System.ServiceModel.ClientBase<GuestBook.ServiceReference.IGuestService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetRecordsInfo(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetRecordsInfo", _args, callback, asyncState);
                return _result;
            }
            
            public int EndGetRecordsInfo(System.IAsyncResult result) {
                object[] _args = new object[0];
                int _result = ((int)(base.EndInvoke("GetRecordsInfo", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetGuestRecords(int from, int to, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = from;
                _args[1] = to;
                System.IAsyncResult _result = base.BeginInvoke("GetGuestRecords", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<GuestBook.ServiceReference.GuestRecord> EndGetGuestRecords(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<GuestBook.ServiceReference.GuestRecord> _result = ((System.Collections.ObjectModel.ObservableCollection<GuestBook.ServiceReference.GuestRecord>)(base.EndInvoke("GetGuestRecords", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginAddRecord(string key, GuestBook.ServiceReference.GuestRecord record, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = key;
                _args[1] = record;
                System.IAsyncResult _result = base.BeginInvoke("AddRecord", _args, callback, asyncState);
                return _result;
            }
            
            public void EndAddRecord(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("AddRecord", _args, result);
            }
        }
    }
}