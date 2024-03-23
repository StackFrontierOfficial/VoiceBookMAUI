using System.Collections.ObjectModel;

namespace VoiceBookMAUI.Pages;

public partial class Reviews : ContentPage
{
    public ObservableCollection<Person> books { get; set; }
    public Reviews()
	{
		InitializeComponent();
        Random random = new Random();

        // Predefined arrays for location and duration
        string[] locations = { "Jane Cooper", "Esther Howard", "Wade Warren", "Jacob Jones", "Jenny Wilson" };
        string[] ratings = { "5.0", "4.0", "4.2", "5.0" };

        books = new ObservableCollection<Person>();

        // Create 20 Book objects with random values and add them to the list
        for (int i = 1; i <= 5; i++)
        {
            // Generate random values
            string randomName = locations[random.Next(locations.Length)];
            string randomRatings = ratings[random.Next(ratings.Length)];
            

            // Create Book object with random values and add to list
            books.Add(new Person
            {
                Name = randomName,
                Rating = randomRatings,
                Date = "20 March 2020",
                PersonImage = $"user{i+2}.png",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,"
            });
        }
        BindingContext = this;
    }
}

public class Person
{
    public string? Name { get; set; }
    public string? PersonImage { get; set; }
    public string? Date { get; set; }
    public string? Rating { get; set; }
    public string? Review { get; set; }
}