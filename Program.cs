using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string sequenceNumber = "00000000";
            string acknowledgeNumber = "00000000";
            string flags_data = "51020000";//flags and other info
            string studentId = "8136590";
            int sourcePortTemp = int.Parse(studentId.Substring(3, 4));
            int destinationPortTemp = int.Parse(studentId.Substring(0, 4));
            string sourcePortHexValue = sourcePortTemp.ToString("X");
            //int sourcePrt = int.Parse(sourcePortHexValue, System.Globalization.NumberStyles.HexNumber);
            string destinationPrtHexValue = destinationPortTemp.ToString("X");
            //int destinationPrt = int.Parse(destinationPrtHexValue, System.Globalization.NumberStyles.HexNumber);
            sb.Append(sourcePortHexValue);
            sb.Append(destinationPrtHexValue);
            sb.Append(sequenceNumber);
            sb.Append(acknowledgeNumber);
            sb.Append(flags_data);
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
