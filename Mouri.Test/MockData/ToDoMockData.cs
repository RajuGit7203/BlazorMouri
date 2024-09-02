using Mouri.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mouri.Test.MockData
{
    public class ToDoMockData
    {
        public static User GetUser()
        {
            return new User()
            {
                UserName = "Admin",
                PassWord = "password"
            };
        }
        public static string PatientId = "1000";
        public static Patient GetPatient()
        {
            var patient = new Patient
            {
                Id = "1000",
                FirstName = "Mark",
                Lastname = "Hassan",
                Address = new AddressInfo
                {
                    AddressId = 1000,
                    City = "Rockville",
                    State = "MD",
                    Street = "455 Marshall",
                    Zip = "20851"
                },
                Dob = Convert.ToDateTime("02/10/1985")
            };
            return patient;
        }
    }
}
