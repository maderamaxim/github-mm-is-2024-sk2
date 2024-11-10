// chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("******* Analyza textu ********");
            Console.WriteLine("******************************");
            Console.WriteLine("****** Maxim Maděra***********");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();


            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte text pro analýzu: ");
            string myText = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(myText);
            Console.WriteLine(myText[0]);
            Console.WriteLine(myText.Length);
            Console.WriteLine(myText[myText.Length-1]);
            
            string samohlasky = "aáeéěiíyýoóuůúAÁEÉĚIÍYÝOÓUŮÚ";
            string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzžBCČDĎFGHJKLMNŇPQRŘSŠTŤVWXZŽ";
            string cislice = "0123456789";

            int pocetSamohlsek=0;
            int pocetSouhlasek=0;
            int pocetCislic=0;
            int pocetOstatnich=0;

            foreach(char znak in myText){
                if(souhlasky.Contains(znak)){
                    pocetSouhlasek++;
                }
                else if(samohlasky.Contains(znak)){
                    pocetSamohlsek++;
                }
                else if(cislice.Contains(znak)){
                    pocetCislic++;
                }
                else {
                    pocetOstatnich++;
                }
            }
            
            Console.WriteLine("Počet souhlásek: {0}", pocetSouhlasek);
            Console.WriteLine("Počet samohlásek: {0}", pocetSamohlsek);
            Console.WriteLine("Počet číslic: {0}", pocetCislic);
            Console.WriteLine("Počet ostatních znaků: {0}", pocetOstatnich);




            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
      
