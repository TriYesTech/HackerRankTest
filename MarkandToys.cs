class Solution {

    // Complete the maximumToys function below.
    static int maximumToys(int[] prices, int k) {

        Array.Sort(prices);
        
        int affordCount = 0;
        
        foreach(int itemPrice in prices)
        {
            k = k-itemPrice;
            
            if(k <= 0)
                break;
            
            affordCount++;
        }

        return affordCount;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
        ;
        int result = maximumToys(prices, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
