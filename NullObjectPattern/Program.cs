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

            Console.WriteLine("The user's name is {0}", user.Name);

            Console.ReadKey();
        }
    }
}
