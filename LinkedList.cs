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

        }

        public int GetIndexOf(T data)
        {
            int counter = 0;
            if (! head.Data.Equals(data)) 
            {
                ListNode currentNode = head;
                while(currentNode.NextNode!=null && !currentNode.Data.Equals(data))
                {
                    (currentNode, counter) = FindNextNode(currentNode, counter);
                }
                if (currentNode.NextNode == null)
                {
                    throw new Exception("Data not in Linked List");
                }
            }
            return counter;
        }

        private (ListNode, int) FindNextNode(ListNode currentNode, int position)
        {
            return (currentNode.NextNode, position + 1);
        }

        public T GetDataFromPosition(int position)
        {
            if (position >= length)
            {
                throw new Exception("Position is not within bounds of the list");
            }
        }
    }
}
