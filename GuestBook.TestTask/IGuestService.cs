using GuestBook.Types;
using System.ServiceModel;
using System.Collections.Generic;

namespace GuestBook.TestTask
{    
    [ServiceContract(SessionMode=SessionMode.Allowed)]
    public interface IGuestService
    {
        [OperationContract(Name = "GetRecordsInfo")]
        int GetRecordsInfo();

        [OperationContract(Name = "GetAllRecords")]
        List<GuestRecord> GetAllRecords();

        [OperationContract(Name = "AddRecord")]
        void AddRecord(string key, GuestRecord record);
    }
}
