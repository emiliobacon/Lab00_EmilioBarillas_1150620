using Lab00.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab00.Models
{
    public class ClientModels
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int PhoneNumber { get; set; }
        public String Description { get; set; }

        public static bool Save(ClientModels model)
        {
            Data.Instance.clientlist.Add(model);
            return true;
        }

        public static bool Edit(ClientModels model)
        {
            throw new NotImplementedException();
        }
    }
}
