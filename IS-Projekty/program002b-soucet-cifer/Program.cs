 string again = "a";
    while(again == "a") {
    
    Console.WriteLine("*************************************");
    Console.WriteLine("******* Soucet a soucin cifer *******");
    Console.WriteLine("*************************************");
    Console.WriteLine("************ Maxim Maděra************");
    Console.WriteLine("*************************************\n\n");
    Console.WriteLine();


    Console.Write("Zadejte celé číslo: ");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number)) {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu číslo: ");
    }


    // Výpis vstupní hodnoty
    Console.WriteLine("=======================================");
    Console.WriteLine("Uživatel zadal: {0}", number);
    Console.WriteLine("=======================================\n\n");

    int suma = 0;
    int multi = 1;
    int numberBackup = number;

    string input = number.ToString();

    foreach(char c in input){
        int digit = c - '0';  
        suma = suma + digit;
        multi = multi * digit;
}
Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma);
Console.WriteLine("\n\nSoučin cifer čísla {0} je {1}\n\n", numberBackup, multi);

Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}