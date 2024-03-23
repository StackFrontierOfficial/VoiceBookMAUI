using System.Collections.ObjectModel;

namespace VoiceBookMAUI.Pages;

public partial class Chapters : ContentPage
{
    public ObservableCollection<Book> books { get; set; }
    public Chapters()
	{
		InitializeComponent();
        Random random = new Random();

        // Predefined arrays for location and duration
        string[] locations = { "Library", "Bookstore", "Home", "School", "Coffee Shop" };
        string[] durations = { "15-49 mins", "13-10 mins", "14-05 mins", "12-17 mins", "15-15 mins" };

        books = new ObservableCollection<Book>();

        // Create 20 Book objects with random values and add them to the list
        for (int i = 1; i <= 20; i++)
        {
            // Generate random values
            string randomLocation = locations[random.Next(locations.Length)];
            string randomDuration = durations[random.Next(durations.Length)];

            // Create Book object with random values and add to list
            books.Add(new Book
            {
                SerialNumber = i,
                Location = randomLocation,
                Duration = randomDuration
            });
        }
        BindingContext = this;
    }
}

public class Book
{
    public int SerialNumber { get; set; }
    public string? Location { get; set; }
    public string? Duration { get; set; }
}