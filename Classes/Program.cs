using System.Data;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car prius = new Car();
            prius.Make = "Toyota";
            prius.Model = "Prius";
            prius.Year = 2013;
            Console.Write(prius.Make);
            Console.Write(prius.Model);
            Console.Write(prius.Year);
        }
    }
}
