string again = "a";
    while(again == "a") {

        Console.WriteLine("**************************************************");
        Console.WriteLine("******* Generator aritmeticke posloupnosti *******");
        Console.WriteLine("**************************************************");
        Console.WriteLine("****************** Maxim Maděra*******************");
        Console.WriteLine("**************************************************\n\n");



        Console.Write("Zadejte počet čísel: ");
        int pocetCisel = int.Parse(Console.ReadLine());

        Console.Write("Zadejte diferenci: ");
        int diference = int.Parse(Console.ReadLine());

        Console.Write("Zadejte první prvek posloupnosti: ");
        int prvniPrvek = int.Parse(Console.ReadLine());

        int suma = 0;
        Console.WriteLine("Aritmetická posloupnost: ");
        for (int i = 0; i < pocetCisel; i++){
            int prvek = prvniPrvek + i * diference;
            Console.Write(prvek);
            if(i<pocetCisel -1)
                Console.Write("; ");

            suma += prvek;
        }

        Console.WriteLine("\n\nSoučet zobrazených hodnot: {0}", suma);


    // Opakování programu
    Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
    }