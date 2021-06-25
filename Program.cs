using System;

namespace Boo
{
    class Program
    {
        static void Main(string[] args)
        {
            string bn,au,id,ty;
            int cp;
            Console.WriteLine("\n================ Book Management=================\n");

            Console.WriteLine("Enter Book Name: ");
            bn = Console.ReadLine();

            Console.WriteLine("Enter Book Author: ");
            au = Console.ReadLine();

            Console.WriteLine("Enter Book ID: ");
            id = Console.ReadLine();

            Console.WriteLine("Enter Book Type: ");
            ty = Console.ReadLine();

            Console.WriteLine("Enter How Many Book: ");
            cp = Convert.ToInt16(Console.ReadLine());
            

            //object call
            Book myBook = new Book(bn,au,id,ty,cp);

            myBook.ShowInfo();

            //add book copy
            int N;
            Console.WriteLine("Enter how many book copies you want to add: ");
            N = Convert.ToUInt16(Console.ReadLine());

            myBook.AddBookCopy(N);

            Book.showTotalBookInfo();

        }
    }
}
