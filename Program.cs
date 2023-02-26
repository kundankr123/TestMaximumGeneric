namespace TestMaximumGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum using Generics Program.");

            //Console.WriteLine("Maximum using CompareTo() Method");
            //Console.WriteLine("Enter 1st Number: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter 2nd Number: ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter 3rd Number: ");
            //double c = Convert.ToDouble(Console.ReadLine());

            //double max = MaximumFloat.MaximumFloatNumber(a, b, c);
            //Console.WriteLine("The maximum of the given three numbers is : " + max);


            //Console.WriteLine("Maximum using CompareTo() Mathod");
            //Console.WriteLine("Enter 1st String: ");
            //string a = Console.ReadLine();
            //Console.WriteLine("Enter 2nd String: ");
            //string b = Console.ReadLine();
            //Console.WriteLine("Enter 3rd String: ");
            //string c = Console.ReadLine();



            //string max = Maximumstring.MaximumString(a, b, c);

            //Console.WriteLine("The maximum of the given three String is : " + max);


            Console.WriteLine("Integer Values");
            GenericMaximum.Compare<int>(10, 9, 111);
            Console.WriteLine("Double Values");
            GenericMaximum.Compare<double>(1.1, 2.2, 3.3);
            Console.WriteLine("String Values");
            GenericMaximum.Compare<string>("abc", "bca", "cba");
        }
    }
}