using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GPRS_CLOUD.Repo
{
    

        public static class TrueChange
        {
            public static string LiveMoniterConnectionString;
            static TrueChange()
            {
                LiveMoniterConnectionString = ConfigurationManager.ConnectionStrings["LiveMoniterConnectionString"].ConnectionString;
            }
        }
    
}