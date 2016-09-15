using System;
using System.Web;
using System.Web.Http;
using System.Web.Optimization;
using YourWebAppExample.Security;

namespace YourWebAppExample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
			//When is not debug call Encrypting and Decrypting Web.config key(s)
			#if !DEBUG
				EncryptDecrypt.EncryptConnString(); //Encrypting connectionStrings
				EncryptDecrypt.EncryptAppSettings(); //Encrypting appSettings
			#endif
			
            //...
        }
    }
}
