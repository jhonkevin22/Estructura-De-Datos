
using System;
using System.Collections.Generic;

// NODO DEL ARBOL
public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

// ARBOL BINARIO DE BUSQUEDA
public class BinarySearchTree
{
    public Node Root;

    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }
}

// RECORRIDOS DEL ARBOL
public class TreeTraversals
{
    // 1. PREORDEN (Raiz, Izquierda, Derecha)
    public void PreOrder(Node node)
    {
        if (node == null) return;

        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // 2. INORDEN (Izquierda, Raiz, Derecha)
    public void InOrder(Node node)
    {
        if (node == null) return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // 3. POSORDEN (Izquierda, Derecha, Raiz)
    public void PostOrder(Node node)
    {
        if (node == null) return;

        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }

    // 4. BFS POR NIVELES
    public void LevelOrder(Node root)
    {
        if (root == null) return;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();

            Console.Write(current.Data + " ");

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
    }
}

// PROGRAMA PRINCIPAL
public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree arbol = new BinarySearchTree();
        TreeTraversals recorrido = new TreeTraversals();

        // INSERTAR ELEMENTOS
        arbol.Insert(50);
        arbol.Insert(30);
        arbol.Insert(70);
        arbol.Insert(20);
        arbol.Insert(40);
        arbol.Insert(60);
        arbol.Insert(80);

        // MOSTRAR ESTRUCTURA DEL ARBOL
        Console.WriteLine("ARBOL BINARIO DE BUSQUEDA");
        Console.WriteLine("------------------------");

        // RECORRIDO PREORDEN
        Console.WriteLine("\n1. RECORRIDO PREORDEN:");
        recorrido.PreOrder(arbol.Root);

        // RECORRIDO INORDEN
        Console.WriteLine("\n\n2. RECORRIDO INORDEN:");
        recorrido.InOrder(arbol.Root);

        // RECORRIDO POSORDEN
        Console.WriteLine("\n\n3. RECORRIDO POSORDEN:");
        recorrido.PostOrder(arbol.Root);

        // RECORRIDO POR NIVELES
        Console.WriteLine("\n\n4. RECORRIDO POR NIVELES (BFS):");
        recorrido.LevelOrder(arbol.Root);

        Console.WriteLine("\n\nPrograma finalizado.");
    }
}
