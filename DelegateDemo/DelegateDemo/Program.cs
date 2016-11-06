using System;

namespace DelegateDemo
{
    class Program
    {
        public delegate int ChangeValue(int number);
        static void Main(string[] args)
        {
            ChangeValue cv1 = new ChangeValue(AddNum);
            ChangeValue cv2 = new ChangeValue(MulNum);
            cv1(20);
            Console.WriteLine("Addnum ={0}", initialNumber);
            cv2(2);
            Console.WriteLine("Addnum ={0}", initialNumber);

            Console.ReadKey();
        }

        static int initialNumber = 10;

        public static int AddNum(int num)
        {
            return initialNumber += num;
        }

        public static int MulNum(int num)
        {
            return initialNumber *= num;
        }

    }
}
