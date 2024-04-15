using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class TeddyToysFactory : IToyFactory
    {
        public Bear GetBear()
        {
            return new TeddyBear("Teddy Bear");
        }

        public Cat GetCat()
        {
            return new TeddyCat("Teddy Cat");
        }
    }
}
