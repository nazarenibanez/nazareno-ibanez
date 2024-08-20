namespace ConsoleApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ingresar la longitud: ");
            int longitud = int.Parse(Console.ReadLine());
            Console.Write("Ingresar el ancho: ");
            int ancho = int.Parse(Console.ReadLine());
            Console.Write("Ingresar la altura: ");
            int altura = int.Parse(Console.ReadLine());

            int ifvolumen = longitud * ancho * altura;
            Console.WriteLine($"El volumen del prisma rectangular es de: {ifvolumen}");
            int ifarea = 2 * (longitud * ancho + longitud * altura + altura * ancho);
            Console.WriteLine($"El area del prisma rectangular es de: {ifarea}");
            double ifdiagonal = Math.Sqrt(Math.Pow(longitud, 2) + Math.Pow(ancho, 2) + Math.Pow(altura,2));
            Console.WriteLine($"La diagonal del prima rectangular es de: {ifdiagonal}");

        }
    }
}
