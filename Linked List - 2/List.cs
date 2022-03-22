using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List___2
{
    public class List
    {
        public Node head;

        public List()
        {
            head = null;
        }

        public void sonaEkle(int data)
        {
            Node eleman = new Node(data);

            if(head == null)
            {
                head = eleman;
                Console.WriteLine("Liste oluşturuldu, ilk düğüm eklendi");
            }
            else
            {
                Node temp = head;

                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = eleman;
                Console.WriteLine("Sona eleman eklendi");
            }
        }

        public void basaEkle(int data)
        {
            Node eleman = new Node(data);

            if(head == null)
            {
                head = eleman;
            }
            else
            {
                eleman.next = head;
                head = eleman;

                Console.WriteLine("Başa eleman eklendi");
            }
        }

        public void yazdir()
        {
            if(head == null)
            {
                Console.WriteLine("Yazdırılacak bir değer yok");
            }
            else
            {
                Node eleman = head;
                Console.Write("Baş -> ");
                while (eleman.next != null)
                {
                    Console.Write(eleman.data + " -> ");
                    eleman = eleman.next;
                }
                Console.Write(eleman.data + " son.");
            }
        }

        public void bastanSil()
        {
            if(head == null)
            {
                Console.WriteLine("Liste boş");
            }
            else
            {
                head = head.next;   // Baştaki düğüm silindi
                Console.WriteLine("Baştaki eleman silindi");
            }
        }

        public void sondanSil()
        {
            Node temp = head;
            Node temp2 = temp;
            if (head == null)
            {
                Console.WriteLine("Liste boş");
            }
            else if (head.next == null)
            {
                head = null;
                Console.WriteLine("Sondaki eleman silindi");
            }
            else
            {
                while(temp.next != null)
                {
                    temp2 = temp;
                    temp = temp.next;
                }
                temp2.next = null;
                Console.WriteLine("Sondaki eleman silindi");
            }
        }
    }
}
