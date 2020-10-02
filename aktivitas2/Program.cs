using System;

namespace aktivitas2
 //aktivitas2 - namespace di modul : Pustakamedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Book tutorialPhp = new Book("tutorphp", "toni");
            string title = tutorialPhp.getTitle();
            string author = tutorialPhp.getAuthor();
            Console.WriteLine(title);
            Console.WriteLine(author);

            Member memberToni = new Member("Toni", "toni@mail.com");
            string name = memberToni.getName();
            string mail = memberToni.getEmail();
            Console.WriteLine(name);
            Console.WriteLine(mail);
            Console.ReadKey();
        }
    }
}
