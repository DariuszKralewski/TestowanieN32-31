using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    public class ErrorLogger
    {
        public string LastError { get; set; } // Property to store the last error message

        public void LogError(string errorMessage)
        {
            //sprawdzenie, czy przekazany komunikat błędu nie jest pusty lub null
            //null, "", "   " - nie są dozwolone
            if (string.IsNullOrWhiteSpace(errorMessage))
                throw new ArgumentException("Error message cannot be null or empty.");            

            LastError = errorMessage; // Store the error message           
        }
    }
}
