string again = "a";
    while(again == "a") {
        //Console.Clear();
        Console.WriteLine("******************************");
        Console.WriteLine("********* Výpočet PI *********");
        Console.WriteLine("******************************");
        Console.WriteLine("******** Maxim Maděra*********");
        Console.WriteLine("******************************\n\n");
        Console.WriteLine();


        // Vstup od uživatele - lepší varianta
        Console.Write("Zadejte přesnost (reálné číslo - čím menší, tím přesnější): ");
        double presnost;
        while(!double.TryParse(Console.ReadLine(), out presnost)) {
            Console.Write("Nezadali jste přesnost správně. Zadejte znovu: ");
        }

        double i = 1;
        double piCtvrt = 1;
        double znamenko = 1;

        while(1 / i >= presnost){
            i = i + 2;
            znamenko = - znamenko;
            piCtvrt = piCtvrt + znamenko * 1 / i;
            if(znamenko ==1){
                Console.WriteLine("Zlomek: +1/{0}; aktuální hodnota PI = {1}", i, piCtvrt*4);
            }
            else{
                Console.WriteLine("Zlomek: -1/{0}; aktuální hodnota PI = {1}", i, piCtvrt*4);
            }


        }
        double pi = 4 * piCtvrt;

        Console.WriteLine(" Hodnota PI: {0}", pi);


        // Opakování programu
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();
    }