namespace Test
{


    class Human
    {
        // Поля класса
        public string name;
        public int age;

        // Конструктор 1
        public Human()
        {
            name = "Неизвестно";
            age = 20;
        }
        // Конструктор 2
        public Human(string n)
        {
            name = n;
            age = 20;
        }
        // Конструктор 3
        public Human(string n, int a)
        {
            name = n;
            age = a;
        }

        // Метод класса
        public void Greetings()
        {
            Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
        }
    }

    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {

            color = "Черный";
            cost = 100;
        }

        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }

    class Rectangle
    {
        public int sideA;
        public int sideB;


        public int Square()
        {
            return sideA * sideB;
        }

        public Rectangle(int a, int b)
        {
            sideA = a;
            sideB = b;
        }

        public Rectangle(int a)
        {
            sideA = a;
            sideB = a;
        }

        public Rectangle()
        {
            sideA = 6;
            sideB = 4;
        }
    }

    struct Animal
    {
        // Поля структуры
        public string type;
        public string name;
        public int age;

        // Метод структуры
        public void Info()
        {
            Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
        }
    }
    internal class Program
    {


        
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Greetings();

            human = new Human("Дмитрий");
            human.Greetings();

            human = new Human("Дмитрий", 23);
            human.Greetings();

            Animal animal = new Animal {type = "Собака", name = "Вольт", age = 4};

            Console.ReadKey();

        }


        
  }
}