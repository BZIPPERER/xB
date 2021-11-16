using System.Collections.ObjectModel;
using System.Collections.Generic;
using System;

namespace xBalsat
{
    public class SelectableItemList : ObservableCollection<SelectableItem>
    {
        //factory method
        //<param name="items">Liste der Datenobjekte</param>
        public static SelectableItemList FromItems(IEnumerable<string> items)
        {
            var list = new SelectableItemList();
            foreach(var item in items)
            {
               
                list.Add(new SelectableItem { Data = item});
            }

            return list;
        }
        
    }
}