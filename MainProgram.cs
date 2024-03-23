using System.ComponentModel.DataAnnotations;

namespace email
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter your email address: "); //Vstup emailu
        string mail = Console.ReadLine();
        mail.Trim(); // Odstraneni mezery
        string koncovka1 = ".com"; //declarovani koncovky emailu
        string koncovka2 = ".sk";
        string koncovka3 = ".cz";
        int delka = mail.Length;
        bool ContainsAt = mail.Contains("@"); //kontrola zda obsahuje zavinac
        bool isCom = mail.EndsWith(koncovka1); //Zjisti na kterou koncovku email konci
        bool isSk = mail.EndsWith(koncovka2);
        bool isCz = mail.EndsWith(koncovka3);
        if (ContainsAt) //Pokud obsahuje zavinac, kod bude pokracovat
        {
            if (isCom)
        {
            Console.WriteLine("International Email");
            Console.WriteLine(delka + " Symbols Long");
        }
        else if (isSk)
        {
            Console.WriteLine("Slovensky Email");
            Console.WriteLine("Dĺžka " + delka + " symbolov");
        }
        else if (isCz)
        {
            Console.WriteLine("Cesky Email");
            Console.WriteLine(delka + " Symbolu");
        }
        }       
        else //Pokud neobsahuje zavinac, kod skonci
        {
            Console.WriteLine("Neplatny vstup");      
        }
        
        Thread.Sleep(5000); //Zpozdeni aby clovek stihl precist vysledek


        Console.ReadKey();

        }
    
    
    
    
    }  



}