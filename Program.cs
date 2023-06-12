using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
        Storm testS = new Storm("wind", false, "Zul'rajas");
        Console.WriteLine(testS.Announce());  

        Pupil testP = new Pupil("Mezil-kree");
        Console.WriteLine(testP.CastWindStorm().Announce());  

        Mage testM = new Mage("Gul'dan");
        Console.WriteLine(testM.CastWindStorm().Announce()); 
        Console.WriteLine(testM.CastRainStorm().Announce());  

        Archmage testA = new Archmage("Nielas Aran");
        Console.WriteLine(testA.CastWindStorm().Announce()); 
        Console.WriteLine(testA.CastRainStorm().Announce());  
        Console.WriteLine(testA.CastLightningStorm().Announce());  
          
    }
  }
}