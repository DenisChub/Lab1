namespace Third
{
    internal class Program
    {
        delegate int Operation(int a, int b, int c);

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Operation average = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3;
            };

            Console.WriteLine("Введіть значення для a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть значення для b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть значення для c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Середнє значення: " + average(a, b, c));

            Console.ReadLine();
        }

    }
}