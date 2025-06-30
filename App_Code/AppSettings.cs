using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto3._1.App_Code
{
    public class AppSettings
    {
        //String de conexão com o banco de dados access
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/SI2022N.accdb") + ";Persist Security Info=False;";

    }
}