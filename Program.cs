namespace Ordena
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1;
            float n2;
            float n3;

            Console.WriteLine("Primer numero");
            n1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Segundo numero");
            n2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Tercer numero");
            n3 = Single.Parse(Console.ReadLine());

            if (n1 < n2 && n1 < n3)
            {
                if (n2 < n3) 
                {
                    Console.WriteLine("********************");
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                    Console.WriteLine("********************");

                }
                else
                {
                    Console.WriteLine("********************");
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                    Console.WriteLine(n1);
                    Console.WriteLine("********************");

                }

            }
            

            if (n2 < n3 && n2 < n1)
            {
                if (n1 < n3)
                {
                    Console.WriteLine("********************");
                    Console.WriteLine(n3);
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine("********************");

                }
                else
                {
                    Console.WriteLine("********************");
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                    Console.WriteLine("********************");

                }

            }

            if (n3 < n1 && n3 < n2)
            {
                if (n2 < n1)
                {
                    Console.WriteLine("********************");
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                    Console.WriteLine("********************");

                }
                else
                {
                    Console.WriteLine("********************");
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                    Console.WriteLine("********************");

                }

            }
        }
    }
}