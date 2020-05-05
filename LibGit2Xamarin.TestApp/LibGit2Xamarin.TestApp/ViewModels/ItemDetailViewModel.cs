using System;

using LibGit2Xamarin.TestApp.Models;

namespace LibGit2Xamarin.TestApp.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
