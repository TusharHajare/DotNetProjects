using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreDallLibrary
{
    public class PizzaStackEmptyException : Exception
    {
        string message;
        public PizzaStackEmptyException()
        {
            message = "No Pizzas available at this moment, Sorry";
        }
        public override string Message => message;
    }
}
