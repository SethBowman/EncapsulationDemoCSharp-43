using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemoCSharp_43
{
    public class Person
    {
        //properties
        public string Name { get; set; }
        public int Age { get; set; }

        //fields
        private double _wallet;

        //methods that access our private field
        public void AddMoney(double moneyToAdd)
        {
            _wallet += moneyToAdd;
        }

        public double CheckWallet()
        {
            return _wallet;
        }
    }
}
