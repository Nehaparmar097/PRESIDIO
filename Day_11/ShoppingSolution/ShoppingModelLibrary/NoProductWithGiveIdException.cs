using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingModelLibrary
{
    public class NoProductWithGiveIdException:Exception
    {
        string message;
        public NoProductWithGiveIdException()
        {
            message = "Customer with the given Id is not present";
        }
        public override string Message => message;
    }
}
