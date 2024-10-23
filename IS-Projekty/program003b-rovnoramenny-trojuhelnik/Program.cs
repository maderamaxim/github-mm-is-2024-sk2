string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("******* Název programu *******");
            Console.WriteLine("******************************");
            Console.WriteLine("****** Maxim Maděra***********");
            Console.WriteLine("**************************\n\n");
            Console.WriteLine();

            Console.Write("Zadejte délku přepony (celé číslo): ");
            int rameno;
            while(!int.TryParse(Console.ReadLine(), out rameno)){
                Console.Write("Nezadali jste celé číslo, zadejte znovu délku přepony: ");
            }
            for(int x = 1; x <= rameno; x++){
                for( int y = 1; y <= x; y++){
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }  