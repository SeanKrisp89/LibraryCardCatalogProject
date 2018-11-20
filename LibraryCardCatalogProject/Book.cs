using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LibraryCardCatalogProject
{
    [Serializable()]
    public class Book : ISerializable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        public Book(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }

        public override string ToString()
        {
            return string.Format("You've entered: {0} by {1}, a {2} book.", Title, Author, Genre);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Title", Title);
            info.AddValue("Author", Author);
            info.AddValue("Genre", Genre);
        }

        public Book(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the properties                
            Title = (string)info.GetValue("Title", typeof(string));
            Author = (string)info.GetValue("Author", typeof(string));
            Genre = (string)info.GetValue("Genre", typeof(string));
            
        }




    }

    
}
