using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree
{
    class CValue
    {
        public int current { get; set; }
        public int upperLimit { get; set; }
        public int lowerLimit { get; set; }
    }



    class Program
    {



        static void Main(string[] args)
        {
            int upperLimit = 63;
            int lowerLimit = 1;


            List<int> path = new List<int>();

            path.Add(15);

            int answer = BuildPath(15, ref upperLimit, ref lowerLimit, path, true);
            Console.WriteLine($"answer = {answer}");

            path.Add(answer);
            answer = BuildPath(answer, ref upperLimit, ref lowerLimit, path,false);
            Console.WriteLine($"answer = {answer}");
                     
            path.Add(answer);
            answer = BuildPath(answer, ref upperLimit, ref lowerLimit, path, true);
            Console.WriteLine($"answer = {answer}");

            path.Add(answer);
            answer = BuildPath(answer, ref upperLimit, ref lowerLimit, path, false);
            Console.WriteLine($"answer = {answer}");

            path.Add(answer);
            answer = BuildPath(answer, ref upperLimit, ref lowerLimit, path, false);
            Console.WriteLine($"answer = {answer}");


            path.Add(answer);
            answer = BuildPath(answer, ref upperLimit, ref lowerLimit, path, false);
            Console.WriteLine($"answer = {answer}");

            path.Add(answer);
            answer = BuildPath(answer, ref upperLimit, ref lowerLimit, path, false);
            Console.WriteLine($"answer = {answer}");





        }



        private static int BuildPath(int Cdata, ref int upperLimit, ref int lowerLimit, List<int> Cpath, bool isRChild)
        {
            if (isRChild == true )
            {
                int nextCdata = (upperLimit + Cdata) / 2;
                lowerLimit = Cdata;
                return nextCdata;
            }
            else 
            {
                int nextCdata = (lowerLimit + Cdata) / 2;
                upperLimit = Cdata;
                return nextCdata;
            }



        }
    }
}
