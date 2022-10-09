namespace Task6_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        class User
        {
            private int age;
            private string login;
            private string email;

            public int Age
            {
                get
                {
                    return age;
                }

                set
                {
                    if (value < 18)
                    {
                        Console.WriteLine("Возраст должен быть не меньше 18");
                    }
                    else
                    {
                        age = value;
                    }
                }
            }

            public string Login
            {
                get 
                { 
                    return login;
                }

                set 
                { 
                    if (Login.Length >= 3)
                        login = value;
                    else
                        Console.WriteLine("Логин должен быть не меньше 3 символов");
                }
            }

            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    if (Email.Contains("@"))
                        email = value;
                    else
                        Console.WriteLine("Почта должна содержать символ @");
                }
            }
        }
    }
}