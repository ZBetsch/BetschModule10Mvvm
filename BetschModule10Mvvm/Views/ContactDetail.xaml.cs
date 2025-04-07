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

            EntryName.IsReadOnly = true;
            EntryEmail.IsReadOnly = true;
            EntryPhone.IsReadOnly = true;
            EntryDesc.IsReadOnly = true;

            BtnEdit.IsVisible = true;
            BtnSave.IsVisible = false;
        }
    }

    private void OnEditClicked(object sender, EventArgs e)
    {
        EntryName.IsReadOnly = false;
        EntryEmail.IsReadOnly = false;
        EntryPhone.IsReadOnly = false;
        EntryDesc.IsReadOnly = false;

        BtnEdit.IsVisible = false;
        BtnSave.IsVisible = true;
    }

    private void BtnBackClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}