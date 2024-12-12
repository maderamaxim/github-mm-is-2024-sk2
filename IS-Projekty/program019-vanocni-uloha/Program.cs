using System.Data;

string again = "a";
    while(again == "a") {
//             //Console.Clear();
//             Console.WriteLine("***********************************************");
//             Console.WriteLine("******* Generator pseudonahodnych cisel *******");
//             Console.WriteLine("***********************************************");
//             Console.WriteLine("**************** Maxim Maděra******************");
//             Console.WriteLine("***********************************************\n\n");
//             Console.WriteLine();


//             // Vstup od uživatele - lepší varianta
//             Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
//             int n;
//             while(!int.TryParse(Console.ReadLine(), out n)) {
//                 Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
//             }

//              Console.Write("Zadejte dolní mez (celé číslo): ");
//             int dm;
//             while(!int.TryParse(Console.ReadLine(), out dm)) {
//                 Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
//             }

//              Console.Write("Zadejte horní mez (celé číslo): ");
//             int hm;
//             while(!int.TryParse(Console.ReadLine(), out hm)) {
//                 Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
//             }

//             Console.WriteLine("\n\n=============================================");
//             Console.WriteLine("Uživatelský vstup");
//             Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
//             Console.WriteLine("=============================================\n\n");


//             // deklarace pole

//             int[] myArray = new int[n];

//             // příprava pro generování náhodných čísel
//             Random randomNumber = new Random();

//             Console.WriteLine("Náhodná čísla: ");
//             for(int i = 0; i < n; i++) {
//                 myArray[i] = randomNumber.Next(dm, hm+1);
//                 Console.Write("{0}; ", myArray[i]);
//             }

//             // BUBBLE SORT  
//             for(int i = 0; i < n-1; i++){
//                 for(int j = 0; j < n - i - 1; j++){
//                     if(myArray[j]< myArray[j+1]){
//                         int tmp = myArray[j];
//                         myArray[j] = myArray[j+1];
//                         myArray[j+1] = tmp;
//                     }
//                 }
//             }
//             Console.Write("\n\nŘada po seřazení bubble sortem: ");

//             for(int i = 0; i < n; i++){
//                 Console.Write("{0}; ", myArray[i]);
//             }

//             int max = myArray[0];
//             int min = myArray[0];

//             for(int i = 0; i < n; i++){
//                 if(max < myArray[i]){
//                     max = myArray[i];
//                 }
//                 else if(min > myArray[i]){
//                     min = myArray[i];
//                 }
//             }
//             Console.WriteLine("\n\nHodnota maxima je: {0}", max);
//             Console.WriteLine("Hodnota minima je: {0}", min);


//             int sum = 0;
//             for(int i = 0; i < n; i++){
//                 sum += myArray[i];
//             }
//             Console.WriteLine("Hodnota sumy je: {0}", sum);

//             int prumer = sum / n;
//             int zbytek = sum % n;

//             Console.WriteLine("\nPrumer cisel je: {0} a zbytek po deleni je {1}", prumer, zbytek);


            int hodnota = 5;
            for(int i = 1; i < hodnota; i++){}












            
            // Opakování programu
            Console.WriteLine("\n\n Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }