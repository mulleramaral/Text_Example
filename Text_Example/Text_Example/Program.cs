using System;
using System.Text;

namespace Text_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StringBuilder
            StringBuilder sb = new StringBuilder();

            sb.Append("New");
            sb.Append("York");

            sb.Insert(5, " HELLO ");
            sb.Remove(5, 6);
            sb.Replace('k', 'q');


            Console.Write(sb);
            sb.Clear();
            Console.ReadKey();
            #endregion
        }
    }
}
