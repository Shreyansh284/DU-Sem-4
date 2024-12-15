using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2;

class Furniture
{
    public string material;
    public double price;

    public Furniture(string material, double price)
    {
        this.material = material;
        this.price = price;
    }

    public void DisplayFurnitureDetails()
    {
        Console.WriteLine("Material: " + material);
        Console.WriteLine("Price: " + price);
    }
}

class Table : Furniture
{
    public double height;
    public double surface_area;

    public Table(string material, double price, double height, double surface_area)
        : base(material, price)
    {
        this.height = height;
        this.surface_area = surface_area;
    }

    public void DisplayTableDetails()
    {
        DisplayFurnitureDetails();
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Surface Area: " + surface_area);
    }
}
