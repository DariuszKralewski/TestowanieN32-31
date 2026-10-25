using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.Podstawy
{
    public class ActionResult { } // Base class for all action results
    public class NotFound : ActionResult { } // 404
    public class Ok : ActionResult { }  // 200
    public class CustomerController
    {
        public ActionResult GetCustomer(int id)
        {
            if (id <= 0) return new NotFound(); // Return 404 if the id is invalid

            return new Ok(); // Return 200 if the customer is found
        }
    }
}
