using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.BirthYear==1990 && player.FirstName=="Sena"&& player.LastName=="Tek"&& player.IdentityNumber=="87654321")
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
