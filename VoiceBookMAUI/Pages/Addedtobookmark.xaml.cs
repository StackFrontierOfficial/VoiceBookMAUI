using System.Collections.ObjectModel;

namespace VoiceBookMAUI.Pages;

public partial class Addedtobookmark : ContentPage
{
    public ObservableCollection<Book> Books { get; set; }
    public Addedtobookmark()
	{
        InitializeComponent();
        Books = new ObservableCollection<Book>
        {
            new Book
            {
                Name = "Grant",
                Location = "Ron Chernow",
                Details = "12 Chapters",
                ImageUrl = "book18.png"
            },
            new Book
            {
                Name = "War and Peace",
                Location = "Leo Tolstoy",
                Details = "10 Chapters",
                ImageUrl = "book19.png"
            },
            new Book
            {
                Name = "To Kill a Mockingbird",
                Location = "Harper Lee",
                Details = "15 Chapters",
                ImageUrl = "book20.png"
            },
            new Book
            {
                Name = "Good to Great",
                Location = "James C. Collins",
                Details = "12 Chapters",
                ImageUrl = "book6.png"
            },
            new Book
            {
                Name = "The Ginger Man",
                Location = "J P Donleavy",
                Details = "12 Chapters",
                ImageUrl = "book21.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "12 Chapters",
                ImageUrl = "book22.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book23.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book24.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book25.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book26.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Book
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
        };

        BindingContext = this;
    }

    public class Book
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? Details { get; set; }
        public string? ImageUrl { get; set; }
    }
}