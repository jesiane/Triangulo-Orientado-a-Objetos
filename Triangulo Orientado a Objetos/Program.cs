namespace Triangulo_Orientado_a_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulos triangulos = new Triangulos();

            triangulos.ladoA = 7;
            triangulos.ladoB = 8;
            triangulos.ladoC = 9;


            Console.WriteLine(triangulos.CalculoTriangulos());
            
        }
    }
}