#region çift yönlü listede aradan eleman silme
//using System;

//public class Node
//{
//    public int Data;
//    public Node Next;
//    public Node Prev;
//}

//public class DoublyLinkedList
//{
//    private Node head;

//    public void AddLast(int data)
//    {
//        Node newNode = new Node { Data = data };

//        if (head == null)
//        {
//            head = newNode;
//            return;
//        }

//        Node current = head;
//        while (current.Next != null)
//        {
//            current = current.Next;
//        }

//        current.Next = newNode;
//        newNode.Prev = current;
//    }

//    public void Delete(int data)
//    {
//        Node current = head;

//        while (current != null)
//        {
//            if (current.Data == data)
//            {
//                if (current.Prev != null)
//                {
//                    current.Prev.Next = current.Next;
//                }
//                else
//                {
//                    head = current.Next; // Eğer baş düğüm siliniyorsa
//                }

//                if (current.Next != null)
//                {
//                    current.Next.Prev = current.Prev;
//                }
//                Console.WriteLine($"Eleman ({data}) listeden silindi.");
//                return;
//            }
//            current = current.Next;
//        }

//        Console.WriteLine($"Eleman ({data}) listede bulunamadı.");
//    }

//    public void PrintList()
//    {
//        Node current = head;
//        while (current != null)
//        {
//            Console.Write(current.Data + " ");
//            current = current.Next;
//        }
//        Console.WriteLine();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        DoublyLinkedList list = new DoublyLinkedList();

//        Console.WriteLine("Lütfen 5 sayı giriniz:");
//        for (int i = 0; i < 5; i++)
//        {
//            Console.Write($"Sayı {i + 1}: ");
//            int num = int.Parse(Console.ReadLine());
//            list.AddLast(num);
//        }

//        Console.WriteLine("Liste:");
//        list.PrintList();

//        Console.Write("Silmek istediğiniz sayıyı giriniz: ");
//        int deleteNum = int.Parse(Console.ReadLine());
//        list.Delete(deleteNum);

//        Console.WriteLine("Güncellenmiş liste:");
//        list.PrintList();
//    }
//}
#endregion
#region stack yapısı
//using System.ComponentModel.Design;
//using System.Runtime.CompilerServices;
//using System.Security.Cryptography.X509Certificates;

//namespace ConsoleApp9
//{
//    class Program
//    {
//        public static int sayi { get; private set; }
//        public static int sayi1 { get; private set; }

//        static void Main(string[] args)
//        {
//            StackYapisi stc = new StackYapisi();
//            int secim = menu();
//            while (secim != 0)
//            {
//                switch (secim)
//                {
//                    case 1:
//                        Console.WriteLine("Sayı:"); sayi = int.Parse(Console.ReadLine());
//                        stc.push(sayi1); break;

//                    case 2:
//                        sayi = stc.pop(); break;
//                        if (sayi != -1)
//                        {
//                            Console.WriteLine("çıkan sayı:+sayi");
//                        }
//                        else

//                            Console.WriteLine("stack boştu");
//                        break;
//                    case3: stc.print(); break;
//                    case4: stc.pop(); break;
//                    case 0: stc.print(); break;
//                    default:
//                        Console.WriteLine("hatalı seçim");
//                        break;
//                }
//                secim = menu();

//            }
//            Console.WriteLine("program sonlandırıldı");
//        }

//        private static int menu()
//        {
//            int secim;
//            Console.WriteLine("1-push");
//            Console.WriteLine("2-pop");
//            Console.WriteLine("3-print");
//            Console.WriteLine("4-top");
//            Console.WriteLine("0-exit");
//            secim = int.Parse(Console.ReadLine());
//            return secim;
//        }
//    }
//}
//class Node
//{
//    public int data;
//    public Node next;
//    public Node(int data)
//    {
//        this.data = data;
//        next = null;
//    }
//}
//class StackYapisi
//{
//    Node top;

//    public StackYapisi()
//    {
//        top = null;
//    }
//    public void push(int data)
//    {
//        Node eleman = new Node(data);
//        if (top == null)
//        {
//            top = eleman;
//            Console.WriteLine("Stack yazısı oluşturuldu ilk eleman stacke girdi");
//        }
//        else
//        {
//            eleman.next = top;
//            top = eleman;
//            Console.WriteLine("eleman eklendi");
//        }
//    }
//    public int pop()
//    {
//        if (top == null)
//        {
//            Console.WriteLine("stack boş ");
//            return -1;
//        }
//        else
//        {
//            int sayi = top.data;
//            top = top.next;
//            Console.WriteLine(sayi + "stackten çıkartıldı");
//            return sayi;
//        }
//    }
//    public void print()
//    {
//        if (top == null)
//        {
//            Console.WriteLine("stack boş");
//        }
//        else
//        {
//            Node temp = top;
//            Console.Clear();
//            while (temp != null)
//            {
//                Console.WriteLine(temp.data);
//                temp = temp.next;
//            }
//        }



//    }
//    public void topPrint()
//    {
//        if (top == null)
//        {
//            Console.WriteLine("stack boş");
//        }
//        else
//        {
//            Console.WriteLine(top.data);
//        }
//    }


//}


#endregion
#region agaç veri yapısı
//using System;

//class Node
//{
//    public int Data;
//    public Node Left, Right;

//    public Node(int data)
//    {
//        Data = data;
//        Left = Right = null;
//    }
//}

//class BinaryTree
//{
//    public Node Root;

//    public BinaryTree()
//    {
//        Root = null;
//    }

//    public void PreOrder(Node node)
//    {
//        if (node == null)
//            return;

//        Console.Write(node.Data + " "); // Önce root
//        PreOrder(node.Left);           // Sol alt ağaç
//        PreOrder(node.Right);          // Sağ alt ağaç
//    }

//    public void InOrder(Node node)
//    {
//        if (node == null)
//            return;

//        InOrder(node.Left);            // Sol alt ağaç
//        Console.Write(node.Data + " "); // Root
//        InOrder(node.Right);           // Sağ alt ağaç
//    }

//    public void PostOrder(Node node)
//    {
//        if (node == null)
//            return;

//        PostOrder(node.Left);          // Sol alt ağaç
//        PostOrder(node.Right);         // Sağ alt ağaç
//        Console.Write(node.Data + " "); // Son olarak root
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        BinaryTree tree = new BinaryTree();

//        // Basit bir ağaç oluşturuyoruz
//        tree.Root = new Node(1);
//        tree.Root.Left = new Node(2);
//        tree.Root.Right = new Node(3);
//        tree.Root.Left.Left = new Node(4);
//        tree.Root.Left.Right = new Node(5);

//        Console.WriteLine("PreOrder Traversal:");
//        tree.PreOrder(tree.Root);
//        Console.WriteLine();

//        Console.WriteLine("InOrder Traversal:");
//        tree.InOrder(tree.Root);
//        Console.WriteLine();

//        Console.WriteLine("PostOrder Traversal:");
//        tree.PostOrder(tree.Root);
//        Console.WriteLine();
//    }
//}

#endregion
#region özel tablo yapısı
//using System;
//using System.Collections.Generic;

//class Table
//{
//    private List<List<string>> rows; // Tablo satırlarını saklamak için
//    private int columnCount; // Sütun sayısı

//    public Table(int columns)
//    {
//        if (columns <= 0)
//        {
//            throw new ArgumentException("Sütun sayısı 1 veya daha büyük olmalıdır.");
//        }

//        columnCount = columns;
//        rows = new List<List<string>>();
//    }

//    // Yeni bir satır ekleme
//    public void AddRow(List<string> row)
//    {
//        if (row.Count != columnCount)
//        {
//            throw new ArgumentException($"Satır {columnCount} sütun içermelidir.");
//        }

//        rows.Add(row);
//    }

//    // Tabloyu ekrana yazdırma
//    public void Display()
//    {
//        Console.WriteLine("\nTablo:");
//        foreach (var row in rows)
//        {
//            Console.WriteLine(string.Join(" | ", row));
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Tablo için sütun sayısını girin: ");
//        int columns = int.Parse(Console.ReadLine());

//        Table table = new Table(columns);

//        Console.Write("Kaç satır eklemek istiyorsunuz? ");
//        int rowsCount = int.Parse(Console.ReadLine());

//        for (int i = 0; i < rowsCount; i++)
//        {
//            Console.WriteLine($"\n{(i + 1)}. satır için değerleri girin (her sütun arasında bir boşluk olacak şekilde):");

//            List<string> row = new List<string>();
//            for (int j = 0; j < columns; j++)
//            {
//                Console.Write($"Sütun {j + 1}: ");
//                row.Add(Console.ReadLine());
//            }

//            table.AddRow(row); // Kullanıcıdan alınan verileri tabloya ekler
//        }

//        table.Display(); // Tabloyu ekrana yazdırır
//    }
//}
#endregion