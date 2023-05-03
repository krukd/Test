namespace Test
{



    class User
    {
        private int age;

        private string login;

        private string email;


        public string Login
        {
            get { return login; }

            set 
            {
            if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен быть не менее 3 символов");
                }
                else
                {
                    login = value;
                }
            
            }
        }

        public string Email
        {
            get { return email; }

            set {
                if (!value.Contains('@'))
                {
                    Console.WriteLine("Email должен включать символ @");
                }
                else
                {
                    email = value;
                }
                    
                }
        }



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
    }


    class SmartHelper
    {
        private string name;

        public SmartHelper(string name)
        {
            this.name = name;
        }

        public void Greetings(string name)
        {
            Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
        }
    }


    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        public DerivedClass(string name, string description) : base(name)
        {
            Description = description;
        }

        public DerivedClass(string name, string description, int counter) : base(name)
        {
            Description = description;
            Counter = counter;
        }

        /*public DerivedClass(string name, string description, int counter) : this(name, description) 
        {
          Counter = counter;
        }*/
    }
    internal class Program
    {


        
        static void Main(string[] args)
        {

            SmartHelper helper = new SmartHelper("Олег");

            helper.Greetings("Грег");
        }


        
 }
}