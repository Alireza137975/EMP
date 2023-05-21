using System;

namespace EMP.DataStructure
{
    class SLLIST
    {
        SNode Head;
        SNode Tail;
        int count;

        public int Count { get { return count; } }
        public string GetHeadData { get { return Head.Address; } }

        public SLLIST()
        {
            Head = null;
            Tail = null;
        }

        public bool IsEmpty()
        {
            if (count <= 0) return true;
            return false;
        }

        public void Add(string val)
        {
            if (!String.IsNullOrWhiteSpace(val))
            {
                SNode node = new SNode(val);

                if (Head == null)
                {
                    Head = node;
                    Tail = node;
                    count++;
                }

                else
                {
                    Tail.Next = node;
                    Tail = Tail.Next;
                    count++;
                }
            }
        }

        public void AddRange(string[] vals)
        {
            foreach (string value in vals)
            {
                Add(value);
            }
        }

        public void Remove(string val)
        {
            SNode t = Head;
            if (t.Name == val)
            {
                Head = Head.Next;
                count--;
                return;
            }

            while (t.Next != null)
            {
                if (t.Next.Name == val)
                {
                    t.Next = t.Next.Next;
                    count--;
                    return;
                }
                t = t.Next;
            }
        }

        //for Selecting Exact Object
        public string SearchByName(string _name)
        {
            SNode t = Head;

            while (t != null)
            {
                if (t.Name == _name)
                {
                    return t.Address;
                }
                t = t.Next;
            }
            return null;
        }

        public string SelectNextObject(string _objAddress, bool allowRepeat = false)
        {
            SNode t = Head;

            while (t != null)
            {
                if (t.Address == _objAddress)
                {
                    if (t.Next != null) return t.Next.Address;
                    else if (allowRepeat == false) return null;
                    else return Head.Address;
                }
                t = t.Next;

                if (t.Next == null) return Head.Address;
            }

            return null;
        }

        public string SelectPreviousObject(string _objAddress, bool allowRepeat = false)
        {
            SNode t = Head;

            if (allowRepeat == false) { if (t.Address == _objAddress) return t.Address; }

            while (t != null)
            {
                if (t.Next.Address == _objAddress)
                {
                    return t.Address;
                }
                t = t.Next;
                if (t.Next == null) return t.Address;
            }

            return null;
        }

        public string SelectRandomObject()
        {
            SNode t = Head;

            Random rm = new Random();
            int index = rm.Next(0, Count - 1);

            for (int i = 0; i <= index; i++)
            {
                if (i == index) return t.Address;
                t = t.Next;
            }

            return null;
        }

        public string[] GetAllMembers()
        {
            SNode t = Head;
            string[] members = new string[Count];

            for (int i = 0; i < Count; i++)
            {
                members[i] += t.Address;
                t = t.Next;
            }
            return members;
        }
    }
}
