using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage;

namespace Service
{
    public class Class1
    {
        public static bool Login(string login, string password)
        {
            Model1Container DataBase = new Model1Container();
            var user = DataBase.Users.FirstOrDefault(x => x.Login == login);

            if (user == null)
            {
                return false;
            }
            else
            {
                if (user.Password == password)
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
}
