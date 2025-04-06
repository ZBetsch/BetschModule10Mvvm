using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BetschModule10Mvvm.Models.ViewModels
{
    partial class ContactDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        private Contact contact;
    }
}
