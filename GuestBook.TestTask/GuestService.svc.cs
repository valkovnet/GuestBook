using System;
using System.Collections.Generic;
using System.ServiceModel;
using GuestBook.Types;
using System.ServiceModel.Activation;
using GuestBook.Types.Exceptions;

namespace GuestBook.TestTask
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class GuestService : CustomProvider, IGuestService
    {
        public void AddRecord(string key, GuestRecord record)
        {
            try
            {
                DataProvider.AddGuestRequest(record);
            }
            catch (DatabaseException ex)
            {
                throw new FaultException(ex.Message, new FaultCode("AddRecord"));
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message, new FaultCode("AddRecord"));
            }
        }

        public int GetRecordsInfo()
        {
            try
            {
                return DataProvider.GetRecordsInfo();
            }
            catch (DatabaseException ex)
            {
                throw new FaultException(ex.Message, new FaultCode("GetRecordsInfo"));
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message, new FaultCode("GetRecordsInfo"));
            }
        }

        public List<GuestRecord> GetAllRecords()
        {
            try
            {
                return DataProvider.GetAllRecords();
            }
            catch (DatabaseException ex)
            {
                throw new FaultException(ex.Message, new FaultCode("GetGuestRecords"));
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message, new FaultCode("GetGuestRecords"));
            }
        }
    }
}
