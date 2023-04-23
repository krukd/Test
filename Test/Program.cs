namespace Test
{

    class Circle
    {
        public double radius;

        /*public double Square()
        {
        }*/

        /*public double Length()
        {
        }*/
    }

    class Triangle
    {
        public int a;
        public int b;
        public int c;

        /*public double Square()
        {
        }*/

        /*public double Perimeter()
        {
        }*/
    }

    class Square
    {
        public int side;

        /*public double Square()
        {
        }*/

        /*public double Perimeter()
        {
        }*/
    }
    class Car
    {
        public double Fuel;

        public int Mileage;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }

        public void Move()
        {
            // Move a kilometer
            Mileage++;
            Fuel -= 0.5;
        }

        public void FillTheCar()
        {
            Fuel = 50;
        }
    }
    internal class Program
    {


        
        static void Main(string[] args)
        {
            
            
        }


        
 }
}