using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model
{
    public class Cue
    {
        public String Name;
        private List<CueItem> CueList = new List<CueItem>();

        public void Add(CueItem Item)
        {
            CueList.Add(Item);
        }


        public CueItem GetItem(int Index)
        {
            if (Index >= 0 && Index < CueList.Count)
                return CueList[Index];
            else
                return null;
        }

    }
}
