using _4._29._2023.Models;
using Newtonsoft.Json;
using System.Threading.Channels;

namespace _4._29._2023
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Sheytanin Kitabi", "Qaraqan", 200, 12);
            Book book2 = new Book("Birinci Addim", "Qaraqan", 800, 142);
            Book book3 = new Book("Oluler", "Celil Memmedquluzade", 600, 8);
            Book book4 = new Book("Aklinda Bir Sayi Tut", "John Verdon", 512, 18);
            Book book5 = new Book("Kuleyin Kolgesi", "Karlos Ruis Safon", 456, 18);
            Book book6 = new Book("Heyvanistan", "Corc Oruell", 156, 5.56d);
            Book book7 = new Book("Mars xronikaları", "Rey Bredberi", 456, 5.69d);
            Book book8 = new Book("Hamlet", "Uilyam Şekspir", 208, 6.69d);
            Book book9 = new Book("Kürk Mantolu Madonna", "Sabahattin Ali", 456, 18);
            
            Library library = new Library();

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            int choice;
            do
                      
            {  Console.WriteLine("");
                Console.WriteLine("********** Kitabxanaya Xos Gelmisiniz ***********\n");
                Console.WriteLine("1. Kitabxanada Olan Butun Kitablar Ile Tanis Olmaq");
                Console.WriteLine("2. Kitab Adina Gore Axtaris Etmek");
                Console.WriteLine("3. Kitab Adi Ve Ya Muellif Adina Gore Axtaris Etmek");
                Console.WriteLine("4. Kitabxanaya Kitab Elave Etmek\n");
    

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("***** Kitabxanadaki Butun Kitablar *****\n");
                        library.ShowAllBook();
                        break;
                    case 2:
                        Console.WriteLine("***** Axtaris Etmek Istediyiniz Kitab Adini Daxil Edin *****\n");
                        library.GetBook(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("***** Axtaris Etmek Istediyiniz Kitab ve ya Muellifin Adini Daxil Edin *****\n");

                        library.FindAllBook(Console.ReadLine());
                        break;
                    case 4:

                        Console.WriteLine("Kitabin Adi:");

                        string name = Console.ReadLine();

                        Console.WriteLine("Yazicinin Adi: ");
                        string author = Console.ReadLine();

                        Console.WriteLine("Sehife Yasi:");
                        int pageCount = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kiabin Qiymeti:");
                        double price = double.Parse(Console.ReadLine());

                        Book newBook = new Book(name, author, pageCount, price);
                        library.AddBook(newBook);

                        Console.WriteLine("\nKitab Elave Edildi: ");

                        break;
                }

            } while (choice != 5);



            SerializeLibrary(library);

            Library deserializedLibrary = DeserializeLibrary();
            deserializedLibrary.ShowAllBook();
        }

        public static void SerializeLibrary(Library library)
        {
            string json = JsonConvert.SerializeObject(library);
            using (StreamWriter sr = new StreamWriter(@"C:\Users\Alber\Desktop\4.29.2023\4.29.2023\Models\LibraryData.json"))
            {
                sr.Write(json);
            }
        }


        public static Library DeserializeLibrary()
        {
            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\Alber\Desktop\4.29.2023\4.29.2023\Models\LibraryData.json"))
            {
                result = sr.ReadToEnd();
            }
            Library library = JsonConvert.DeserializeObject<Library>(result);

            return library;

        }

    }

}