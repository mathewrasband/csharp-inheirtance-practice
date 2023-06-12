// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm{

    //Properties
    public string Essence
      { get; private set; }

    public bool IsStrong
      { get; private set; }

    public string Caster
      { get; private set; }

    //Constructor
    public Storm(string essence, bool isStrong, string caster)
    {
      this.Essence = essence;
      this.IsStrong = isStrong;
      this.Caster = caster;
    }

    //Methods
    public string Announce(){
      string stormStrength;
      if(this.IsStrong){
        stormStrength = "strong";
      }else{
        stormStrength = "weak";
      }
      return $"{Caster} cast a {stormStrength} {Essence} storm!";
    }
  }
}
