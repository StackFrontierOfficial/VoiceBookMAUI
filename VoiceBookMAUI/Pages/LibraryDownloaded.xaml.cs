using System.Collections.ObjectModel;

namespace VoiceBookMAUI.Pages;

public partial class LibraryDownloaded : ContentPage
{
    public ObservableCollection<AudioBook> books { get; set; }
    public LibraryDownloaded()
	{
		InitializeComponent();
        Random random = new Random();

        // Predefined arrays for location and duration
        string[] locations = { "The Hobbit", "Harry Potter and the Philosopher's Stone", "And Then There Were None", "The Lion, the Witch and the Wardrobe", "A History of Adventure", "The Adventures of Pinocchio", "The Da Vinci Code", "Harry Potter and the Chamber of Secrets", "The Catcher in the Rye", "Ben-Hur: A Tale of the Christ", "The Common Sense Book of Baby and Child Care", "Anne of Green Gables" };
        string[] size = { "J.R.R Tolkien", "J.K.Rowling", "Antoine de Saint-Exupery", "Cao Xueqin", "Agatha Christie", "C.S. Lewis", "H. Rider Haggard", "Carlo Collodi", "J.D. Sallinger", "Benjamin Spock" };
        string[] durations = { "5hr-49 mins", "6hr-10 mins", "4hr-05 mins", "2hr-17 mins", "6hr-15 mins" };

        books = new ObservableCollection<AudioBook>();

       

        // Create 20 Book objects with random values and add them to the list
        for (int i = 1; i <= 20; i++)
        {
            // Generate random values
            string randomName = locations[random.Next(locations.Length)];
            string randomSize = size[random.Next(size.Length)];
            string randomDuration = durations[random.Next(durations.Length)];

            // Create Book object with random values and add to list
            books.Add(new AudioBook
            {
                Chapter = randomName.Length > 30 ? randomName.Substring(0, 30) + "..." : randomName,
                Size = $"{randomSize}*{randomDuration}",
                Duration = randomDuration

            });
        }

        BindingContext = this;
    }
}