using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SellProductManager : ISellManagerService
    {
        public void Buy(Gamer gamer)
        {
            if (gamer.FirstName =="Eyüp")
            {
                Console.WriteLine("satın alındı");
            }
            else
            {
                Console.WriteLine("satın alma işlemi başarısız oldu");
            }
        }

        public void Refund(Gamer gamer)
        {
            Console.WriteLine("iade yapıldı");
        }
    }
}
