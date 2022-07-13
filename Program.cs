namespace GCH1103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: Truong Giang");
            Console.WriteLine("Age: 21");
            Console.WriteLine("Study: IT");
            Console.WriteLine("Like: Watermelon");
            Console.WriteLine("Dislike: Mamtom");
            int a = 123; //declare variable
            Console.WriteLine("a = " + a);
            float b = 3.5f; //kdl double
            a = (int)(b * 2); //cast
            Console.WriteLine("b = {0}, a = {1}", b , a);
            const double SOI = 100; // declare constant
            //input data
            int c;
            Console.Write("Input c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("After Input: {0}",c);

        }
    }
}