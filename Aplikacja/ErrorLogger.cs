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
            LastError = errorMessage; // Store the error message           
        }
    }
}
