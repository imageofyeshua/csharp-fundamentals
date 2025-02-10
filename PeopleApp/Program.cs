﻿using Packt.Shared;

ConfigureConsole();

Person bob = new();

bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
  year: 1965, month: 12, day: 22,
  hour: 16, minute: 28, second: 0,
  offset: TimeSpan.FromHours(-5)
);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon
                | WondersOfTheAncientWorld.MausoleumAthalicarnassus
                | WondersOfTheAncientWorld.GreatPyramidOfGiza;
WriteLine(
  format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
  arg0: bob.Name,
  arg1: bob.FavoriteAncientWonder,
  arg2: (int)bob.FavoriteAncientWonder);
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

Person alice = new()
{
  Name = "Alice Jones",
  Born = new(1998, 3, 7, 16, 28, 0, TimeSpan.Zero)
};
WriteLine(format: "{0} was born on {1:d}.", arg0: alice.Name, arg1: alice.Born);