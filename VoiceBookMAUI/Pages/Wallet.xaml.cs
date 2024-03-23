using System.Collections.ObjectModel;

namespace VoiceBookMAUI.Pages;

public partial class Wallet : ContentPage
{
    public ObservableCollection<Transaction> books { get; set; }
    public Wallet()
	{
		InitializeComponent();
        Random random = new Random();

        // Predefined arrays for location and duration
        string[] bookName = { "The Hobbit","Money Added To Wallet", "Harry Potter and the Philosopher's Stone", "And Then There Were None", "The Lion, the Witch and the Wardrobe", "Money Added To Wallet", "The Adventures of Pinocchio", "The Da Vinci Code", "Harry Potter and the Chamber of Secrets", "The Catcher in the Rye", "Money Added To Wallet", "Money Added To Wallet", "Anne of Green Gables" };
        string[] author = { "J.R.R Tolkien", "J.K.Rowling", "Antoine de Saint-Exupery", "Cao Xueqin", "Agatha Christie", "C.S. Lewis", "H. Rider Haggard", "Carlo Collodi", "J.D. Sallinger", "Benjamin Spock" };
        string[] date = { "29 Jan 2020", "11 Jan 2020", "18 Jan 2020", "20 Jan 2020", "16 Jan 2020" };

        books = new ObservableCollection<Transaction>();



        // Create 20 Book objects with random values and add them to the list
        for (int i = 1; i <= 20; i++)
        {
            // Generate random values
            string randomName = bookName[random.Next(bookName.Length)];
            string randomAuthor = author[random.Next(author.Length)];
            string randomDuration = date[random.Next(date.Length)];

            // Create Book object with random values and add to list
            books.Add(new Transaction
            {
                BookName = randomName.Length > 25 ? randomName.Substring(0, 25) + "..." : randomName,
                Author = randomName.Equals("Money Added To Wallet") ? "Bank of Baroda": randomAuthor,
                Date = randomDuration,
                PriceColor = randomName.Equals("Money Added To Wallet") ?  "#009788": "#c94c3e"

            });
        }

        BindingContext = this;
    }
}

public class Transaction
{
    public string? BookName { get; set; }
    public string? Author { get; set; }
    public string? Date { get; set; }
    public string? PriceColor { get; set; }
}