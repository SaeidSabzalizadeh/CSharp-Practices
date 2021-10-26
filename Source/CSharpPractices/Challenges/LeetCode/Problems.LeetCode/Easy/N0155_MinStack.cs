using System.Collections.Generic;

namespace Problems.LeetCode.Easy
{


    /// <summary>
    /// Min Stack
    /// 
    /// Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
    /// Implement the MinStack class:
    /// 
    /// MinStack() initializes the stack object.
    /// void push(int val) pushes the element val onto the stack.
    /// void pop() removes the element on the top of the stack.
    /// int top() gets the top element of the stack.
    /// int getMin() retrieves the minimum element in the stack.
    /// 
    /// 
    /// -231 <= val <= 231 - 1
    /// Methods pop, top and getMin operations will always be called on non-empty stacks.
    /// At most 3 * 104 calls will be made to push, pop, top, and getMin.
    /// 
    /// https://leetcode.com/problems/min-stack/
    /// </summary>
    public class N0155_MinStack
    {
        public class MinStack
        {
            public Stack<int> s;
            int minElement = int.MaxValue;

            public MinStack()
            {
                s = new Stack<int>();
            }

            public void Push(int val)
            {
                if (minElement >= val)
                {// whenever val is lesser than current minElement, store current minElement in stack and make val as current minElement
                    s.Push(minElement);
                    minElement = val;
                }
                s.Push(val);
            }

            public void Pop()
            {
                if (minElement == s.Peek())
                {//top is minElement then previous element will be previous minElement, so pop and store current top as current MinElement
                    s.Pop();
                    minElement = s.Peek();
                }
                s.Pop();
            }

            public int Top()
            {// return stack top
                return s.Peek();
            }

            public int GetMin()
            {//return minElement
                return minElement;
            }
        };

        public class MinStackI
        {
            int[] Stack;
            int TopIndex = -1;

            public MinStackI()
            {
                Stack = new int[long.MaxValue];
            }

            public void Push(int val)
            {
                TopIndex++;
                Stack[TopIndex] = val;
            }

            public void Pop()
            {
                TopIndex--;
            }

            public int Top()
            {
                return Stack[TopIndex];
            }

            public int GetMin()
            {
                if (TopIndex < 0)
                    throw new System.Exception("No Stack");

                int minVal = int.MaxValue;

                for (int i = 0; i < TopIndex; i++)
                {
                    if (Stack[TopIndex] < minVal)
                        minVal = Stack[TopIndex];
                }

                return minVal;
            }
        }
    }
}
