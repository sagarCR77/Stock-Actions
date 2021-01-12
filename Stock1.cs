using System;

public class Stock1 // Stock class constructer
{
private int _quantityOnHand;
private string _name;


public Stock1(string name, int initialLevel)
{
    _name = name;
    _quantityOnHand = initialLevel;
}

public bool AddStock1(int quantityAdded) // add stock function
{
    if (quantityAdded >0)
    {
        _quantityOnHand = _quantityOnHand + quantityAdded; 
        return true;
    }
    else
    {
        return false;
        
    } 

}

public bool RemoveStock1(int quantityRemoved) // remove stock function
{
    if(quantityRemoved>0)
    {
        _quantityOnHand = _quantityOnHand - quantityRemoved; 
        return true;
    }
    else
    {
        return false;
    }
    
}

public string Name 
{
    get { return _name; } // read
    set { _name = value; } // read and write
}

public int QuantityOnHand 
{
    get { return _quantityOnHand; }
    private set { _quantityOnHand = value; } 
}

public void PrintSummary() 
{
    Console.WriteLine($"{Name}: {QuantityOnHand}"); // Print
}
}

    
