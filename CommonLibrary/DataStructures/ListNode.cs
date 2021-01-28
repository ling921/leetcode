namespace CommonLibrary
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }

        public override string ToString()
        {
            return next == null ? $"{val}" : $"{val} -> {next}";
        }
    }
}
