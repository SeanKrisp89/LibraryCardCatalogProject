using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LibraryCardCatalogProject
{
    
    public class CardCatalog
    {
        private string FileName { get; set; }
        private Book Books { get; set; } // Should this be the collection of books? 

        List<Book> BookList = new List<Book>();

        BinaryFormatter bf = new BinaryFormatter();

        Stream stream; 

        public CardCatalog(string fileName)
        {
            FileName = fileName;
        }

        public void ListBooks() // Should display our Book collection. List is stored above as Books, BUT WHERE DO WE CREATE THE LIST? 
        {
            stream = File.Open(FileName + ".dat", FileMode.Open);               
            bf = new BinaryFormatter();

            //BookList = (Book)bf.Deserialize(stream);                          
            stream.Close();
        }

        public void AddBook() // Add book object to our book object list?
        {
            
            Console.WriteLine("Enter book's title: ");
            string bTitle = Console.ReadLine();
            Console.WriteLine("Enter book's author: ");
            string bAuthor = Console.ReadLine();
            Console.WriteLine("Enter book's genre: ");
            string bGenre = Console.ReadLine();
            var book1 = new Book(bTitle, bAuthor, bGenre);
            BookList.Add(book1);
        }

        public void Save() // Should serialize books to file? 
        {
            stream = File.Open(FileName + ".dat", FileMode.Create);
            bf.Serialize(stream, BookList);
            stream.Close();
        }

        

        List<CardCatalog> CardsFileName = new List<CardCatalog>();
    }
}
