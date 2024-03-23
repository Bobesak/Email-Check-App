using System.ComponentModel.DataAnnotations;

namespace email
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter your email address: ");
        string mail = Console.ReadLine();
        mail.Trim();
        string koncovka1 = ".com";
        string koncovka2 = ".sk";
        string koncovka3 = ".cz";
        int delka = mail.Length;
        bool ContainsAt = mail.Contains("@");
        bool isCom = mail.EndsWith(koncovka1);
        bool isSk = mail.EndsWith(koncovka2);
        bool isCz = mail.EndsWith(koncovka3);
        if (ContainsAt)
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
        else
        {
            Console.WriteLine("Neplatny vstup");      
        }
        
        Thread.Sleep(5000);


        Console.ReadKey();

        }
    
    
    
    
    }  



}