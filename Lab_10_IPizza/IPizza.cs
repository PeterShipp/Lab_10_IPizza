using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10_IPizza
{
    public interface IPizza
    {

        public string[] ingredients { get; set; }
        public StringBuilder Prepare();
        public string AddToppings();
    }
}
