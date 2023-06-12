// Pupil.cs
using System;

namespace MagicalInheritance
{
  class Pupil{

    //Properties
    public string Title
      { get; protected set; }

    //Constructor
    public Pupil(string title){
      this.Title = title;
    }

    //Methods
    public virtual Storm CastWindStorm(){
      return new Storm("wind", false, this.Title);
    }
  }
}
