
using System;

// CLASE NODO
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

    // INSERTAR
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

    // BUSCAR
    public bool Search(int key)
    {
        return SearchRec(Root, key);
    }

    private bool SearchRec(Node root, int key)
    {
        if (root == null)
            return false;

        if (root.Data == key)
            return true;

        return key < root.Data
            ? SearchRec(root.Left, key)
            : SearchRec(root.Right, key);
    }

    // RECORRIDO INORDEN
    public void InOrderTraversal()
    {
        InOrderRec(Root);
        Console.WriteLine();
    }

    private void InOrderRec(Node root)
    {
        if (root != null)
        {
            InOrderRec(root.Left);
            Console.Write(root.Data + " ");
            InOrderRec(root.Right);
        }
    }
}

// ELIMINACION DE NODOS
public class BSTDeletion
{
    public Node DeleteNode(Node root, int key)
    {
        if (root == null)
            return root;

        // BUSCAR EL NODO
        if (key < root.Data)
            root.Left = DeleteNode(root.Left, key);

        else if (key > root.Data)
            root.Right = DeleteNode(root.Right, key);

        else
        {
            // CASO 1: SIN HIJOS O CON UN SOLO HIJO
            if (root.Left == null)
                return root.Right;

            else if (root.Right == null)
                return root.Left;

            // CASO 2: DOS HIJOS
            // BUSCAR EL SUCESOR INORDEN
            root.Data = MinValue(root.Right);

            // ELIMINAR EL SUCESOR
            root.Right = DeleteNode(root.Right, root.Data);
        }

        return root;
    }

    // ENCONTRAR EL MENOR VALOR
    private int MinValue(Node root)
    {
        int minv = root.Data;

        while (root.Left != null)
        {
            minv = root.Left.Data;
            root = root.Left;
        }

        return minv;
    }
}

// PROGRAMA PRINCIPAL
public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree arbol = new BinarySearchTree();
        BSTDeletion eliminacion = new BSTDeletion();

        // INSERTAR ELEMENTOS
        arbol.Insert(50);
        arbol.Insert(30);
        arbol.Insert(70);
        arbol.Insert(20);
        arbol.Insert(40);
        arbol.Insert(60);
        arbol.Insert(80);

        // MOSTRAR ARBOL ORIGINAL
        Console.WriteLine("ARBOL BINARIO DE BUSQUEDA");
        Console.WriteLine("------------------------");

        Console.WriteLine("\nRecorrido original:");
        arbol.InOrderTraversal();

        // ELIMINAR UN NODO
        int valor = 30;

        Console.WriteLine("\nEliminando el nodo: " + valor);

        arbol.Root = eliminacion.DeleteNode(arbol.Root, valor);

        // MOSTRAR ARBOL DESPUES DE ELIMINAR
        Console.WriteLine("\nRecorrido despues de eliminar:");
        arbol.InOrderTraversal();

        // VERIFICAR SI EL NODO EXISTE
        Console.WriteLine("\nBuscar el nodo 30:");

        if (arbol.Search(30))
            Console.WriteLine("El nodo existe.");
        else
            Console.WriteLine("El nodo fue eliminado correctamente.");

        Console.WriteLine("\nPrograma finalizado.");
    }
}
