string again = "a";
while(again == "a") {
    Console.Clear();
    razitko();

    ulong a = ziskatCislo("Zadejte přirozené číslo a: ");
    ulong b = ziskatCislo("Zadejte přirozené číslo b: ");

    ulong nsd = vypocitatNSD(a, b);

    ulong nsn = vypocitatNSN(a, b, nsd);


    zobrazitVysledky(a, b, nsd, nsn);


    // Opakování programu
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}

static void razitko(){
    Console.WriteLine("******************************");
    Console.WriteLine("********** NSD a NSN *********");
    Console.WriteLine("******************************");
    Console.WriteLine("********* Maxim Maděra********");
    Console.WriteLine("******************************\n\n");
    Console.WriteLine();
}

static ulong ziskatCislo(string zprava){
    Console.Write(zprava);
    ulong cislo;
    while(!ulong.TryParse(Console.ReadLine(), out cislo)) {
        Console.Write("Nezadali jste přirozené číslo. Zadejte znovu přirozené číslo: ");
    }

    return cislo;
}

static ulong vypocitatNSD(ulong a, ulong b){
    while(a!=b){
        if(a>b)
            a = a-b;
        else
            b = b-a;
    }
    return a;
}

static ulong vypocitatNSN(ulong a, ulong b, ulong nsd){
    return (a*b)/nsd;
}

static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn){
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\n\nNSD čísel {0} a {1} je {2}", a, b, nsd);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("NSN čísel {0} a {1} je {2}", a, b, nsn);
    Console.ForegroundColor = ConsoleColor.White;
}