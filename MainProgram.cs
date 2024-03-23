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
        bool isCom = mail.EndsWith(koncovka1);
        bool isSk = mail.EndsWith(koncovka2);
        bool isCz = mail.EndsWith(koncovka3);
        if (isCom)
        {
            Console.WriteLine("Mezinarodni Email");
        }
        else if (isSk)
        {
            Console.WriteLine("Slovensky Email");
        }
        else if (isCz)
        {
            Console.WriteLine("Cesky Email");
        }
        else
        {
            Console.WriteLine("Neplatny vstup");      
        }
        Console.ReadKey();

        }
    
    
    
    
    }  



}