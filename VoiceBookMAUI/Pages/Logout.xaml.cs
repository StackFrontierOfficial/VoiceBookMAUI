using System.Collections.ObjectModel;

namespace VoiceBookMAUI.Pages;

public partial class Logout : ContentPage
{
    public ObservableCollection<ProfileItem> items { get; set; }
    public Logout()
    {
        InitializeComponent();

        items = new ObservableCollection<ProfileItem>()
        {
            new ProfileItem{Title= "My Library"},
            new ProfileItem{Title= "Wallet"},
            new ProfileItem{Title= "Bookmarked"},
            new ProfileItem{Title= "Notifications"},
            new ProfileItem{Title= "Support"},
            new ProfileItem{Title= "Privacy Policy"},
            new ProfileItem{Title= "Logout"}
        };

        

        BindingContext = this;
    }

    public class ProfileItem
    {
        public string? Title { get; set; }
    }
}