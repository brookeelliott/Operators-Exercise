namespace OperatorExercise
{
    public class Program
    {

        public static void AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            var Radius = double.Parse(Console.ReadLine());
            double Area = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"The area of a circle with a radius {Radius} is {Area}");
        }

        static void Main(string[] args)
        {
            //Exercise 1:

            int num1 = 2;
            int num2 = 4;
            int num3 = 6;
            int num4 = 9;

            int SumNum = num1 + num2;
            Console.WriteLine($"{SumNum}");

            int SubNum = num4 - num3;
            Console.WriteLine($"{SubNum}");

            int MultNum = num4 * num3;
            Console.WriteLine($"{MultNum}");

            int DivNum = num3 / num1;
            Console.WriteLine($"{DivNum}");

            int ModNum = num4 % num1;
            Console.WriteLine($"{ModNum}");

            int a = 234;
            int b = 77;
            int quotent = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotent} remainder {remainder}");


            //Exercise 2:

            AreaOfCircle();

        }
    }
}
