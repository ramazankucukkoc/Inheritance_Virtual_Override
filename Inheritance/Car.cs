namespace Inheritance
{
    public class Car : Vehicle
    {
        public Car(string brandName,string model,int year):base(brandName,model,year) 
        {
            
        }
        public override void Run()
        {
            base.Run();
            Console.WriteLine($"{Model} {BrandName} car running");
        }
        public override void Stop()
        {
            base.Stop();
        }
    }
}
