using System.Web;
using System.Web.Mvc;

namespace BienHuynhCongKhang_2011060425_Week3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
