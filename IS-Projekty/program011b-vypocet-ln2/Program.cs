﻿string again = "a";
    while(again == "a") {
        //Console.Clear();
        Console.WriteLine("*******************************");
        Console.WriteLine("********* Výpočet ln2 *********");
        Console.WriteLine("*******************************");
        Console.WriteLine("******** Maxim Maděra**********");
        Console.WriteLine("*******************************\n\n");
        Console.WriteLine();


        // Vstup od uživatele - lepší varianta
        Console.Write("Zadejte přesnost (reálné číslo - čím menší, tím přesnější): ");
        double presnost;
        while(!double.TryParse(Console.ReadLine(), out presnost)) {
            Console.Write("Nezadali jste přesnost správně. Zadejte znovu: ");
        }

        double i = 1;
        double znamenko = 1;
        double log = 1;

        while(1 / i >= presnost){
            i = i + 1;
            znamenko = - znamenko;
            log = log + znamenko * 1 / i;
            if(znamenko ==1){
                Console.WriteLine("Zlomek: +1/{0}; aktuální hodnota ln2 = {1}", i, log);
            }
            else{
                Console.WriteLine("Zlomek: -1/{0}; aktuální hodnota ln2 = {1}", i, log);
            }


        }
        
        Console.WriteLine(" Hodnota přirozeného logaritmu ln2 je: {0}", log);


        // Opakování programu
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();
    }