namespace Triangulo_Orientado_a_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 numeros\n");
            int ladoA = int.Parse(Console.ReadLine());
            int ladoB = int.Parse(Console.ReadLine());
            int ladoC = int.Parse(Console.ReadLine());

            Triangulos triangulo = new Triangulos(ladoA, ladoB, ladoC);
            string tipo = triangulo.CalcularTriangulos();

            Console.WriteLine(tipo);

            Console.ReadKey();
        }
    }
}