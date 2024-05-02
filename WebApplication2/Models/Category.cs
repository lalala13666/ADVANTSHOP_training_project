using System;

namespace WebApplication2.Models;

public class Category
{
    public string ID { get; set; }
    
    public string Name { get; set; }
    
    public int Sort { get; set; }
    
    public string Parent { get; set; }
    
    public DateTime dateCreate { get; set; }
    
    public DateTime dateChange { get; set; }
    
    public string LinkToImage { get; set; }
}