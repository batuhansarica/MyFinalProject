using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       
        //kod tekrar olduğunu için succes silinip constructora succes yolladık
        public Result(bool succes, string message):this(succes)
        {
            Message = message;
            
        }
        //Mesaj göndermek istenmezse diye 2 costructor tanımlaması yapılıyor
        public Result(bool succes)
        {
            
            Succes = succes;
        }

        public bool Succes  { get; }

        public string Message { get; }
    }
}
