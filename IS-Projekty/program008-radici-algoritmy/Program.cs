string again = "a";
    while(again == "a") {
        //Console.Clear();
        Console.WriteLine("***********************************************");
        Console.WriteLine("******* Generator pseudonahodnych cisel *******");
        Console.WriteLine("***********************************************");
        Console.WriteLine("**************** Maxim Maděra******************");
        Console.WriteLine("***********************************************\n\n");
        Console.WriteLine();


        // Vstup od uživatele - lepší varianta
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

        Console.WriteLine();
        Console.WriteLine();
// ======================== ZAČÁTEK ŘADÍCÍCH METOD =============================

// INSERTION SORT

        for (int i = 0; i < n - 1; i++){
        int j = i + 1;
        int tmp1 = myArray[j];
        while (j > 0 && tmp1 > myArray[j - 1]){
            myArray[j] = myArray[j - 1];
            j--;
            }
        myArray[j] = tmp1;
        }

        Console.WriteLine("\n\nSeřazené pole insertion sortem: ");
            for(int i = 0; i < n; i++) {
             Console.Write("{0}; ", myArray[i]);
                }
            
// ======================= PŘEDĚL ŘADÍCÍ METODY =============================

// SELECTION SORT

        for (int i = 0; i < n - 1; i++){

            int maxHodnota = i;
            for (int j = i + 1; j < n; j++){
                if (myArray[j] > myArray[maxHodnota])
                {
                    maxHodnota = j;
                    }
                }

            int tmp = myArray[i];
            myArray[i] = myArray[maxHodnota];
            myArray[maxHodnota] = tmp;
            }

            Console.WriteLine("\n\nSeřazené pole selection sortem: ");
            for(int i = 0; i < n; i++) {
                Console.Write("{0}; ", myArray[i]);
                }



// =========================== SHAKER SORT ===================================


        for (int i = 0; i < n / 2; i++){
            bool swapped= false;
            for(int j = i; j < n - i - 1; j++){
                if (myArray[j] < myArray[j + 1]){
                    int tmp = myArray[j];
                    myArray[j] = myArray[j + 1];
                    myArray[j + 1] = tmp;
                    swapped = true;
                    }
                }
            for (int j = n - 2 - i; j > i; j--){
                if (myArray[j] > myArray[j - 1]){
                    int tmp = myArray[j];
                    myArray[j] = myArray[j - 1];
                    myArray[j - 1] = tmp;
                    swapped = true;
                    }
                }
            if (!swapped) break;
            }

        Console.WriteLine("\n\nSeřazené pole shaker sortem: ");
            for(int i = 0; i < n; i++) {
                Console.Write("{0}; ", myArray[i]);
                }

// ============================== SHELL SORT =====================================

        int gap = n / 2;
        while (gap > 0){
            for (int i = 0; i < n - gap; i++){
                int j = i + gap;
                int tmp = myArray[j];
                while (j >= gap && tmp > myArray[j - gap]){
                    myArray[j] = myArray[j - gap];
                    j -= gap;
                }
                myArray[j] = tmp;
            }
            if (gap == 2){
                gap = 1;
            }
            else{
                gap = (int)(gap/2.2);
            }
        }
        
        Console.WriteLine("\n\nSeřazené pole shaker sortem: ");
            for(int i = 0; i < n; i++) {
                Console.Write("{0}; ", myArray[i]);
                }

// ==================================== COMB SORT =======================================


        int gap2 = n;
        bool swapped;

        do{
            gap = Math.Max(1, (gap2 * 10) / 13);
            swapped = false;

            for (int i = 0; i + gap2 < n; i++)
            {
                if (myArray[i] > myArray[i + gap2])
                {
                  
                    (myArray[i], myArray[i + gap2]) = (myArray[i + gap2], myArray[i]);
                    swapped = true;
                }
            }
        } while (gap2 > 1 || swapped);
    

        Console.WriteLine("\n\nSeřazené pole shaker sortem: ");
            for(int i = 0; i < n; i++) {
                Console.Write("{0}; ", myArray[i]);
                }


    // Opakování programu
    Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
    }
