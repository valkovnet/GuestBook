using System;
using System.Collections.Generic;
using System.Linq;
using GuestBook.Types;
using GuestBook.Types.Exceptions;

namespace GuestBook.DataAccess
{
    public sealed class GusetDataProvider
    {
        public void AddGuestRequest(GuestRecord record)
        {
            try
            {
                using (var entity = new GuestBookEntities())
                {
                    entity.AddGuestRecord(record.UserName, record.UserMail, record.Messages, record.Homepage,
                                          record.IpAddres, record.BrowserInfo.UserAgent, record.BrowserInfo.BrowserName,
                                          record.BrowserInfo.BrowserVersion);
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Can't add the record to guest book", ex);
            }
        }

        public int GetRecordsInfo()
        {
            try
            {
                using (var entity = new GuestBookEntities())
                {
                    var value = entity.GetRecordsInfo().SingleOrDefault();                    
                    return value.HasValue ? value.Value : 0;
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Can't add the record to guest book", ex);
            }
        }

        public List<GuestRecord> GetGuestRecords(int from, int to)
        {
            try
            {
                var resultset = new List<GuestRecord>();
                using (var entity = new GuestBookEntities())
                {
                    resultset.AddRange(entity.GetGuestRecords(@from, to).Select(record => new GuestRecord
                        {
                            UserName = record.UserName, UserMail = record.UserMail, Messages = record.Messages, PostedDate = record.PostDate
                        }));
                }

                return resultset;
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Can't add the record to guest book", ex);
            }
        }

        public List<GuestRecord> GetAllRecords()
        {
            try
            {
                var resultset = new List<GuestRecord>();
                using (var entity = new GuestBookEntities())
                {
                    resultset.AddRange(entity.GetAllRecords().Select(record => new GuestRecord
                        {
                            UserName = record.UserName, UserMail = record.UserMail, Messages = record.Messages, PostedDate = record.PostDate
                        }));
                }

                return resultset;
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Can't add the record to guest book", ex);
            }
        }
    }
}
