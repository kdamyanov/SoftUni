using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class money
    {
        static void Main()
        {
            var nBitcoin = double.Parse(Console.ReadLine());
            var nCny = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());

            var BitcoinToBgn = nBitcoin * 1168;
            var cnyToBgn = (nCny * 0.15) * 1.76;

            var totalInEur = ((BitcoinToBgn + cnyToBgn) / 1.95);

            var com = totalInEur * commission/100;

            Console.WriteLine("{0}", totalInEur - com);
        }
    }
}
