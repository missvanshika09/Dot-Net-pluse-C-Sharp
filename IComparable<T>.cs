//IComparable<T>
// Implement IComparable<T>. 
using System;
using System.Collections.Generic;
// Implement the generic IComparable<T> interface. 
class Inventory : IComparable<Inventory> // <differnt name is also right> generic obj
{
    string name; //private
    double cost;
    int onhand;

    public Inventory(string n, double c, int h)//Constructor 
    {
        name = n;
        cost = c;
        onhand = h;
    }

    public override string ToString() //this is get called 
    {
        return
 String.Format("{0,-10}Cost: {1,6:C}  On hand: {2}", name, cost, onhand);//just for formating the data fr better readiblity - means left align
    }
    // Implement the IComparable<T> interface. 
    public int CompareTo(Inventory obj)
    {
        return name.CompareTo(obj.name);
    }
}

//Main Entry Point
class GenericIComparableDemo
{
    static void Main()
    {
        List<Inventory> inv = new List<Inventory>();

        // Add elements to the list 
        inv.Add(new Inventory("Pliers", 5.95, 3));
        inv.Add(new Inventory("Wrenches", 8.29, 2));
        inv.Add(new Inventory("Hammers", 3.50, 4));
        inv.Add(new Inventory("Drills", 19.88, 8));

        Console.WriteLine("Inventory list before sorting:");
        foreach (Inventory i in inv)
        {
            Console.WriteLine("   " + i);
        }
        Console.WriteLine();

        // Sort the list. 
        inv.Sort();

        Console.WriteLine("Inventory list after sorting:");
        foreach (Inventory i in inv)
        {
            Console.WriteLine("   " + i);
        }
        Console.WriteLine("{0,6} {1,6}", "Vita", "Adity");// __ 2 space before vita as block of 6 is made as per ask
        //  Console.WriteLine("{0,-6} {1,6}", "Vita", "Adity");// this will leave __ 2 space in last of block 6 of the vita
    }
}
