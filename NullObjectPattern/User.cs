using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class User : IUser
    {
        public Guid ID { get; set; }

        public bool IsNull
        {
            get
            {
                return false;
            }
        }

        public string Name { get; }

        private DateTime sessionExpiry;

        public User(Guid guid)
        {

        }
        public void IncrementSesssionTicket()
        {
            // None
        }
    }
}
