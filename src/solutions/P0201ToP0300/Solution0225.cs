namespace P0201ToP0300
{
    /// <summary>
    /// 225. 用队列实现栈
    /// <para>使用队列实现栈的下列操作：</para>
    /// <code>push(x) -- 元素 x 入栈</code>
    /// <code>pop() -- 移除栈顶元素</code>
    /// <code>top() -- 获取栈顶元素</code>
    /// <code>empty() -- 返回栈是否为空</code>
    /// </summary>
    public class Solution0225
    {
        public Solution0225()
        {
        }

        public class MyStack
        {
            private readonly Queue<int> _quenen;

            /** Initialize your data structure here. */

            public MyStack()
            {
                _quenen = new Queue<int>();
            }

            /** Push element x onto stack. */

            public void Push(int x)
            {
                _quenen.Enqueue(x);
            }

            /** Removes the element on top of the stack and returns that element. */

            public int Pop()
            {
                var arr = _quenen.ToArray();
                _quenen.Clear();
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    _quenen.Enqueue(arr[i]);
                }
                return arr[^1];
            }

            /** Get the top element. */

            public int Top()
            {
                var arr = _quenen.ToArray();
                _quenen.Clear();
                for (int i = 0; i < arr.Length; i++)
                {
                    _quenen.Enqueue(arr[i]);
                }
                return arr[^1];
            }

            /** Returns whether the stack is empty. */

            public bool Empty()
            {
                return _quenen.Count == 0;
            }
        }
    }
}
