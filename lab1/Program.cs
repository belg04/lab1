// See https://aka.ms/new-console-template for more information

    Console.WriteLine("Ведите число p:");
    double p = double.Parse(Console.ReadLine());

    Console.WriteLine("Ведите число y:");
    double y = double.Parse(Console.ReadLine());

    Console.WriteLine("Ведите число e:");
    double e = double.Parse(Console.ReadLine());

    double K = Math.Log(Math.Pow(p, 2) + (Math.Pow(y, 3))) + Math.Pow(e, p);
    Console.WriteLine($"K={K:F2}");
