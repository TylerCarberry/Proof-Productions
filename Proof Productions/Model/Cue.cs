using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proof_Productions.Model
{
    class Cue
    {
       List<CueItem> ItemList = new List<CueItem>();

        public void Add(CueItem Item)
        {
            ItemList.Add(Item);
        }


        public CueItem GetItem(int Index)
        {
            if (Index >= 0 && Index < ItemList.Count)
                return ItemList[Index];
            else
                return null;
        }

        public List<CueItem> GetList()
        {
            return ItemList;
        }


       
    }
}
