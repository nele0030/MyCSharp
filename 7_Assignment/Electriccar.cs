using System;

namespace Dealership.Models 
{
  
  public class ElectricCar
  {
    private string _model;
    private uint _batterySize;
    private uint _price;
    private uint _year;

    public ElectricCar(string model, uint batterySize, uint price, uint year)
    {
      _model = model;
      _batterySize = batterySize;
      _price = price;
      _year = year;
    }

    public string GetModel()
    {
      return _model;
    }

    public uint GetBatterySize()
    {
      return _batterySize;
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



