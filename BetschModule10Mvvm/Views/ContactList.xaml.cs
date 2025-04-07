using BetschModule10Mvvm.Models.ViewModels;
using BetschModule10Mvvm.Models;
using Contact = BetschModule10Mvvm.Models.Contact;

namespace BetschModule10Mvvm.Views;

public partial class ContactList : ContentPage
{
	public ContactList()
	{
		InitializeComponent();
	}

    private void Lv_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var contact = e.Item as Contact;
		var contactDetailViewModel = new ContactDetailViewModel { Contact = contact };
		var contactDetail = new ContactDetail();
		contactDetail.BindingContext = contactDetailViewModel;
		Navigation.PushAsync(contactDetail);
    }

	private void BtnBackClicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}