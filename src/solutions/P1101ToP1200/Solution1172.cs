namespace P1101ToP1200
{
    /// <summary>
    /// 1172. 餐盘栈
    /// </summary>
    public class Solution1172
    {
        public Solution1172()
        {
            //var dinnerPlates = new DinnerPlates(2);
            //dinnerPlates.Push(1);
            //dinnerPlates.Push(2);
            //dinnerPlates.Push(3);
            //dinnerPlates.Push(4);
            //dinnerPlates.Push(5);
            //WriteLine(dinnerPlates.PopAtStack(0));
            //dinnerPlates.Push(20);
            //dinnerPlates.Push(21);
            //WriteLine(dinnerPlates.PopAtStack(0));
            //WriteLine(dinnerPlates.PopAtStack(2));
            //WriteLine(dinnerPlates.Pop());
            //WriteLine(dinnerPlates.Pop());
            //WriteLine(dinnerPlates.Pop());
            //WriteLine(dinnerPlates.Pop());
            //WriteLine(dinnerPlates.Pop());

            var dinnerPlates = new DinnerPlates(1);
            dinnerPlates.Push(1);
            dinnerPlates.Push(2);
            dinnerPlates.Push(3);
            WriteLine(dinnerPlates.PopAtStack(1));
            WriteLine(dinnerPlates.Pop());
            WriteLine(dinnerPlates.Pop());
        }

        public class DinnerPlates
        {
            private readonly int _capacity;
            private readonly List<Stack<int>> _plates;
            private int _firstNotFullStack;
            private int _lastNotEmptyStack;

            public DinnerPlates(int capacity)
            {
                _capacity = capacity;
                _plates = new List<Stack<int>>();
                _firstNotFullStack = -1;
                _lastNotEmptyStack = -1;
            }

            public void Push(int val)
            {
                if (_firstNotFullStack == -1)
                {
                    var plate = new Stack<int>(_capacity);
                    plate.Push(val);
                    _plates.Add(plate);
                    _firstNotFullStack = _capacity == 1 ? -1 : _plates.Count - 1;
                }
                else
                {
                    _plates[_firstNotFullStack].Push(val);
                    while (_firstNotFullStack < _plates.Count)
                    {
                        if (_plates[_firstNotFullStack].Count < _capacity)
                        {
                            break;
                        }
                        _firstNotFullStack++;
                    }
                    if (_firstNotFullStack == _plates.Count)
                        _firstNotFullStack = -1;
                }
                _lastNotEmptyStack = Math.Max(_firstNotFullStack, _lastNotEmptyStack);
            }

            public int Pop()
            {
                if (_lastNotEmptyStack == -1)
                {
                    return -1;
                }
                else
                {
                    var res = _plates[_lastNotEmptyStack].Pop();
                    if (_plates[_lastNotEmptyStack].Count == 0)
                    {
                        _lastNotEmptyStack--;
                        _firstNotFullStack = Math.Min(_firstNotFullStack, _lastNotEmptyStack);
                    }
                    return res;
                }
            }

            public int PopAtStack(int index)
            {
                if (index < _plates.Count && _plates[index].Count > 0)
                {
                    var res = _plates[index].Pop();
                    if (_plates.Count == 0 && index == _lastNotEmptyStack)
                        _lastNotEmptyStack--;
                    _firstNotFullStack = _firstNotFullStack == -1 ? index : Math.Min(_firstNotFullStack, index);
                    return res;
                }
                return -1;
            }
        }
    }
}
