using System.Drawing;
using System;

namespace PJT2502031
{
    internal class Program
    {
        static int size = 20;
        static int[,] data = new int[size, size];

        // 함수의 형태
        /// <summary>
        /// 배열 초기화
        /// </summary>
        static void Initialize() // PascalCase
        {
            int num = 1;

            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    //data[j, i] = (j * size) + (i + 1);
                    data[j, i] = num++;
                }
            }
        }

        /// <summary>
        /// 배열 출력
        /// </summary>
        static void Print()
        {
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write(data[j, i].ToString() + "\t");
                }
                Console.WriteLine();
            }
        }

        static void PrintStar()
        {
            for (int j = 1; j <= size; j++)
            {
                for (int k = 1; k <= size - j; k++)
                {
                    Console.Write(' ');
                }
                for (int i = 1; i <= j; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 두 정수 곱셈
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }


        static void Main(string[] args)
        {
            // 배열 초기화
            //Initialize();

            // 배열 출력
            //Print();

            // 별 찍기
            //PrintStar();

            // 곱셈 테스트
            Console.WriteLine(Multiply(5, 7.3f));
        }
    }
}
