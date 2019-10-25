using System;
using System.Collections.Generic;

namespace Consumer.Domain.Entities
{
  public class ViewElectric 
  {
    public ViewElectric() {}
    public ViewElectric(List<Electric> electrics, Electric maxConsumed, Electric minConsumed)
    {
      this.electrics = electrics;
      this.maxConsumed = maxConsumed;
      this.minConsumed = minConsumed;
    }

    public List<Electric> electrics { get; set; }
    public Electric maxConsumed { get; set; }
    public Electric minConsumed { get; set; }
  }
}