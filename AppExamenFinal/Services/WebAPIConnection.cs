using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExamenFinal.Services
{
    internal class WebAPIConnection
    {
        public static string ProductionURLPrefix = "http://192.168.0.3:45455/api/";

        public static string TestingURLPrefix = "http://192.168.0.3:45455/api/";

        public static string ApiKeyName = "P6ApiKey";
        public static string ApiKeyValue = "KmiloP6Api";
    }
}
