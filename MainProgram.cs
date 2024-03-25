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
        string[] koncovky = {".sk", ".com", ".cz"}; //Promenne
        int delka = mail.Length;
        bool ContainsAt = mail.Contains("@"); //kontrola zda obsahuje zavinac
        bool isCom = mail.EndsWith(koncovky[1]); //Zjisti na kterou koncovku email konci
        bool isSk = mail.EndsWith(koncovky[0]);
        bool isCz = mail.EndsWith(koncovky[2]);
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