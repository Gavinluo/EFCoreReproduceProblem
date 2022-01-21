using System;

namespace EFCoreReproduceProblem
{
    [Serializable]
    public partial class itemDetail
    {
        public string ItemGID { get; set; }
        public string GUID { get; set; }
        public virtual item item { get; set; }
    }
}
