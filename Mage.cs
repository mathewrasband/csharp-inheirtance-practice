// Mage.cs
using System;

namespace MagicalInheritance
{
  class Mage: Pupil{

    //Constructor
    public Mage(string title): base(title){
      this.Title = title;
    }

    //Methods
    public virtual Storm CastRainStorm(){
      return new Storm("rain", false, this.Title);
    }
  }
}
