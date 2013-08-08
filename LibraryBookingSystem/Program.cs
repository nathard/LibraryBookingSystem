using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    class Program
    {
        private static Catalogue LibraryCatalogue = new Catalogue();

        #region Database Initialisation
        private static void LoadData()
        {
            LibraryCatalogue.AddPatron(new Student("210000001", "Boykin", "Christopher"));
            LibraryCatalogue.AddPatron(new Student("210000002", "Loggins", "Leonard"));
            LibraryCatalogue.AddPatron(new Student("210000003", "Parmenter", "Tony"));
            LibraryCatalogue.AddPatron(new Student("210000004", "Abrams", "Jeremy"));
            LibraryCatalogue.AddPatron(new Student("210000005", "Hein", "Mark"));
            LibraryCatalogue.AddPatron(new Student("210000006", "Just", "James"));
            LibraryCatalogue.AddPatron(new Student("210000007", "Wegner", "Jacob"));
            LibraryCatalogue.AddPatron(new Student("210000008", "McKean", "Samuel"));
            LibraryCatalogue.AddPatron(new Student("210000009", "Quiroz", "Victor"));
            LibraryCatalogue.AddPatron(new Student("210000010", "Bradshaw", "Mike"));
            LibraryCatalogue.AddPatron(new Student("210000011", "Hillard", "Roy"));
            LibraryCatalogue.AddPatron(new Student("210000012", "Gorman", "Vincent"));
            LibraryCatalogue.AddPatron(new Student("210000013", "Percy", "Curtis"));
            LibraryCatalogue.AddPatron(new Student("210000014", "Sturm", "Patrick"));
            LibraryCatalogue.AddPatron(new Student("210000015", "Eng", "Ralph"));
            LibraryCatalogue.AddPatron(new Student("210000016", "Her", "Glenn"));
            LibraryCatalogue.AddPatron(new Student("210000017", "Molnar", "Arthur"));
            LibraryCatalogue.AddPatron(new Student("210000018", "Blakey", "Eugene"));
            LibraryCatalogue.AddPatron(new Student("210000019", "Thies", "Charles"));
            LibraryCatalogue.AddPatron(new Student("210000020", "Dandridge", "Alan"));
            LibraryCatalogue.AddPatron(new Student("210000021", "Salem", "Antonio"));
            LibraryCatalogue.AddPatron(new Student("210000022", "Gwin", "Glenn"));
            LibraryCatalogue.AddPatron(new Student("210000023", "Vaughn", "Christopher"));
            LibraryCatalogue.AddPatron(new Student("210000024", "Reddy", "Donald"));
            LibraryCatalogue.AddPatron(new Student("210000025", "Roberge", "George"));
            LibraryCatalogue.AddPatron(new Student("210000026", "Spearman", "Nathan"));
            LibraryCatalogue.AddPatron(new Student("210000027", "Beane", "Scott"));
            LibraryCatalogue.AddPatron(new Student("210000028", "Constantine", "Eugene"));
            LibraryCatalogue.AddPatron(new Student("210000029", "Campbell", "Bobby"));
            LibraryCatalogue.AddPatron(new Student("210000030", "Santiago", "Jack"));
            LibraryCatalogue.AddPatron(new Student("210000031", "Ho", "Jason"));
            LibraryCatalogue.AddPatron(new Student("210000032", "McKnight", "Roy"));
            LibraryCatalogue.AddPatron(new Student("210000033", "Valencia", "Howard"));
            LibraryCatalogue.AddPatron(new Student("210000034", "Perrine", "Luis"));
            LibraryCatalogue.AddPatron(new Student("210000035", "Pyles", "Jesse"));
            LibraryCatalogue.AddPatron(new Student("210000036", "Spurlock", "Patrick"));
            LibraryCatalogue.AddPatron(new Student("210000037", "Driggers", "Phillip"));
            LibraryCatalogue.AddPatron(new Student("210000038", "McCulley", "Matthew"));
            LibraryCatalogue.AddPatron(new Student("210000039", "Crow", "Gregory"));
            LibraryCatalogue.AddPatron(new Student("210000040", "Seals", "William"));
            LibraryCatalogue.AddPatron(new Student("210000041", "Simoneaux", "Marilyn"));
            LibraryCatalogue.AddPatron(new Student("210000042", "Lacey", "Theresa"));
            LibraryCatalogue.AddPatron(new Student("210000043", "Pfeffer", "Carrie"));
            LibraryCatalogue.AddPatron(new Student("210000044", "Coles", "Lisa"));
            LibraryCatalogue.AddPatron(new Student("210000045", "Purnell", "Ana"));
            LibraryCatalogue.AddPatron(new Student("210000046", "Mitchel", "Olga"));
            LibraryCatalogue.AddPatron(new Student("210000047", "Dinsmore", "Vivian"));
            LibraryCatalogue.AddPatron(new Student("210000048", "Joiner", "Lillie"));
            LibraryCatalogue.AddPatron(new Student("210000049", "Feeley", "Julia"));
            LibraryCatalogue.AddPatron(new Student("210000050", "Gallegos", "Josephine"));
            LibraryCatalogue.AddPatron(new Student("210000051", "Land", "Juanita"));
            LibraryCatalogue.AddPatron(new Student("210000052", "Thrift", "Penny"));
            LibraryCatalogue.AddPatron(new Student("210000053", "Cater", "Jennifer"));
            LibraryCatalogue.AddPatron(new Student("210000054", "Grimm", "Donna"));
            LibraryCatalogue.AddPatron(new Student("210000055", "Comstock", "Pamela"));
            LibraryCatalogue.AddPatron(new Student("210000056", "Polanco", "Melinda"));
            LibraryCatalogue.AddPatron(new Student("210000057", "Elias", "Rosalie"));
            LibraryCatalogue.AddPatron(new Student("210000058", "Patrick", "Kathryn"));
            LibraryCatalogue.AddPatron(new Student("210000059", "Arteaga", "Amelia"));
            LibraryCatalogue.AddPatron(new Student("210000060", "Carmona", "Brandi"));
            LibraryCatalogue.AddPatron(new Student("210000061", "Specht", "Kristina"));
            LibraryCatalogue.AddPatron(new Student("210000062", "Seals", "Angelica"));
            LibraryCatalogue.AddPatron(new Student("210000063", "Santo", "Kara"));
            LibraryCatalogue.AddPatron(new Student("210000064", "Caton", "Bridget"));
            LibraryCatalogue.AddPatron(new Student("210000065", "Fontaine", "Yvette"));
            LibraryCatalogue.AddPatron(new Student("210000066", "Chadwell", "Claire"));
            LibraryCatalogue.AddPatron(new Student("210000067", "Koch", "Charlotte"));
            LibraryCatalogue.AddPatron(new Student("210000068", "Rigney", "Stella"));
            LibraryCatalogue.AddPatron(new Student("210000069", "Palmer", "Latoya"));
            LibraryCatalogue.AddPatron(new Student("210000070", "Bader", "Mamie"));
            LibraryCatalogue.AddPatron(new Student("210000071", "Geis", "Amber"));
            LibraryCatalogue.AddPatron(new Student("210000072", "Noll", "Debra"));
            LibraryCatalogue.AddPatron(new Student("210000073", "Stacey", "Jacqueline"));
            LibraryCatalogue.AddPatron(new Student("210000074", "Rizzo", "Evelyn"));
            LibraryCatalogue.AddPatron(new Student("210000075", "Wiles", "Rebecca"));
            LibraryCatalogue.AddPatron(new Student("210000076", "Millar", "Dora"));
            LibraryCatalogue.AddPatron(new Student("210000077", "Binns", "Vivian"));
            LibraryCatalogue.AddPatron(new Student("210000078", "Kroll", "Carrie"));
            LibraryCatalogue.AddPatron(new Student("210000079", "Carruth", "Christina"));
            LibraryCatalogue.AddPatron(new Student("210000080", "Verdin", "Elsie"));

            LibraryCatalogue.AddPatron(new Staff("100001", "Bahena", "William"));
            LibraryCatalogue.AddPatron(new Staff("100002", "Dillard", "Jeffery"));
            LibraryCatalogue.AddPatron(new Staff("100003", "Lake", "Charles"));
            LibraryCatalogue.AddPatron(new Staff("100004", "Hoch", "Peter"));
            LibraryCatalogue.AddPatron(new Staff("100005", "Passmore", "Nathan"));
            LibraryCatalogue.AddPatron(new Staff("100006", "Carey", "Brandon"));
            LibraryCatalogue.AddPatron(new Staff("100007", "Arbogast", "Marvin"));
            LibraryCatalogue.AddPatron(new Staff("100008", "Cochran", "Curtis"));
            LibraryCatalogue.AddPatron(new Staff("100009", "Carney", "Nicholas"));
            LibraryCatalogue.AddPatron(new Staff("100010", "Bartz", "Christopher"));
            LibraryCatalogue.AddPatron(new Staff("100011", "Jorge", "Amber"));
            LibraryCatalogue.AddPatron(new Staff("100012", "Amaro", "Kathy"));
            LibraryCatalogue.AddPatron(new Staff("100013", "Goodall", "Laura"));
            LibraryCatalogue.AddPatron(new Staff("100014", "Vanness", "Elsie"));
            LibraryCatalogue.AddPatron(new Staff("100015", "Manning", "Darlene"));
            LibraryCatalogue.AddPatron(new Staff("100016", "Bliss", "Dianne"));
            LibraryCatalogue.AddPatron(new Staff("100017", "Storms", "Lucille"));
            LibraryCatalogue.AddPatron(new Staff("100018", "Carroll", "Diana"));
            LibraryCatalogue.AddPatron(new Staff("100019", "Kitchen", "Melinda"));
            LibraryCatalogue.AddPatron(new Staff("100020", "McNabb", "Cindy"));

            LibraryCatalogue.AddBook(new Book("Database Systems", "Rob & Coronel", "Course Technology"));
            LibraryCatalogue.AddBook(new Book("HTML & CSS: Complete Reference", "Powell", "McGraw-Hill"));
            LibraryCatalogue.AddBook(new Book("JavaScript 2.0 - Complete Reference", "Powell & Schneider", "McGraw-Hill"));
            LibraryCatalogue.AddBook(new Book("Visual C# How to Program", "Deitel & Deitel", "Pearson"));
            LibraryCatalogue.AddBook(new Book("Fundamentals of Game Design", "Adams", "Pearson"));
            LibraryCatalogue.AddBook(new Book("Computer Security: Principles and Practice", "Stallings & Brown", "Pearson"));
            LibraryCatalogue.AddBook(new Book("Single Variable Calculus Concepts & Contexts", "Stewart", "Brooks & Cole"));
            LibraryCatalogue.AddBook(new Book("Computer Networking a Top-Down Approach", "Kurose", "Pearson"));
            LibraryCatalogue.AddBook(new Book("Internet & World Wide Web How to Program", "Deitel & Deitel", "Pearson"));
            LibraryCatalogue.AddBook(new Book("Modern Operating Systems", "Tannenbaum", "Pearson"));
            LibraryCatalogue.AddBook(new Book("Game Graphics Programming", "Sherrod", "Cengage"));
            LibraryCatalogue.AddBook(new Book("Game Character Design Complete: Using 3ds Max 8 & Adobe Ph", "Franson & Thomas", "Course Technology"));
            LibraryCatalogue.AddBook(new Book("Introduction to Cryptography with Coding Theory", "Trappe & Washington", "Pearson"));
            LibraryCatalogue.AddBook(new Book("Management of Information Security", "Whitman & Mattord", "Course Technology"));
            LibraryCatalogue.AddBook(new Book("Craft of System Security", "Marchesini & Smith", "Addison-Wesley"));
        }
        #endregion
        #region Book Management Handlers
        private static void DisplayBook(object obj)
        {
            if (!(obj is Book))
               // throw new LibCatException("Display Book: Object is not a Book");
                throw new DisplayBookException();

            Book b = obj as Book;
            Console.Write(b.GetDetails());
        }

        private static void CreateBook(object obj)
        {
            string author, title, publisher;

            Console.Write("   Author: ");
            author = Console.ReadLine();
            Console.Write("    Title: ");
            title = Console.ReadLine();
            Console.Write("Publisher: ");
            publisher = Console.ReadLine();

            LibraryCatalogue.AddBook(new Book(title, author, publisher));
        }

        private static void ModifyBook(object obj)
        {
            if (!(obj is Book))
                throw new ModifyBookException();

            Book b = obj as Book;
            if (LibraryCatalogue.Books.Contains(b))
            {
                LibraryCatalogue.DeleteBook(b);
                Console.Write("Author [{0}]: ", b.Author);
                string input = Console.ReadLine();
                if (input != "")
                    b.Author = input;
                Console.Write("Title [{0}]: ", b.Title);
                input = Console.ReadLine();
                if (input != "")
                    b.Title = input;
                Console.Write("Publisher [{0}]: ", b.Publisher);
                input = Console.ReadLine();
                if (input != "")
                    b.Publisher = input;
                LibraryCatalogue.AddBook(b);
            }
        }

        private static void DeleteBook(object obj)
        {
            if (!(obj is Book))
                throw new DeleteBookException();

            Book b = obj as Book;
            LibraryCatalogue.DeleteBook(b);
        }
        #endregion
        #region Patron and Borrowing Management Handlers
        private static void DisplayPatron(object obj)
        {
            if (!(obj is Patron))
                throw new DisplayPatronException();

            Patron p = obj as Patron;
            Console.Write(p.GetDetails());
        }

        private static void CreatePatron(object obj)
        {
            string id, familyName, givenNames;

            Console.Write("         ID: ");
            id = Console.ReadLine();
            Console.Write("Family Name: ");
            familyName = Console.ReadLine();
            Console.Write("Given Names: ");
            givenNames = Console.ReadLine();

            LibraryCatalogue.AddPatron(new Patron(familyName, id, givenNames));
        }

        private static void ModifyPatron(object obj)
        {
            if (!(obj is Patron))
                throw new ModifyPatronException();

            Patron p = obj as Patron;
            if (LibraryCatalogue.Patrons.Contains(p))
            {
                LibraryCatalogue.DeletePatron(p);
                Console.Write("ID [{0}]: ", p.ID);
                string input = Console.ReadLine();
                if (input != "")
                    p.ID = input;
                Console.Write("Family Name [{0}]: ", p.FamilyName);
                input = Console.ReadLine();
                if (input != "")
                    p.FamilyName = input;
                Console.Write("Given Names [{0}]: ", p.GivenNames);
                input = Console.ReadLine();
                if (input != "")
                    p.GivenNames = input;
                LibraryCatalogue.AddPatron(p);
            }
        }

        private static void DeletePatron(object obj)
        {
            if (!(obj is Patron))
                throw new DeletePatronException();

            Patron p = obj as Patron;
                LibraryCatalogue.DeletePatron(p);
        }

        private static Patron _SelectedCustomer;
        private static void RecordSelectedCustomer(object obj)
        {
            if (!(obj is Patron))
                throw new RecordCustomerException();

            _SelectedCustomer = obj as Patron;
        }

        private static void IssueBook(object obj)
        {
            if (!(obj is BorrowableItem))
                throw new IssueBookException();

            LibraryCatalogue.BorrowBook(_SelectedCustomer, obj as BorrowableItem);
        }

        private static void ReturnBook(object obj)
        {
            if (!(obj is Borrowing))
                throw new ReturnBookException();

            LibraryCatalogue.ReturnBook(obj as Borrowing);
        }
        #endregion
        #region Menu Definition
        
        private static Menu _MainMenu = new Menu("Main Menu", new MenuOption[] {
                new MenuOption("Book Management", new Menu("Book Management Sub-Menu", new MenuOption[] {
                        new MenuOption("Display book record", null, LibraryCatalogue.GetBookList, DisplayBook),
                        new MenuOption("Create book",         null, null,                         CreateBook),
                        new MenuOption("Modify book",         null, LibraryCatalogue.GetBookList, ModifyBook),
                        new MenuOption("Delete book",         null, LibraryCatalogue.GetBookList, DeleteBook)
                    }, MenuOption.Exit),
                    null, null
                ),
                new MenuOption("Patron and Borrowing Management", new Menu("Patron and Borrowing Management Sub-Menu", new MenuOption[] {
                        new MenuOption("Display patron information", null, LibraryCatalogue.GetPatronList,     DisplayPatron),
                        new MenuOption("Record book borrowed", new Menu("Patron Borrowings Sub-Menu", new MenuOption[] {
                            new MenuOption("Borrow book",            null, LibraryCatalogue.GetBookList, IssueBook)
                        }, MenuOption.Cancel),
                        LibraryCatalogue.GetPatronList, RecordSelectedCustomer),
                        new MenuOption("Record book returned",       null, LibraryCatalogue.GetBorrowingsList, ReturnBook),
                        new MenuOption("Create patron",              null, null,                               CreatePatron),
                        new MenuOption("Modify patron",              null, LibraryCatalogue.GetPatronList,     ModifyPatron),
                        new MenuOption("Delete patron",              null, LibraryCatalogue.GetPatronList,     DeletePatron)
                    }, MenuOption.Exit),
                    null, null
                )
            },
        MenuOption.Exit);

        #endregion

        static void Main(string[] args)
        {
            LoadData();
            
            {
                MenuSystem.Run(_MainMenu);
            }
            

        }
    }
}
