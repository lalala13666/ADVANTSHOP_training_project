using System;
using System.Data.SqlTypes;

namespace WebApplication2.Models;

public class Product
{
    public string ID { get; set; }
    
    public string Name { get; set; }

    public int Quantity { get; set; }
    
    public decimal Cost { get; set; }
    
    public int QuantitySold { get; set; }
    
    public string Category { get; set; }
    
    public string Comment { get; set; }
    
    public decimal Grade { get; set; }
    
    public string LinkToImage { get; set; }
    
    public DateTime DateOfCreate { get; set; }
    
    public DateTime DateOfChange { get; set; }
}