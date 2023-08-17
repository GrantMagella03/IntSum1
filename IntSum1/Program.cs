internal class Program
{
    private static void Main(string[] args)
    {
        float[] nbrs = { 9, 1, 6, 9, 2, 4, 5, 3, 1, 3 };
        float sum = 0;
        float oddsum = 0;
        for (int idx=0; idx<nbrs.Length; idx++)
        {
            sum += nbrs[idx];
            if (nbrs[idx]%2==1)
            {
                oddsum += nbrs[idx] * nbrs[idx];
            }
        }
        Console.WriteLine($"Sum:"+sum);
        Console.WriteLine($"Oddsum^2: "+oddsum);
        float avg = 0;
        avg = sum / nbrs.Length; 
        Console.WriteLine(avg);
    }
}