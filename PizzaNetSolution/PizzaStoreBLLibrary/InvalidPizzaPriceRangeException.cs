using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreBLLibrary
{
    public class InvalidPizzaPriceRangeException : Exception
    {
        string message;
        public InvalidPizzaPriceRangeException()
        {
            message = "The price range is not valid";
        }
        public override string Message => message;
    }
}
