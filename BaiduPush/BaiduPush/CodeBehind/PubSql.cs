using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BaiduPush.CodeBehind
{
    public class PubSql
    {
        public static readonly string ApiKey = ConfigurationManager.AppSettings["ApiKey"];
        public static readonly string SecretKey = ConfigurationManager.AppSettings["SecretKey"];
    }
}