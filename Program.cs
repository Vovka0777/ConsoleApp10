using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 2. Изменить размер одномерного массива.

            //int[] mass = new int[5] { 1, 2, 3, 4, 5 };
            //foreach (int i in mass) { Console.WriteLine(i); }
            //Console.WriteLine("--------------");
            //Array.Resize(ref mass, 4);
            //foreach (int i in mass) { Console.WriteLine(i); }
            //Console.WriteLine("--------------");
            //Array.Resize(ref mass, 3);
            //foreach (int i in mass) { Console.WriteLine(i); }
            //Console.WriteLine("--------------");
            //Array.Resize(ref mass, 2);
            //foreach (int i in mass) { Console.WriteLine(i); }
            //Console.WriteLine("--------------");
            //Array.Resize(ref mass, 6);
            //foreach (int i in mass) { Console.WriteLine(i); }
            //Console.Read();

            //Задача 3. Найти индекс первого отрицательного элемента одномерного массива, заполненного случайным образом в диапазоне от -5 до 5.

            int[] nums = new int[5];
            Random rand = new Random();
            for (int i=0;i<5;i++) {nums[i] = rand.Next(-5,5); Console.WriteLine(nums[i]); }
                int mySecondIndex = Array.FindIndex(nums, min => min<0);
            Console.WriteLine($"Индекс первого отрицательного элемента - {mySecondIndex}");
            Console.Read();
        }
    }
}
