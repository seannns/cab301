var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


// ALGORITHM MinDistance(A[0..n-1])
// Given an array of length n, return the difference between the two closest values
// dmin = infinity
// for i = 0 to n -1, do
//      for j = i + 1 to n - 1 do
//      temp = A[i] - A[j]
//      if temp < dmin
//          dmin = temp
// return dmin

{
    static float MinDistance(int[] arr)
    {
        var dmin = float.MaxValue;
        var n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                var temp = Math.Abs(arr[i] - arr[j]);
                if (temp < dmin)
                {
                    dmin = temp;
                }
            }
        }
        return dmin;
    }

    int[] numbers = {5, 1};
    float result = MinDistance(numbers);
    Console.WriteLine(result);
}

app.Run();
