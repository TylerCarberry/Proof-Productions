using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proof_Productions.Model;

namespace Proof_Productions.Model
{
    public class Cue
    {
        List<CueItem> ItemList = new List<CueItem>();
        public String Name = "Default Cue";
        public String Description;


        public Cue() { }

        public Cue(String Name, String Description)
        {
            this.Name = Name;
            this.Description = Description;
        }

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
