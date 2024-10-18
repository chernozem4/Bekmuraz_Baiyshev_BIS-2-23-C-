using System;

class Book
{
    public string Title { get; set; }  // Название книги
    public string Author { get; set; }  // Автор
    public bool Thereis { get; set; }  // изначально хотел стрингом порешать, но потом понял, что тогда код будет сложнее и больше, т.к. придется писать дополнительные части "выдана" и "есть" и потом их соединиять, а я глупый, поэтому тупо подсмотрел в интернете что можно использовать булево значение, которое может хранить в себе true false и потом if else

    
    // Конструктор
    public Book(string title, string author, bool thereis)
    {
        Title = title;
        Author = author;
        Thereis = thereis;
    }
    // Конкретно эта часть изменяет статус доступности книги, есть булево значение thereis и мы даем ему возможность изменится, создаем метод изменения, создаем новое болевое значение и присваем его thereis 
    public void Change(bool Chupachups)
    {
        
        Thereis = Chupachups;
    }
    // вывод нашей книги
    public void DisplayInfo()
    {
        
        Console.WriteLine($"Название: {Title}");
        Console.WriteLine($"Автор: {Author}");
        if (Thereis)
        {
            Console.WriteLine("Доступна");
        }
        else
        {
            Console.WriteLine("Выдана");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        Book book = new Book("Крутые яйца", "Пушкин эминем", true); //здесь мы можем изменить значение на фалс, и статус книги изменится
        book.DisplayInfo();
        //конекретно эта часть нам нужна для изменения статуса книги, если у нас там false, то здесь будет true 
        //Console.WriteLine("\nстатус");
        //book.Change(true);
        //book.DisplayInfo();



    }
}
    