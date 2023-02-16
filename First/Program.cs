namespace First
{
    internal class Program
    {
        delegate double Operation(double x, double y);
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            Operation addition = (a, b) => a + b;
            Operation subtraction = (a, b) => a - b;
            Operation multiplication = (a, b) => a * b;
            Operation division = (a, b) =>
            {
                if (b == 0)
                {
                    Console.WriteLine("Не можна ділити на 0");
                    return 0;
                }
                else
                {
                    return a / b;
                }
            };

            Console.WriteLine("Введіть оператор +, -, *, / ");
            string oper = Console.ReadLine();

            Console.WriteLine("Введіть 2 цифри: ");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            switch (oper)
            {
                case "+":
                    Console.WriteLine(addition(num1, num2));
                    break;
                case "-":
                    Console.WriteLine(subtraction(num1, num2));
                    break;
                case "*":
                    Console.WriteLine(multiplication(num1, num2));
                    break;
                case "/":
                    Console.WriteLine(division(num1, num2));
                    break;
                default:
                    Console.WriteLine("Неправильний оператор");
                    break;
            }

            Console.ReadLine();
        }
    }
}
