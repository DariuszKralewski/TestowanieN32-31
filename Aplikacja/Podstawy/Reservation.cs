using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.Podstawy
{
    public class Reservation
    {
        public User MadeBy { get; set; } //rezerwujący

        //odwołać może Administrator
        //odwołać może rezerwujący
        public bool CanBeCancelledBy(User user) => user.IsAdmin || user == MadeBy ;
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
