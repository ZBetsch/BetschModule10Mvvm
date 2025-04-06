using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BetschModule10Mvvm.Models
{
    public partial class Contact : ObservableObject
    {
        [ObservableProperty]
        private string contactName;

        [ObservableProperty]
        private string contactEmail;

        [ObservableProperty]
        private string contactPhone;

        [ObservableProperty]
        private string contactDescription;
    }
}
