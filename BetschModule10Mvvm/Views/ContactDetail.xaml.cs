using BetschModule10Mvvm.Models.ViewModels;

namespace BetschModule10Mvvm.Views;

public partial class ContactDetail : ContentPage
{
	public ContactDetail()
	{
		InitializeComponent();
	}

    private void OnSaveClicked(object sender, EventArgs e)
    {
        if (BindingContext is ContactDetailViewModel vm)
        {
            DisplayAlert("Saved", "Contact details have been updated.", "OK");
            Navigation.PopAsync();
        }
    }
}