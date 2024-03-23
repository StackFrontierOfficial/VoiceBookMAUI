using System.Collections.ObjectModel;

namespace VoiceBookMAUI.Pages;

public partial class Bookmarked : ContentPage
{
    public ObservableCollection<Monkey> monkeys { get; set; }
    public Bookmarked()
	{
		InitializeComponent();
        monkeys = new ObservableCollection<Monkey>
        {
            new Monkey
            {
                Name = "Treasure of Th...",
                Location = "Robert F. Marx",
                Details = "12 Chapters",
                ImageUrl = "book8.png"
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
                Name = "Good to Great",
                Location = "James C. Collins",
                Details = "12 Chapters",
                ImageUrl = "book6.png"
            }
        };
        BindingContext = this;
    }

    private void SwipeView_SwipeEnded(object sender, SwipeEndedEventArgs e)
    {

    }
}