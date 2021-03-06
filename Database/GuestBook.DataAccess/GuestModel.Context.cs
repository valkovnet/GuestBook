﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuestBook.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class GuestBookEntities : DbContext
    {
        public GuestBookEntities()
            : base("name=GuestBookEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int AddGuestRecord(string username, string usermail, string messages, string homepage, string ipaddres, string useragent, string browsername, string browserversion)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var usermailParameter = usermail != null ?
                new ObjectParameter("usermail", usermail) :
                new ObjectParameter("usermail", typeof(string));
    
            var messagesParameter = messages != null ?
                new ObjectParameter("messages", messages) :
                new ObjectParameter("messages", typeof(string));
    
            var homepageParameter = homepage != null ?
                new ObjectParameter("homepage", homepage) :
                new ObjectParameter("homepage", typeof(string));
    
            var ipaddresParameter = ipaddres != null ?
                new ObjectParameter("ipaddres", ipaddres) :
                new ObjectParameter("ipaddres", typeof(string));
    
            var useragentParameter = useragent != null ?
                new ObjectParameter("useragent", useragent) :
                new ObjectParameter("useragent", typeof(string));
    
            var browsernameParameter = browsername != null ?
                new ObjectParameter("browsername", browsername) :
                new ObjectParameter("browsername", typeof(string));
    
            var browserversionParameter = browserversion != null ?
                new ObjectParameter("browserversion", browserversion) :
                new ObjectParameter("browserversion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddGuestRecord", usernameParameter, usermailParameter, messagesParameter, homepageParameter, ipaddresParameter, useragentParameter, browsernameParameter, browserversionParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetRecordsInfo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetRecordsInfo");
        }
    
        public virtual ObjectResult<GetGuestRecords_Result> GetGuestRecords(Nullable<int> from, Nullable<int> to)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("from", from) :
                new ObjectParameter("from", typeof(int));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("to", to) :
                new ObjectParameter("to", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetGuestRecords_Result>("GetGuestRecords", fromParameter, toParameter);
        }
    
        public virtual ObjectResult<GetAllRecords_Result> GetAllRecords()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllRecords_Result>("GetAllRecords");
        }
    }
}
