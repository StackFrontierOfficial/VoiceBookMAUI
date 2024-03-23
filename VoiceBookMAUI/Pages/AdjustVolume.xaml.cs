using System.Collections.ObjectModel;

namespace VoiceBookMAUI.Pages;

public partial class AdjustVolume : ContentPage
{
    public ObservableCollection<AudioBook> monkeys { get; set; }
    public new string? Title { get; set; }
    public AdjustVolume()
	{
		InitializeComponent();
        Random random = new Random();

        Title = "";
        string[] locations = { "The Boy Who Lived", "The Vanishing Glass", "The Keeper of Keys", "Diagon Alley", "The Journey from Platform Nine", "The Sorting Hat", "The Potions Master", "The Midnight Duel", "Hallowe'en", "Quidditch", "The Mirror Of Erised", "Nicolas Flamel", "The Forebidden Forest" };
        string[] size = { "55", "30", "42", "39", "12", "20", "23", "27", "48", "16" };
        string[] durations = { "15-49 mins", "13-10 mins", "14-05 mins", "12-17 mins", "15-15 mins" };


        monkeys = new ObservableCollection<AudioBook>();
        
        

        // Create 20 Book objects with random values and add them to the list
        for (int i = 1; i <= 20; i++)
        {
            // Generate random values
            string randomName = locations[random.Next(locations.Length)];
            string randomSize = size[random.Next(size.Length)];
            string randomDuration = durations[random.Next(durations.Length)];


            // Create Book object with random values and add to list
            monkeys.Add(new AudioBook
            {
                SerialNumber = i,
                Chapter = randomName,
                Size = $"{randomSize} MB",
                Duration = randomDuration

            });
        }

        BindingContext = this;
    }
}