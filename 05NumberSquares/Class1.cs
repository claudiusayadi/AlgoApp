namespace _05NumberSquares;

/// <summary>
/// Provides methods to calculate squares of numbers.
/// </summary>
public class SquareCalculator
{
    /// <summary>
    /// Calculates the squares of numbers from 1 to 10.
    /// </summary>
    public static string[] CalculateSquares()
    {
        string[] squares = new string[10];
        for (int i = 1; i <= 10; i++)
        {
            squares[i - 1] = $"{i} square = {i * i}";
        }

        return squares;
    }
}
