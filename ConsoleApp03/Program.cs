using ClassLibrary1;

namespace ConsoleApp03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prisma rectangular");
            int longitud;
            bool esvalido = true;
            do
            {
                Console.Write("ingrese la longitud: ");
                if (!int.TryParse(Console.ReadLine(), out longitud) || longitud<=0) 
                {
                    Console.Write("longitud no valida por favor reintentar");
                
                }
                else 
                {
                    esvalido = false;
                
                }


            } while (esvalido);
            int ancho;
            esvalido = true;
            do
            {
                Console.Write("ingrese la ancho: ");
                if (!int.TryParse(Console.ReadLine(), out ancho) || ancho <= 0)
                {
                    Console.Write("longitud no valida por favor reintentar");

                }
                else
                {
                    esvalido = false;

                }


            } while (esvalido);
            int altura;
            esvalido = true;
            do
            {
                Console.Write("ingrese la altura: ");
                if (!int.TryParse(Console.ReadLine(), out altura) || altura <= 0)
                {
                    Console.Write("longitud no valida por favor reintentar");

                }
                else
                {
                    esvalido = false;

                }


            } while (esvalido);
            Prismadatos prisma = new Prismadatos(longitud, ancho, altura);
            Console.WriteLine(prisma.ToString());
        }
    }
}
