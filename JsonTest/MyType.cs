using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;

namespace JsonTest {
    public enum WeekDay {
        Sunday, Monday, Tuesday, WednesDay, Thursday, Friday, Saturday,
    }

    [DataContract]
    public class MyType {
        [DataMember(Order=1)] public int IntVal { get; set; }
        [DataMember(Order=2)] public float FloatVal { get; set; }
        [DataMember(Order=3)] public bool BoolVal { get; set; }
        [DataMember(Order=4)] public string StringVal { get; set; }
        [DataMember(Order=5)] public WeekDay WeekDay { get; set; }
        [DataMember(Order=6)] public Point Point { get; set; }
        [DataMember(Order=7)] public Color Color { get; set; }
        [DataMember(Order=8)] public int[] IntArr { get; set; }
        [DataMember(Order=9)] public string[] StringArr { get; set; }
        [DataMember(Order=10)] public SubClass SubClassVal { get; set; }
        [DataMember(Order=11)] public SubClass[] SubClassArr { get; set; }
        public MyType() {
            this.SubClassVal = new SubClass();
        }
    }

    [DataContract]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SubClass {
        [DataMember(Order=1)] public int IntVal { get; set; }
        [DataMember(Order=2)] public float FloatVal { get; set; }
        [DataMember(Order=3)] public bool BoolVal { get; set; }
        [DataMember(Order=4)] public string StringVal { get; set; }
        [DataMember(Order=5)] public WeekDay WeekDay { get; set; }
        [DataMember(Order=6)] public Point Point { get; set; }
        [DataMember(Order=7)] public Color Color { get; set; }
        [DataMember(Order=8)] public int[] IntArr { get; set; }
        public string[] StringArr { get; set; }
    }
}
