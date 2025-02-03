namespace PJT2502031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
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
