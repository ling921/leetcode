namespace CommonLibrary.Models
{
    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }

        public static implicit operator string(ListNode node) => node.ToString();

        public override string ToString()
        {
            return next == null ? $"{val}" : $"{val} -> {next}";
        }
    }
}