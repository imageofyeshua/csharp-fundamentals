using DelegatesAndEvents;

Player player = new();
var party = new Party();

player.AchievmentUnlocked += OnAchievementUnlocked;
player.AchievmentUnlocked += party.Cheering;

await player.AddPoints(30);
await player.AddPoints(45);
await player.AddPoints(35);

player.AchievmentUnlocked -= OnAchievementUnlocked;
player.AchievmentUnlocked -= party.Cheering;

static void OnAchievementUnlocked(int points)
{
  Console.WriteLine($"Congratulations from \"Program.cs\"! Achievement unlocked for earning {points} points!");
}