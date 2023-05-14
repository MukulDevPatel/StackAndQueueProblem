﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProblem
{
    public class LinkedList
    {
        public Node head;
        public void Push(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List",node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
