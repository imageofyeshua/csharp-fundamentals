﻿// TimesTable(number: 4, size: 20);
ConfigureConsole(culture: "fr-FR");
decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
WriteLine($"You must pay {taxToPay:C} in tax.");

RunCardinalToOrdinal();
RunFactorial();
RunFibImperative();