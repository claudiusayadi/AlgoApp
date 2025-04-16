namespace _03MultiplicationTable;

/// <summary>
/// Provides methods to generate multiplication tables.
/// </summary>
public class MultiplicationTableGenerator
{
    /// <summary>
    /// Generates the multiplication table for a number up to a specified limit.
    /// </summary>
    /// <param name="n">The number to generate multiplication table for.</param>
    /// <returns>An array of strings representing each line of the multiplication table.</returns>
    public static string[] Generate(int n)
    {
        int limit = 12;
        string[] table = new string[limit];

        for (int i = 1; i <= limit; i++)
        {
            table[i - 1] = $"{n} x {i} = {n * i}";
        }

        return table;
    }
}
