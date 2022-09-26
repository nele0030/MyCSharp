using System;

namespace Dealership.Models 
{
  
  public class Truck
  {
    private string _model;
    private uint _load;
    private uint _price;
    private uint _year;

    public Truck(string model, uint load, uint price, uint year)
    {
      _model = model;
      _load = load;
      _price = price;
      _year = year;
    }

    public string GetModel()
    {
      return _model;
    }

    public uint GetLoad()
    {
      return _load;
    }

    public uint GetPrice()
    {
      return _price;
    }

    public uint GetYear()
    {
      return _year;
    }
    public bool WorthBuying(uint maxPrice)
    {
      return (_price <= maxPrice);
    }
  }
}



