namespace Second
{
    delegate int Del();

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Func<Del[], double> average = delegate (Del[] arr)
            {
                double sum = 0;
                foreach (Del del in arr)
                {
                    sum += del();
                }
                return sum / arr.Length;
            };

            Del[] delegates = new Del[5];

            for (int i = 0; i < 5; i++)
            {
                delegates[i] = delegate
                {
                    Random rnd = new Random();
                    return rnd.Next(1, 50);
                };
            }

            Console.WriteLine("Середнє значення = " + average(delegates));

        }
    }
}