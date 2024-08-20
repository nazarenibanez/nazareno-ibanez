using System.Text;

namespace ClassLibrary1
{
    public class Prismadatos
    {
        public Prismadatos(int longitud, int ancho, int altura) 
        {
            Longitud = longitud;
            Ancho = ancho;
            Altura = altura;
        
        }
        public int Longitud { get; set; }
        public int Ancho { get; set; }  
        public int Altura { get; set; }

        public double getvolumen() => Longitud * Ancho * Altura;
        public double getarea() => 2 * (Longitud * Ancho + Longitud * Altura + Altura * Ancho);
        public double getdiagonal() => Math.Sqrt(Math.Pow(Longitud, 2) + Math.Pow(Ancho, 2) + Math.Pow(Altura, 2));

        public override string ToString() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del prisma");
            sb.AppendLine($"La lungitud: {Longitud}");
            sb.AppendLine($"La altura: {Altura}");
            sb.AppendLine($"El ancho: {Ancho}");
            sb.AppendLine($"Su volumen: {getvolumen()}");
            sb.AppendLine($"Su area: {getarea()}");
            sb.AppendLine($"Su diagonal: {getdiagonal():N2}");
            return sb.ToString();


        }


    }
}
