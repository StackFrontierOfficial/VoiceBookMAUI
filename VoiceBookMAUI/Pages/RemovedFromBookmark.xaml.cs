using System.Collections.ObjectModel;

namespace VoiceBookMAUI.Pages;

public partial class RemovedFromBookmark : ContentPage
{
    public ObservableCollection<Monkey> monkeys { get; set; }
    public RemovedFromBookmark()
	{
		InitializeComponent();
        monkeys = new ObservableCollection<Monkey>
        {
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
}