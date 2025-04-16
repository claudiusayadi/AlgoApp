namespace _02Factorial;

/// <summary>
/// Provides methods to calculate factorials of numbers.
/// </summary>
public class FactorialCalculator
{
	/// <summary>
	/// Calculates the factorial of a number.
	/// </summary>
	/// <param name="n">The number to calculate factorial for.</param>
	/// <returns>The factorial of n.</returns>
	public static int Calculate(int n)
	{
		int factorial = 1;
		for (int i = 1; i <= n; i++)
		{
			factorial *= i;
		}

		return factorial;
	}
}
