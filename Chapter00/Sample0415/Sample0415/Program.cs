using System.Diagnostics.CodeAnalysis;

namespace Sample0415
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int sum = 0;

            //入力
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("arrya[" + i + "] = ");
                array[i] = int.Parse(Console.ReadLine());     //arrayの配列に値を格納
            }

            //出力
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[" + i + "]");
                astOut(array[i]);
            }

            //集計
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];
            //}

            //合計を出力
            Console.WriteLine("合計 = " + array.Where(n => n % 2 == 0).Sum());
        }
        //メソッド
        static void astOut(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();    //改行
        }
    }
}