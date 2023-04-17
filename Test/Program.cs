namespace Test
{
    internal class Program
    {


        /*Необходимо создать метод, который заполняет данные с клавиатуры по пользователю 
         * (возвращает кортеж):
        Имя;
        Фамилия;
        Возраст;
        Наличие питомца;
        Если питомец есть, то запросить количество питомцев;
        Если питомец есть, вызвать метод, принимающий на вход количество питомцев и 
        возвращающий массив их кличек (заполнение с клавиатуры);
        Запросить количество любимых цветов;
        Вызвать метод, который возвращает массив любимых цветов по их количеству (заполнение с 
        клавиатуры);
        Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, 
        количество цветов в отдельном методе;
        Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
        Корректный ввод: ввод числа типа int больше 0.
        Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
        Вызов методов из метода Main.
        
         
         Для проверки используйте метод TryParse.
        
         Не забывайте проверку на 0 количество.
        
         Для построения условия вам необходимо использовать условные конструкции. Необходимо 
        также запрашивать у пользователя корректное значение до тех пор,пока данные не будут 
        корректны.*/
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //EnterUser();

            PrintInfo(EnterUser());
        }


        static (string Name, string LastName, int Age, string[] Pets, string[] Favcolors) EnterUser()
        {
            (string Name, string LastName, int Age, string[] Pets, string[] Favcolors) User;

            Console.WriteLine("Введите ваше имя:");

            User.Name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию:");

            User.LastName = Console.ReadLine();

            string age;
            int intage;

            do
            {
                Console.WriteLine("Введите возраст цифрами");
                age = Console.ReadLine();
            } while (CheckNum(age, out intage));

            User.Age = intage;

            Console.WriteLine("Есть ли у вас питомцы?");

            string hasPets = Console.ReadLine();

            string petsNumber;
            int intPetsNumber;




            do
            {

                Console.WriteLine("Сколько питомцев у вас есть?");
                petsNumber = Console.ReadLine();


            } while (CheckNum(petsNumber, out intPetsNumber));

            User.Pets = CreateArrayPets(intPetsNumber);



            /* else
             {
                 Console.WriteLine("Спасибо за ответ!");
             }
 */
            //User.Pets = CreateArrayPets(petsNumber);


            string colorsNumber;
            int intcolorsNumber;

            do
            {
                Console.WriteLine("Сколько у вас любимых цветов?");

                colorsNumber = Console.ReadLine();
            } while (CheckNum(colorsNumber, out intcolorsNumber));



            User.Favcolors = CreateArrayFavcolors(intcolorsNumber);


            User = (User.Name, User.LastName, User.Age, User.Pets, User.Favcolors);

            return User;
        }


        static bool CheckNum(string number, out int correctnum)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    correctnum = intnum;
                    return false;
                }
            }

            {
                correctnum = 0;
                return true;
            }
        }

        static string[] CreateArrayPets(int number)
        {
            string[] arr = new string[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Введите кличку питомца номер {0}", i + 1);
                arr[i] = Console.ReadLine();
            }

            return arr;

        }


        static string[] CreateArrayFavcolors(int number)
        {
            string[] arr = new string[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
                arr[i] = Console.ReadLine();
            }

            return arr;

        }

        static void PrintInfo((string Name, string LastName, int Age, string[] Pets, string[] Favcolors) User){

            Console.WriteLine("Name: {0}", User.Name);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
    }
 }
}