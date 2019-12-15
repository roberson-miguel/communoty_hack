using System;
using System.Collections.Generic;
using System.Text;

namespace AhGarra.Domain.Entities
{
  public class Card : IdDescriptionBase
  {
    public string Title { get; set; }

    public int Order { get; set; }
  }
}
