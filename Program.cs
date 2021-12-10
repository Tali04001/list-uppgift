using System;
using System.Collections.Generic;
using System.Linq;
class Demo {
   static void Main() {
      List<long> list = new List<long> { 11, 5, 3, 3, 6, 12 };
      foreach(long ele in list){
         Console.WriteLine(ele);
      }

      // getting largest element
      long största = list.AsQueryable().Max();

      // getting smallest element
      long minsta = list.AsQueryable().Min();

      Console.WriteLine("Smallest number = {0}", minsta);
      Console.WriteLine("Largest number = {0}", största);
   }
}
