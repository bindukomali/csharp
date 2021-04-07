using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class RBI
    {
        const float RATE_RBI = 6.5f;
          public float calculateBalanceRBI(int amount, int years)
        {
            return amount + ((RATE_RBI * years) / 100);
        }
    }



    class SBI : RBI
    {
        const float RATE_SBI = 7f;
         public float calculateBalanceSBI(int amount, int years)
        {
            return amount + ((RATE_SBI * years) / 100);
        }
    }



    class Canara : SBI
    {
        const float RATE_CANARA = 7.2f;
          public float calculateBalanceCanara(int amount, int years)
        {
            return amount + ((RATE_CANARA * years) / 100);
        }
    }
    class MultiLevelBank
    {
        static void Main()
        {
            Canara c1 = new Canara();
            Console.WriteLine("Enter the amount you want to Invest:");
            int amount = Convert.ToInt32(Console.ReadLine());
            int years = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Maturity Amount as per Canara Bank :"
                             + c1.calculateBalanceCanara(amount, years));



            Console.WriteLine("Maturity Amount as per SBI  :"
                             + c1.calculateBalanceCanara(amount, years));



            Console.WriteLine("Maturity Amount as per RBI :"
                             + c1.calculateBalanceCanara(amount, years));



            Console.ReadKey();
        }
    }
}