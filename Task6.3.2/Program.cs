namespace Task6_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus= new Bus();
            bus.Load = 10;
            bus.PrintStatus();
            Console.ReadLine();
        }

        /// <summary>
        /// Автобус
        /// </summary>
        class Bus
        {
            public int? Load;

            public void PrintStatus()
            {
                if (Load.HasValue)
                    Console.WriteLine($"Автобус имеет {Load} мест");
                else
                    Console.WriteLine("В Автобусе нет мест");
            }
        }
    }
}