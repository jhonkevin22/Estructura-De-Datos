
using System;

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

public class BinarySearchTree 
{
    public Node Root;

    // Inserción Recursiva
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

    // Búsqueda
    public bool Search(int key) 
    {
        return SearchRec(Root, key);
    }

    private bool SearchRec(Node root, int key) 
    {
        if (root == null) return false;
        if (root.Data == key) return true;
        
        return key < root.Data
             ? SearchRec(root.Left, key)
             : SearchRec(root.Right, key);
    }

    // Recorrido Inorden
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

// PROGRAMA PRINCIPAL
public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree arbol = new BinarySearchTree();

        // Insertar elementos
        arbol.Insert(50);
        arbol.Insert(30);
        arbol.Insert(70);
        arbol.Insert(20);
        arbol.Insert(40);
        arbol.Insert(60);
        arbol.Insert(80);

        // Mostrar recorrido
        Console.WriteLine("ARBOL BINARIO DE BUSQUEDA");
        Console.WriteLine("-------------------------");

        Console.WriteLine("Recorrido Inorden:");
        arbol.InOrderTraversal();

        // Buscar elementos
        Console.WriteLine();
        Console.WriteLine("BUSQUEDA DE ELEMENTOS");

        int numero = 40;

        if (arbol.Search(numero))
            Console.WriteLine("El numero " + numero + " SI existe en el arbol.");
        else
            Console.WriteLine("El numero " + numero + " NO existe en el arbol.");

        numero = 90;

        if (arbol.Search(numero))
            Console.WriteLine("El numero " + numero + " SI existe en el arbol.");
        else
            Console.WriteLine("El numero " + numero + " NO existe en el arbol.");

        Console.WriteLine();
        Console.WriteLine("Programa finalizado.");
    }
}
