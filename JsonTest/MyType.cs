using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTest {
   public enum WeekDay {
      Sunday, Monday, Tuesday, WednesDay, Thursday, Friday, Saturday,
   }

   public class MyType {
      public int IntVal { get; set; }
      public float FloatVal { get; set; }
      public bool BoolVal { get; set; }
      public string StringVal { get; set; }
      public WeekDay WeekDay { get; set; }
      public int[] IntArr { get; set; }
      public string[] StringArr { get; set; }
      public SubClass SubClassVal { get; set; }
      public SubClass[] SubClassArr { get; set; }
      public MyType() {
         this.SubClassVal = new SubClass();
      }
   }

   [TypeConverter(typeof(ExpandableObjectConverter))]
   public class SubClass {
      public int IntVal { get; set; }
      public float FloatVal { get; set; }
      public bool BoolVal { get; set; }
      public string StringVal { get; set; }
      public WeekDay WeekDay { get; set; }
      public int[] IntArr { get; set; }
      public string[] StringArr { get; set; }
   }
}
