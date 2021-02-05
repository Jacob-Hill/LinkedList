using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList <T>
    {
        private class ListNode
        {
            public T Data { get; set; }
            public ListNode NextNode { get; set; }

            public ListNode(T data)
            {
                Data = data;
                NextNode = null;
            }

            public ListNode(T data, ListNode prevNode)
            {
                Data = data;
                prevNode.NextNode = this;
            }
        }

        private ListNode head;
        private ListNode tail;
        private int length;

        public LinkedList()
        {
            head = null;
            tail = null;
            length = 0;
        }
        public void Add(T data)
        {
            if (head == null)
            {
                head = new ListNode(data);
                tail = head;
            }
            else
            {
                ListNode newTail = new ListNode(data, tail);
                tail = newTail;
            }
            length++;
        }

        public void Insert(T data, int position)
        {
            if (position < 0 || position > length) 
            {
                throw new Exception("Position is out of bounds");
            }
            else if (head == null || position == length)
            {
                Add(data);
            }
            else
            {
                ListNode prevNode = FindNodeAt(position);
                ListNode newNode = new ListNode(data, FindNodeAt(position - 1));
                newNode.NextNode = prevNode;
            }
            length++;

        }

        public int GetIndexOf(T data)
        {
            int counter = 0;
            if (! head.Data.Equals(data)) 
            {
                ListNode currentNode = head;
                while(!currentNode.Data.Equals(data))
                {
                    (currentNode, counter) = FindNextNode(currentNode, counter);
                    if (currentNode.NextNode == null)
                    {
                        throw new Exception("Data not in Linked List");
                    }
                }
                
            }
            return counter;
        }

        private (ListNode, int) FindNextNode(ListNode currentNode, int position)
        {
            return (currentNode.NextNode, position + 1);
        }

        private ListNode FindNodeAt(int position)
        {
            int counter = 0;
            ListNode currentNode = head;
            if (position >= length || position < 0)
            {
                throw new Exception("Position is out of bounds");
            }
            else
            {
                while (counter != position)
                {
                    (currentNode, counter) = FindNextNode(currentNode, counter);
                }
            }
            return currentNode;
        }

        public T GetDataAt(int position)
        {
            return FindNodeAt(position).Data;
        }
    }
}
