using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;
using System.Globalization;

namespace AdditionOfNumbers.HeplerClasses
{
    public static class HandleError
    {
        public static void WriteError(Exception errorObj)
        {
            System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(errorObj, true);
            string path = "~/ErrorLog/" + DateTime.Today.ToString("dd-MMM-yyyy") + ".txt";
            if (!File.Exists(System.Web.HttpContext.Current.Server.MapPath(path)))
            {
                File.Create(System.Web.HttpContext.Current.Server.MapPath(path)).Close();
            }

        }
    }
}