internal class Program
{
    private static void Main(string[] args)
    {
        float[] nbrs = { 9, 1, 6, 9, 2, 4, 5, 3, 1, 3 };
        int index = 0;
        float sum = 0;
        while (index < 10)
        {
            sum += nbrs[index];
            index++;
        }
        Console.WriteLine(sum);
        float avg = 0;
        avg = sum / 10; 
        Console.WriteLine(avg);
    }
}