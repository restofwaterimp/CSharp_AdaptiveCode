using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class Program
    {
        static IUserRepository userRepository = new UserRepository();

        static void Main(string[] args)
        {
            var user = userRepository.GetByID(Guid.NewGuid());
            // Null Objedt パターンを適用しないと、ここで例外がスローされる
            user.IncrementSesssionTicket();

            string userName;
            if (!user.IsNull)
            {
                userName = user.Name;
            }
            else
            {
                userName = "unknown";
            }

            Console.WriteLine("The user's name is {0}", userName);

            Console.ReadKey();
        }
    }
}
