using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Services;
using System.Diagnostics; 

namespace WS_Hom_01_01_03_14
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://localhost/", Name="CursoAndroidUnsa")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod (Description="web services prueba curso android")]
        public string EnviarNotasCursoAndroid(String alumno, String nota)
        {
            string ackno = "recibido"; 
            // enviar a la base de datos 
           
            return ackno;
        }
    }
}