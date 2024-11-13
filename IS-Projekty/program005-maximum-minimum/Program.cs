string again = "a";
        while(again == "a") {
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

            
            int countMin = 1;
            int countMax = 1;
            int max = myArray[0];
            int min = myArray[0];
            int posMax = 0;
            int posMin = 0;
            List<int> positionsMax = new List<int> {0};
            List<int> positionsMin = new List<int> {0};
        

            for(int i = 1; i < n; i++){
                if(myArray[i] > max){
                    max = myArray[i];
                    positionsMax.Clear();
                    positionsMax.Add(i);
                    countMax = 1;
                    posMax = i;
                }
                else if (myArray[i] == max){
                    countMax++;
                    positionsMax.Add(i);
                }
                if(myArray[i] < min){
                    min = myArray[i];
                    positionsMin.Clear();
                    positionsMin.Add(i)
                    countMin = 1;
                    posMin = i;
                }
                else if (myArray[i] == min){
                    countMin++;
                    positionsMin.Add(i)
                }
                
            }

            Console.WriteLine("\n\nMaximum = {0}", max);
            Console.WriteLine("Minimum = {0}", min);
            Console.WriteLine("Pozice maxima je: {0}", posMax);
            Console.WriteLine("Pozice minima je: {0}", posMin);
            Console.WriteLine("Počet výskytů maxima je: {0}", countMax);
            Console.WriteLine("Počet výskytý minima je {0}", countMin);

            Console.Write("Pozice všech maxim: ");
            foreach (var pos in positionsMax) {
                Console.Write("{0}", pos);
            }
            Console.WriteLine()
            Console.Write("Pozice všech minim: ");
            foreach (var pos in positionsMin) {
                Console.Write("{0}, pos);
            }

            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
