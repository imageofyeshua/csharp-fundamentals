string name = typeof(Program).Namespace ?? "<null>";
System.Console.WriteLine($"Namespace: {name}");
throw new Exception();
