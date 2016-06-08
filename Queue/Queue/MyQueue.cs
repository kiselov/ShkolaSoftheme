using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class MyQueue
    {
        private Stack<int> stack = new Stack<int>();
        private Stack<int> temp = new Stack<int>();

        public void Push(int Value)
        {
            stack.Push(Value);
        }

        public int Pop()
        {
            while (stack.Count != 0)
                temp.Push(stack.Pop());

            int Value = temp.Pop();

            while (temp.Count != 0)
                stack.Push(temp.Pop());

            return Value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            while (stack.Count != 0)
                temp.Push(stack.Pop());

            while (temp.Count != 0)
            {
                sb.Append(temp.Peek());
                sb.Append(" ");
                stack.Push(temp.Pop());
            }

            return sb.ToString();
        }
    }
}
