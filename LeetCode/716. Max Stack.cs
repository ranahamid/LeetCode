﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MaxStack_LinkedList
    {

        class Node
        {
            public Node prev;
            public Node next;
            public int val;
            public Node() { }
            public Node(int val)
            {
                this.val = val;
            }
        }

        SortedDictionary<int, List<Node>> map = new SortedDictionary<int, List<Node>>(Comparer<int>.Create((a, b) => -a.CompareTo(b)));
        Node head, tail;
        public MaxStack_LinkedList()
        {
            this.head = new Node();
            this.tail = new Node();
            head.next = tail;
            tail.prev = head;
        }
        public void Push(int x)
        {
            //void push(int x) Pushes element x onto the stack.
            Node node = new Node(x);

            map.TryAdd(x, new List<Node>());
            map[x].Add(node);

            Node last = tail.prev;

            last.next = node;
            node.prev = last;
            node.next = tail;
            tail.prev = node;
        }
        public int Pop()
        {
            //int pop() Removes the element on top of the stack and returns it.
            Node last = tail.prev;
            last.prev.next = tail;
            tail.prev = last.prev;
            map[last.val].RemoveAt(map[last.val].Count - 1);
            if (map[last.val].Count == 0)
                map.Remove(last.val);
            return last.val;
        }
        public int Top()
        {
            return tail.prev.val;
        }
        public int PeekMax()
        {
            return map.First().Value[0].val;
        }
        public int PopMax()
        {
            List<Node> list = map.First().Value;
            Node node = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            if (list.Count == 0)
                map.Remove(node.val);
            node.prev.next = node.next;
            node.next.prev = node.prev;
            return node.val;
        }
    }
    #region TLE
    public class MaxStack_TLE
    {
        Stack<int> stack;
        Stack<int> maxStack;
        public MaxStack_TLE()
        {
            stack = new Stack<int>();
            maxStack = new Stack<int>();
        }

        public void Push(int x)
        {
            var max = stack.Count == 0 ? x : maxStack.Peek();
            maxStack.Push(max > x ? max : x);
            stack.Push(x);
        }

        public int Pop()
        {
            maxStack.Pop();
            return stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int PeekMax()
        {
            return maxStack.Peek();
        }

        public int PopMax()
        {
            var max = PeekMax();

            var buffer = new Stack<int>();
            while (Top() != max)
            {
                buffer.Push(Pop());
            }
            Pop();
            while (buffer.Count > 0)
            {
                Push(buffer.Pop());
            }
            return max;
        }
    }
    #endregion
}
