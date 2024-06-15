namespace OOPApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tempText = "A class can contain one or more constructors, fields, methods, properties, delegates, and events. They are called class members. A class and its members can have access modifiers such as public, private, protected, and internal, to restrict access from other parts of the program.\r\n\r\nLet's add different members to the Student class.";

            Book bookH = new Book(tempText);
       
    
            bookH.Title = "C# book";
      
            Console.WriteLine(bookH.PageCount);
            Console.WriteLine(bookH.WordCount);
        }
    }
}
