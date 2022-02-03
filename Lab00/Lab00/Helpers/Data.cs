using Lab00.Models;
using System.Collections.Generic;

namespace Lab00.Helpers
{
    public class Data
    {
        private static Data _instance = null;

        public static Data Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Data();
                }
                return _instance;
            }
        }

        public List<ClientModels> clientlist = new List<ClientModels>
        {
                new ClientModels
                {
                    FirstName = "Emilio",
                    LastName = "Barilas",
                    Description = "Cliente",
                    Id = 001,
                    PhoneNumber = 32084649,
                }
        };

    }
}

