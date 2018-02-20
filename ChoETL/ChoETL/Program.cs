using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//From URL: https://www.codeproject.com/Articles/1145337/Cinchoo-ETL-CSV-Reader#1.Introduction0

namespace ChoETL
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (dynamic e in new ChoCSVReader("Emp.csv").WithFirstLineHeader())
            {
                Console.WriteLine(string.Format("ID: {0}", e.ID));
                Console.WriteLine(string.Format("Name: {1}", e.Name));
            }
        }
    }
}
