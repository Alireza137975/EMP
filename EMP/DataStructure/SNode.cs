using System.IO;

namespace EMP.DataStructure
{
    class SNode
    {
        public string Name;
        public string Address;
        public SNode Next;

        public SNode(string info)
        {
            this.Address = info;
            this.Name = Path.GetFileName(info);
            this.Next = null;
        }
    }
}
