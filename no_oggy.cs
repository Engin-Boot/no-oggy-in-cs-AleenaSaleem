using System;
using System.Collections.Generic;

class NoOggyChecker
{
  static void RemoveOggy(List<string> names)
  {
    foreach (var name in names.ToList())
    {
        if(name.StartsWith("oggy")) {
             if(name.Delete) names.Remove(name);
        
        }
    }
  }
  static bool OggyIsRemoved(List<string> names)
  {
    return names.Find(x => x.Contains("oggy")) == null;
  }
  static int Main()
  {
    var names = new List<string>
      { "nobita", "bheem", "oggy", "oggy cockroach", "ninja" };
    RemoveOggy(names);
    if(OggyIsRemoved(names)) {
      Console.WriteLine("Passed!");
      return 0;
    } else {
      Console.WriteLine("Failed!!");
      return 1;
    }
  }
}
