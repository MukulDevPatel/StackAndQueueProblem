using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProblem
{
    public class LinkedList
    {
        public Node head;
        public void Enqueue(int data)
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
        public void Dequeue()
        {
            while (this.head != null)
            {
                Console.WriteLine("Queue value {0} is removed", this.head.data);
                this.head = this.head.next;
            }
        }
    }
}
