namespace Ordena
{

    /// <summary>
    /// Clase principal, que contendra la aplicacion
    /// msm - 17-10-23
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal,donde se espeicifica el orden de los metodos
        /// msm - 17-10-23
        /// </summary>
        /// <param name="args"></param>
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

            //Con el if hacemos que los numeros salgan de mayor a menor, en base a condiciones,tenemos varios if para cada numero 
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