namespace _01NaturalSum;

/// <summary>
/// Provides methods to calculate the sum of natural numbers.
/// </summary>
public class NaturalNumberCalculator
{
    /// <summary>
    /// Calculates the sum of first n natural numbers.
    /// </summary>
    /// <param name="n">The number of natural numbers to sum.</param>
    /// <returns>The sum of first n natural numbers.</returns>
    public static int CalculateSum(int n)
    {
        int sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }
}
