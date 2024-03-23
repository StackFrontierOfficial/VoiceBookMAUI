using System.Collections.ObjectModel;

namespace VoiceBookMAUI.Pages;

public partial class DeleteNotification : ContentPage
{
    public ObservableCollection<Monkey> monkeys { get; set; }
    public DeleteNotification()
    {
        InitializeComponent();
        var Name = "Rate the book you last read 'Harry Potter and The Philosopher's stone'";
        monkeys = new ObservableCollection<Monkey>
        {
              
            new Monkey
            {
                Name = "Do you like this app? If yes then rate us on Playstore now",
                Location = "3 Days ago",

            },

            new Monkey
            {
                Name = "You have not listen a new book from last 5 days.Get new launched collection.",
                Location = "3 Days ago",

            }
        };
        BindingContext = this;
    }
}