using BetschModule10Mvvm.Models.ViewModels;

namespace BetschModule10Mvvm.Views;
public partial class HomePage : ContentPage
{
    private ContactsListViewModel contactViewModel;

    public HomePage()
	{
		InitializeComponent();
		contactViewModel = new ContactsListViewModel();
        BindingContext = contactViewModel;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var contactList = new ContactList();
        contactList.BindingContext = contactViewModel;
        Navigation.PushAsync(contactList);
    }
}