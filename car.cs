using System;

namespace Dealership.Models 
{
  
  public class Car
  {
    private string _model;
    private uint _price;
    private uint _year;

    public Car(string model, uint price, uint year)
    {
      _model = model;
      _price = price;
      _year = year;
    }

    public string GetModel()
    {
      return _model;
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



