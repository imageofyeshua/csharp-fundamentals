namespace DelegatesAndEvents;

internal class Player
{
	public int Points { get; private set; }

	public delegate void AchievementUnlockedHandler(int points);

	public event AchievementUnlockedHandler? AchievmentUnlocked;

	public async Task AddPoints(int points)
	{
		Points += points;
		Console.WriteLine($"Player earned {points} points. Total points:{Points}");
		await Task.Delay(1000);

		if (Points >= 100)
		{
			AchievmentUnlocked?.Invoke(Points);
		}
	}
}