using System;

namespace Swapi.Models
{
  public interface IEntry
  {
    DateTime Created { get; set; }
    DateTime Edited { get; set; }
    string Url { get; set; }
  }
}