using System.Collections.ObjectModel;

namespace VoiceBookMAUI.Pages;

public partial class BookList : ContentPage
{
    public ObservableCollection<Monkey> monkeys { get; set; }
    public BookList()
    {
        InitializeComponent();
        monkeys = new ObservableCollection<Monkey>
        {
            new Monkey
            {
                Name = "Grant",
                Location = "Ron Chernow",
                Details = "12 Chapters",
                ImageUrl = "book18.png"
            },
            new Monkey
            {
                Name = "War and Peace",
                Location = "Leo Tolstoy",
                Details = "10 Chapters",
                ImageUrl = "book19.png"
            },
            new Monkey
            {
                Name = "To Kill a Mockingbird",
                Location = "Harper Lee",
                Details = "15 Chapters",
                ImageUrl = "book20.png"
            },
            new Monkey
            {
                Name = "Good to Great",
                Location = "James C. Collins",
                Details = "12 Chapters",
                ImageUrl = "book6.png"
            },
            new Monkey
            {
                Name = "The Ginger Man",
                Location = "J P Donleavy",
                Details = "12 Chapters",
                ImageUrl = "book21.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "12 Chapters",
                ImageUrl = "book22.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book23.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book24.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book25.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book26.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Asia",
                Details = "Orangutans are known for their...",
                ImageUrl = "book2.png"
            },
        };
        BindingContext = this;

    }
}
public class Monkey
{
    public string? Name { get; set; }
    public string? Location { get; set; }
    public string? Details { get; set; }
    public string? ImageUrl { get; set; }
}