namespace Task6_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        
        /// <summary>
        /// Прямоугольник
        /// </summary>
        class Rectangle
        {
            public int a, b;

            public Rectangle()
            {
                a = 6; 
                b = 4;
            }

            public Rectangle(int _a)
            {
                a = _a;
                b = _a;
            }

            public Rectangle(int _a, int _b)
            {
                a = _a;
                b = _b;
            }

            /// <summary>
            /// Площать прямоугольника
            /// </summary>
            /// <returns></returns>
            public int Square()
            {
                return a * b;
            }
        }
    }
}