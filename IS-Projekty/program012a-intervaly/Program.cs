string again = "a";
while (again == "a")
{
    //Console.Clear();
    Console.WriteLine("***********************************************");
    Console.WriteLine("*********** Generator na intervaly ************");
    Console.WriteLine("***********************************************");
    Console.WriteLine("**************** Maxim Maděra *****************");
    Console.WriteLine("***********************************************\n\n");

    // Vstup od uživatele
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int dm;
    while (!int.TryParse(Console.ReadLine(), out dm))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu (celé číslo): ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int hm;
    while (!int.TryParse(Console.ReadLine(), out hm))
    {
        Console.Write("Nezadali jste správně horní mez. Zadejte horní mez znovu (celé číslo): ");
    }

    Console.Write("Zadejte počet intervalů (celé číslo, větší než 0): ");
    int numIntervals;
    while (!int.TryParse(Console.ReadLine(), out numIntervals) || numIntervals <= 0)
    {
        Console.Write("Nezadali jste správně počet intervalů. Zadejte počet intervalů znovu (celé číslo, větší než 0): ");
    }

    Console.WriteLine("\n=============================================");
    Console.WriteLine("Uživatelský vstup");
    Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}; počet intervalů: {3}", n, dm, hm, numIntervals);
    Console.WriteLine("=============================================\n");

    // Deklarace pole
    int[] myArray = new int[n];

    // Příprava pro generování náhodných čísel
    Random randomNumber = new Random();
    int[] intervalCounts = new int[numIntervals];
    double intervalSize = (double)(hm - dm) / numIntervals;

    Console.WriteLine("Náhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        myArray[i] = randomNumber.Next(dm, hm + 1);
        Console.Write($"{myArray[i]}; ");

        // Zjistit, do kterého intervalu číslo patří
        int intervalIndex = (int)((myArray[i] - dm) / intervalSize);
        if (intervalIndex == numIntervals) intervalIndex--; // Ošetření okrajového případu
        intervalCounts[intervalIndex]++;
    }

    Console.WriteLine("\n\nVýsledky intervalů:");
    for (int i = 0; i < numIntervals; i++)
    {
        int intervalStart = (int)Math.Round(dm + i * intervalSize);
        int intervalEnd = (int)Math.Round(dm + (i + 1) * intervalSize) - 1;
        if (i == numIntervals - 1) intervalEnd = hm; // Poslední interval zahrnuje horní mez
        Console.WriteLine($"Interval {i + 1}: <{intervalStart}; {intervalEnd}> obsahuje {intervalCounts[i]} čísel.");
    }

    // Opakování programu
    Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}