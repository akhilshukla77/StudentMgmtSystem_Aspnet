using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace StudentMgmtApp.Helper
{
    public class StudentMgmtApi
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56799/");
            return client;
        }
    }
}