namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 10;
            int sum2 = 20;
            int sum=sum1+sum2;
            bool dead=false;
            float a = 2.11f;
            string UserName = "Albert";
            string Password = "88888888";
            
            double b = 2.88d;
            double c = a + b;
            Console.WriteLine(c);
            Console.WriteLine(UserName +" -- "+ Password);
            Console.WriteLine(sum);
            Console.WriteLine(sum1!=sum2);
            Console.WriteLine(sum2>sum1 && a>b);
            Console.WriteLine(dead);
           
        }
    }
}