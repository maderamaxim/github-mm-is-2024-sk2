﻿string again = "a";
    while(again == "a") {
        //Console.Clear();
        Console.WriteLine("*****************************************");
        Console.WriteLine("******* Prevod z 10 do 2 soustavy *******");
        Console.WriteLine("*****************************************");
        Console.WriteLine("************* Maxim Maděra***************");
        Console.WriteLine("*****************************************\n\n");
        Console.WriteLine();


        // Vstup od uživatele - lepší varianta
        Console.Write("Zadejte číslo v desítkové soustavě (přirozené číslo): ");
        uint cislo;
        while(!uint.TryParse(Console.ReadLine(), out cislo)) {
            Console.Write("Špatný vstup. Zadejte znovu číslo v desítkové soustavě (přirozené číslo): ");
        }

        uint[] myArray = new uint[32];

        uint zaloha = cislo;
        uint zbytek;

        uint i = 0;

        while(cislo > 0) {
            zbytek = cislo % 2;
            cislo = (cislo - zbytek)/2;
            myArray[i] = zbytek;



            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Celá část {0}; zbytek {1}", cislo, zbytek);
            Console.ForegroundColor = ConsoleColor.White;
            
            i++;
        }
        
        Console.WriteLine("Poslední využitý index pole: {0}", i-1);
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("\n\nVysledek: ");

        for(uint j = i-1; j>= 0; j--){
            Console.Write("{0}\n\n", myArray[j]);
        }



        // Opakování programu
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();
    }