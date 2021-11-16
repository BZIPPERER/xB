using System.Collections.ObjectModel ;
namespace xBalsat
{
    public class ViewModel
    {
        public ObservableCollection<SelectableItem> Liste 
        { get; set; }

        public ViewModel()
        {
            Liste = SelectableItemList.FromItems(null);

        }
    }
}