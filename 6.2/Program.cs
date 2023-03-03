using System;
namespace hhej
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine(Störst(5, 16));
        }
      

        static int Störst(int tal1, int tal2)
        {
            int Strst;
            if (tal1 > tal2)
            {
                Strst = tal1;
            }
            else
            {
                Strst = tal2;
            }
            {
                return Strst;
            }
        }
    }
}