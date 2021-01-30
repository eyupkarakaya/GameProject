using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear ==1993 && gamer.FirstName == "Eyüp" && gamer.LastName =="Karakaya"&& gamer.IdentityNumber ==12345 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
