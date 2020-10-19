namespace CommonLibrary
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public override string ToString()
        {
            if (this.next == null)
                return $"{val}";
            else
                return $"{val} -> {this.next}";
        }
    }
}
