using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class WoodenToysFactory : IToyFactory
    {
        public Bear GetBear()
        {
            return new WoodenBear("Wooden Bear");
        }

        public Cat GetCat()
        {
            return new WoodenCat("Wooden Cat");
        }
    }
}
