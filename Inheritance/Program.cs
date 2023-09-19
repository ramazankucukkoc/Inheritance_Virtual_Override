namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car car = new Car("Mercedes", "Yeni GLA.",2023);
            car.Run();
            car.Stop(); 
            Console.ReadLine();

        }
    }
}