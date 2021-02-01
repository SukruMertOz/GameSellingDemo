using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GameSellingDemo
{
    class PlayerManager:IPlayerService
    {
       IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.Validate(player) == true)
            {
                Console.WriteLine("Added");
            }
            else
            {
                Console.WriteLine("Verification failed");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Registration Deleted");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Registry Updated");
        }

    }
}
