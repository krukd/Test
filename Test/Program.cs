using System.Numerics;

namespace Test
{



    class Obj
    {
        public static int MaxValue = 2000;

        public string Name;
        public string Description;
    }

    class Helper
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
    abstract class ComputerPart
    {
        public abstract void Work();
        
    }

    class Processor : ComputerPart { 

        public override void Work()
        {

        }
    
    }

    class MotherBoard : ComputerPart
    {

        public override void Work()
        {

        }

    }

    class GraphicCard : ComputerPart
    {

        public override void Work()
        {

        }

    }

    /*class Obj
    {
        public int Value;

        public static Obj operator +(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value + b.Value
            };
        }
        public static Obj operator -(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value - b.Value
            };
        }
    }*/

    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }

    }

    static class IntExtensions
    {
        public static int GetNegative(this int source)
        {
            if(source > 0)
            {
                return - source;
            }
            else
            {
                return source;
            }
        }

        public static int GetPositive(this int source)
        {
            if (source < 0)
            {
                return - source;
            }
            else
            {
                return source;
            }
        }
    }





    internal class Program
    {


        
        static void Main(string[] args)
        {
            /*D d = new D();
            E e = new E();

            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();*/

            /*int num1 = 3;
            int num2 = 58;*/

            int num1 = 7;
            int num2 = -13;
            int num3 = 0;

            /* Helper.Swap(ref num1, ref num2);
             Console.WriteLine(num1); //58
             Console.WriteLine(num2);*/
            Console.WriteLine(num1.GetNegative()); //-7
            Console.WriteLine(num1.GetPositive()); //7
            Console.WriteLine(num2.GetNegative()); //-13
            Console.WriteLine(num2.GetPositive()); //13
            Console.WriteLine(num3.GetNegative()); //0
            Console.WriteLine(num3.GetPositive()); //0
        }


        
 }
}