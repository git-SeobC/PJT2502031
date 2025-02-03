namespace PJT2502031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[,] data = new int[size, size];
            int num = 1;

            // 배열 초기화
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    //data[j, i] = (j * size) + (i + 1);
                    data[j, i] = num++;
                }
            }

            // 배열 출력
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write(data[j, i].ToString() + "\t");
                }
                Console.WriteLine();
            }

            // 별 찍기
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
    }
}
