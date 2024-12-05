string again = "a";
    while(again == "a") {
        Console.WriteLine("***********************************************");
        Console.WriteLine("******* Generator pseudonahodnych cisel *******");
        Console.WriteLine("***********************************************");
        Console.WriteLine("**************** Maxim Maděra******************");
        Console.WriteLine("***********************************************\n\n");
        Console.WriteLine();

        Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
        int n;
        while(!int.TryParse(Console.ReadLine(), out n)) {
            Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
        }

        Console.Write("Zadejte dolní mez (celé číslo): ");
        int dm;
        while(!int.TryParse(Console.ReadLine(), out dm)) {
            Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
        }

        Console.Write("Zadejte horní mez (celé číslo): ");
        int hm;
        while(!int.TryParse(Console.ReadLine(), out hm)) {
            Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
        }

        Console.WriteLine("\n\n=============================================");
        Console.WriteLine("Uživatelský vstup");
        Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
        Console.WriteLine("=============================================\n\n");


        // deklarace pole

        int[] myArray = new int[n];

        // příprava pro generování náhodných čísel
        Random randomNumber = new Random();

        Console.WriteLine("Náhodná čísla: ");
        for(int i = 0; i < n; i++) {
            myArray[i] = randomNumber.Next(dm, hm+1);
            Console.Write("{0}; ", myArray[i]);
        }

        int max = myArray[0];
        int min = myArray[0];
        List<int> positionsMax = new List<int> {0};
        List<int> positionsMin = new List<int> {0};

        for(int i = 0; i<n; i++){
            if(myArray[i]>max){
                max = myArray[i];
                positionsMax.Clear();
                positionsMax.Add(i);
            }
            else if(myArray[i]==max){
                positionsMax.Add(i);
            }
        }
        for(int i = 0; i<n; i++){
            if(myArray[i]<min){
                min = myArray[i];
                positionsMin.Clear();
                positionsMin.Add(i);
            }
            else if (myArray[i]==min){
                positionsMin.Add(i);
            }
        }

    

        Console.WriteLine("\n\nHodnota maxima je: {0}\n", max);
        Console.WriteLine("Hodnota minima je: {0}\n\n", min);

        for(int i = 0; i < n-1; i++){
            for(int j = 0; j < n-i-1; j++){
                if(myArray[j] < myArray[j+1]){
                    int tmp = myArray[j];
                    myArray[j] = myArray[j+1];
                    myArray[j+1] = tmp;
                }
            }
        }

        Console.WriteLine("\nPozice všech maxim: ");
        foreach(var pos in positionsMax){
            Console.Write("{0}; ", pos);
        }
        Console.WriteLine("\n\nPozice všech minim: ");
        foreach(var pos in positionsMin){
            Console.Write("{0}; ", pos);
        }
        
        Console.WriteLine ("\n\nSeřazení prvků bubble sortem: ");
        for(int i = 0; i < n; i++){
            Console.Write("{0}; ", myArray[i]);
        }

        int pocetHodnot = 1;
        int predchoziHodnota = myArray[0];
        int max_2 = 0;
        int max_3 = 0;
        int max_4 = 0;

        for(int i = 1; i<n; i++){
            if(myArray[i]<predchoziHodnota){
                pocetHodnot++;
                predchoziHodnota = myArray[i];
                if(pocetHodnot == 2){
                    max_2 = myArray[i];
                    Console.WriteLine("\n\nDruhé největší číslo: {0}", max_2);
                }
                else if (pocetHodnot == 3){
                    max_3 = myArray[i];
                    Console.WriteLine("Třetí největší číslo: {0}", max_3);
                }
                else if(pocetHodnot == 4){
                    max_4 = myArray[i];
                    Console.WriteLine("Čtvrté největší číslo: {0}", max_4);
                }
            }
        }

        // Medián
        int median;

        if(n % 2 == 1){
            median = myArray[n/2];
        }
        else{
            median = (myArray[(n / 2) - 1] + myArray[n / 2]) / 2;
        }

        Console.WriteLine("Medián řady je: {0}", median);

        int cislo = max_4;

        int[] myArray_2 = new int[32];
        int zaloha = cislo;
        int zbytek;

        int i_2 = 0;

        while(cislo>0){
            zbytek = cislo % 2;
            cislo = (cislo - zbytek) / 2;
            myArray[i_2] = zbytek;
            i_2++;
        }

        Console.Write("\n\nVýsledek: ");

        for(int j = i_2 - 1; j >= 0; j--){
            Console.Write("{0}", myArray[j]);
        }

        Console.WriteLine();
        Console.WriteLine();

        int vyska = 8;
        int sirka = 6;


        for(int i = 0; i<vyska; i++){
            for(int j = 0; j<sirka-1; j++){
                Console.Write("* ");
            }
            Console.WriteLine("* ");
        }















        // Opakování programu
        Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();
        }