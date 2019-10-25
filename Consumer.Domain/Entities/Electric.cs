using System;

namespace Consumer.Domain.Entities
{
  public class Electric 
  {
    public Electric() {}
    public Electric(int id,DateTime readDate, DateTime datePag, int readNum, double kwConsumed, double mediaConsumed, double value)
    {
      this.id = id;
      this.readNum = readNum;
      this.readDate = readDate;
      this.datePag = datePag;
      this.kwConsumed = kwConsumed;
      this.mediaConsumed = mediaConsumed;
      this.value = value;
    }

    public int id { get; set; }
    public DateTime readDate { get; set; }
    public int readNum { get; set; }
    public double kwConsumed { get; set; }
    public double value { get; set; }
    public DateTime datePag { get; set; }
    public double mediaConsumed { get; set; }
  }
}