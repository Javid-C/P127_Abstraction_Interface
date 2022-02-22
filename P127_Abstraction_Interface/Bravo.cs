using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Abstraction_Interface
{
    class Bravo : Book,IStorageable,ISuperMarketable
    {
        public void Cashier()
        {
            Console.WriteLine("Cashier(kom:3%)");
        }

        public void Count()
        {
            throw new NotImplementedException();
        }

        public void Courier()
        {
            Console.WriteLine("Courier(2azn)");
        }

        public void Packing()
        {
            throw new NotImplementedException();
        }
    }
}
