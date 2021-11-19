using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    //SecurityKeyHelper class'ında appsettings.json dosyasında verdigimiz securitykey'imizi byte array haline getiriyoruz. Daha sonra simetrik security anahtarı halına getiriyoruz.
    public class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

        }
    }
}
