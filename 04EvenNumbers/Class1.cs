namespace _04EvenNumbers;

/// <summary>
/// Provides methods to work with even numbers.
/// </summary>
public class EvenNumberFinder
{
	/// <summary>
	/// Gets all even numbers from 1 to n.
	/// </summary>
	/// <param name="n">The upper limit.</param>
	/// <returns>An array of even numbers from 1 to n.</returns>
	public static int[] GetEvenNumbers(int n)
	{
		List<int> evenNumbers = [];
		for (int i = 1; i <= n; i++)
		{
			if (i % 2 == 0)
			{
				evenNumbers.Add(i);
			}
		}

		return [.. evenNumbers];
	}
}
