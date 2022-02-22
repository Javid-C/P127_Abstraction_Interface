using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Abstraction_Interface
{
    //fields
    public partial class Book
    {
        public int Id;
        public string Name;
        public string Author;
        public string Category;
        public string Publisher;
        public byte Volume;

    }



    //props
    public partial class Book
    {
        public int PageCount { get; set; }
        public string CoverImage { get; set; }
        public string Introduction { get; set; }
        public string Language { get; set; }
        public string ReleaseDate { get; set; }
        public bool BestSeller { get; set; }
    }

    partial class Book
    {
        public int AddBook()
        {
            return Id;
        }
        public int AddBook1()
        {
            return Id;
        }
        public int AddBook2()
        {
            return Id;
        }
        public int AddBook3()
        {
            return Id;
        }
        public int AddBook4()
        {
            return Id;
        }
        public int AddBook5()
        {
            return Id;
        }
        public int AddBook6()
        {
            return Id;
        }
    }
}
