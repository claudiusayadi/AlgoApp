namespace _06FibonacciSequence;

/// <summary>
/// Provides methods to work with Fibonacci sequences.
/// </summary>
public class FibonacciGenerator
{
    /// <summary>
    /// Generates the first n terms of the Fibonacci sequence.
    /// </summary>
    /// <param name="n">The number of terms to generate.</param>
    /// <returns>An array containing the first n terms of the Fibonacci sequence.</returns>
    public static int[] GenerateSequence(int n)
    {
        List<int> sequence = [];
        int n1 = 0;
        int n2 = 1;
        int nth;

        sequence.Add(n1);
        sequence.Add(n2);

        for (int i = 2; i < n; i++)
        {
            nth = n1 + n2;
            sequence.Add(nth);
            n1 = n2;
            n2 = nth;
        }

        return sequence.ToArray();
    }
}
