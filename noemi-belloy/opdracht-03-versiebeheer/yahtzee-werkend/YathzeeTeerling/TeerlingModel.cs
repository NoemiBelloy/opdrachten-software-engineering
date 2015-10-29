using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YathzeeTeerling
{
  public class TeerlingModel
  {
    private int _aantalOgen; // aantal ogen per teerling
    private bool isVast; // om teerlingen vast te zetten
    private bool toonWerpKnop = false; // om werp knoppen te verbergen

    //waarde van aantal ogen opvragen
    public int Aantalogen 
    {
      get
      {
        return _aantalOgen;
      }
      set
      {
        _aantalOgen = value;
      }
    }
    
    //waarde van isVast opvragen
    public bool Vast
    {
      get
      {
        return isVast;
      }
      set
      {
        isVast = value;
      }
    }
    
    //waarde van de toonWerpKnop opvragen
    public bool Werp
    {
      get
      {
        return toonWerpKnop;
      }
      set
      {
        toonWerpKnop = value;
      }
    }
  }
}