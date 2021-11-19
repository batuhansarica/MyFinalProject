using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //CreateToken oturum acan user'in claim(yetkilerini) verdigimiz fonksiyon
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);

    }
}
