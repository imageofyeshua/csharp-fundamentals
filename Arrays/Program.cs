// for statement from array
string[] men;
men = new string[4];
men[0] = "Daniel";
men[1] = "Steve";
men[2] = "Jason";
men[3] = "John";
string[] women = { "Kate", "Rachel", "Leah", "Sarah" };

for (int i = 0; i < men.Length; i++)
{
  WriteLine($"{men[i]} is at position {i}");
}

for (int i = 0; i < women.Length; i++)
{
  WriteLine($"{women[i]} is at position {i}");
}

// two-dimensional array
string[,] grid1 =
{
  { "Alpha", "Beta", "Gamma", "Delta" },
  { "Anne", "Ben", "Charlie", "Doug" },
  { "Aardvark", "Bear", "Cat", "Dog" },
};

WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
WriteLine($"2st dimension, lower bound: {grid1.GetLowerBound(1)}");
WriteLine($"2st dimension, upper bound: {grid1.GetUpperBound(1)}");

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
  for (int col = 0; col <= grid1.GetUpperBound(1); col++)
  {
    WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
  }
}

string[,] grid2 = new string[3, 4];
grid2[0, 0] = "Alpha";
grid2[0, 1] = "Beta";
// and so on.

string[][] jagged =
{
  new[] { "Alpha", "Beta", "Gamma" },
  new[] { "Anne", "Ben", "Charlie", "Doug" },
  new[] { "Alphaues", "Bart" }
};

WriteLine("Upper bound of the array of arrays is: {0}", jagged.GetUpperBound(0));
for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
  WriteLine("Upper bound of array {0} is : {1}",
    arg0: array,
    arg1: jagged[array].GetUpperBound(0)
  );
}

for (int row = 0; row <= jagged.GetUpperBound(0); row++)
{
  for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
  {
    WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
  }
}