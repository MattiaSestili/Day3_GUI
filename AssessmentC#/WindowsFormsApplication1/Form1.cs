using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {        

        public class Book
        {
            public string Author { get; set; }
            public string Title { get; set; }
            public string ISBN { get; set; }
            public string Price { get; set; }

            public Book(string author, string title, string isbn, string price)
            {
                this.Author = author;
                this.Title = title;
                this.ISBN = isbn;
                this.Price = price;
            }
        }
        
        List<Book> bookList = new List<Book>();
        Book book1 = new Book("J.K.K Rowling", "Harry Potter", "ISBN 5514896247", "11.00");
        Book book2 = new Book("J.R.R Tolkien", "The Lord of The ring", "ISBN 554789641", "18.24");
        Book book3 = new Book("J.K.K Rowling", "The Hunger Games", "ISBN 88741236558", "14.19");

        //bookList.Add(book1);
        //bookList.Add(book2);
        //bookList.Add(book3);      
        
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Book addBook = new Book(
                textBoxAuthor.Text,
                textBoxTitle.Text,
                textBoxISBN.Text,
                textBoxPrice.Text);    
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);

            string newBook = "";

            for(int i = 0; i < bookList.Count; i++)
            {
                newBook += bookList[i];
                //comboBox1.Text = comboBox1.Items.Insert();
            }         

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
