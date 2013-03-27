using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimusSolution
{
    namespace P1005
    {
        public class P1005Solver
        {
            public string Solve(int[] stones)
            {
                return String.Empty;
            }

            public int[] ReadInput(System.IO.TextReader inStream)
            {
                var nfi = NumberFormatInfo.InvariantInfo;
                var args = inStream.ReadToEnd().Split(new[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);

                var lenstr = Int32.Parse(args[0], nfi);
                if (lenstr ==0)
                    return new int[0];
                var entries = args[1].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Take(lenstr).Select(entr => Int32.Parse(entr, nfi)).ToArray();

                return entries;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var solver = new TimusSolution.P1005.P1005Solver();
            var input = solver.ReadInput(Console.In);
            var output = solver.Solve(input);
            Console.WriteLine(output);
        }
    }
}
