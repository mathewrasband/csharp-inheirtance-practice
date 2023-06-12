// Archmage.cs
using System;

namespace MagicalInheritance
{
  class Archmage: Mage{

    //Constructor
    public Archmage(string title): base(title){
      this.Title = title;
    }

    //Methods
    public override Storm CastWindStorm(){
      return new Storm("wind", true, this.Title);
    }

    public override Storm CastRainStorm(){
      return new Storm("rain", true, this.Title);
    }

    public Storm CastLightningStorm(){
      return new Storm("lightning", true, this.Title);
    }
    
  }
}
