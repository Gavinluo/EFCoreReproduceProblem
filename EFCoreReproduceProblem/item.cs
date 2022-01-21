using System;
using System.Collections.Generic;

namespace EFCoreReproduceProblem
{
    [Serializable]
    public partial class item
    {
        public item()
        {
            this.itemDetail = new List<itemDetail>();
        }
        public string ItemGID { get; set; }
        public virtual ICollection<itemDetail> itemDetail { get; set; }

    }
}
