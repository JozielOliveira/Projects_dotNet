using System;
using System.Collections.Generic;


namespace Consumer.Domain.Entities
{
  public class Immobile 
  {
    public Immobile() {}
    public Immobile(int id, String nameOwner, DateTime neighborhood, DateTime number, int identification, double city, double state)
    {
      this.id = id;
      this.nameOwner = nameOwner;
      this.identification = identification;
      this.city = city;
      this.state = state;
      this.neighborhood = neighborhood;
      this.number = number;
    }

    public int id { get; set; }
    public String nameOwner { get; set; }
    public int identification { get; set; }
    public double state { get; set; }
    public double city { get; set; }
    public DateTime neighborhood { get; set; }
    public DateTime number { get; set; }
    public List<Electric> electrics { get; set; }
  }
}