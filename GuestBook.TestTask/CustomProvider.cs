using System.Web;
using GuestBook.DataAccess;

namespace GuestBook.TestTask
{
    public abstract class CustomProvider
    {
        private const string SessionKey = "SessionProvicerKey";

        protected GusetDataProvider DataProvider
        {
            get
            {
                var provier = HttpContext.Current.Session[SessionKey] as GusetDataProvider;
                if (provier == null)
                {
                    provier = new GusetDataProvider();
                    HttpContext.Current.Session[SessionKey] = provier;
                }

                return provier;
            }
        }
    }
}