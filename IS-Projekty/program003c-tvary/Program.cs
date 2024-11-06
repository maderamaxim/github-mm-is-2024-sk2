string again = "a";
    while(again == "a") {
        Console.WriteLine("************************************");
        Console.WriteLine("******* Vykreslování obrazců *******");
        Console.WriteLine("************************************");
        Console.WriteLine("*********** Maxim Maděra ***********");
        Console.WriteLine("************************************\n\n");
        Console.WriteLine();



        Console.Write("Zadejte šířku obrazce (celé číslo): ");
        int height;
        while(!int.TryParse(Console.ReadLine(), out height)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu šířku obrazce (celé číslo): ");
        }

        int width = height;
        for (int i = 0; i < height; i++){
            if (i % 2 ==0)
                Console.WriteLine("#");
            if(i % 2 !=0)
                Console.WriteLine(" ");

            for (int j = 0; j < width; j++ ){
                if (j % 2 ==0)
                    Console.WriteLine(" ");
                if(j % 2 !=0)
                    Console.WriteLine("#");
                    }
                }
            


        Console.Write("Zadejte šířku obrazce (celé číslo): ");
        int height2;
        while(!int.TryParse(Console.ReadLine(), out height2)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu šířku obrazce (celé číslo): ");
            }
        int width2 = height2; 
        for (int i = 0; i < height2; i++) {
            if (i % 2 == 0) { 
                Console.WriteLine(new string('#', width2));
            } 
            else { 
                if (i % 4 == 1) { 
                    Console.WriteLine('#' + new string(' ', width2 - 1));
                } else { 
                    Console.WriteLine(new string(' ', width2 - 1) + '#');
                }
            }
        }






        Console.Write("Zadejte výšku obrazce (celé číslo): ");
        int height3;
        while(!int.TryParse(Console.ReadLine(), out height3)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce (celé číslo): ");
        }

        int width3 = height3;

        for (int i = 0; i < height3 / 2 + 1; i++)
        {
            for (int j = 0; j < i; j++) 
                Console.Write("  "); 

            for (int j = 0; j < width3 - 2 * i; j++) 
                Console.Write("* ");
                
            Console.WriteLine();
            }

        for (int i = height3 / 2 - 1; i >= 0; i--)
        {
            for (int j = 0; j < i; j++) 
                Console.Write("  ");

            for (int j = 0; j < width3 - 2 * i; j++) 
                Console.Write("* ");
                
            Console.WriteLine();
            }


        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();
        }