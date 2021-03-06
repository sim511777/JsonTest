﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Xml.Serialization;
using ICSharpCode.TextEditor.Document;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonTest {
    public enum JsonSerializerType {
        DataContractJsonSerializer,
        JavaScriptSerializer,
        JsonDotNet,
        Xml,
        JsonSerializer,
    }

    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
            this.tbxJson.Text = JsonTest.Properties.Resources.Json0;
            this.tbxJson.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("JavaScript");
            this.cbxJsonType.Items.AddRange(Enum.GetNames(typeof(JsonSerializerType)));
            this.cbxJsonType.SelectedIndex = 0;
        }

        private void btnNewObject_Click(object sender, EventArgs e) {
            this.propertyGrid1.SelectedObject = new MyType();
        }

        private string ObjectToJson(object obj, JsonSerializerType serializerType, bool indent) {
            if (serializerType == JsonSerializerType.DataContractJsonSerializer) {
                var ser = new DataContractJsonSerializer(obj.GetType());
                using (var ms = new MemoryStream())
                using (var writer = JsonReaderWriterFactory.CreateJsonWriter(ms, Encoding.UTF8, true, indent)) {
                    ser.WriteObject(writer, obj);
                    writer.Flush();
                    var json = Encoding.UTF8.GetString(ms.ToArray());
                    return json;
                }
            } else if (serializerType == JsonSerializerType.JavaScriptSerializer) {
                var jss = new JavaScriptSerializer();
                var json = jss.Serialize(obj);
                return json;
            } else if (serializerType == JsonSerializerType.JsonDotNet) {
                var settings = new JsonSerializerSettings {
                    TypeNameHandling = TypeNameHandling.Auto
                };
                var json = JsonConvert.SerializeObject(obj, indent ? Formatting.Indented : Formatting.None, settings);
                return json;
            } else if (serializerType == JsonSerializerType.Xml) {
                var ser = new XmlSerializer(obj.GetType());
                using (var ms = new MemoryStream()) {
                    ser.Serialize(ms, obj);
                    var json = Encoding.UTF8.GetString(ms.ToArray());
                    return json;
                }
            } else if (serializerType == JsonSerializerType.JsonSerializer) {
                var opt = new JsonSerializerOptions();
                opt.WriteIndented = indent;
                var bytes = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(obj, opt);
                return Encoding.UTF8.GetString(bytes);
            } else {
                throw new Exception("Invalid Serializer");
            }
        }

        private T JsonToObject<T>(string json, JsonSerializerType serializerType) {
            if (serializerType == JsonSerializerType.DataContractJsonSerializer) {
                var ser = new DataContractJsonSerializer(typeof(T));
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json))) {
                    var obj = (T)ser.ReadObject(ms);
                    return obj;
                }
            } else if (serializerType == JsonSerializerType.JavaScriptSerializer) {
                var jss = new JavaScriptSerializer();
                var obj = jss.Deserialize<T>(json);
                return obj;
            } else if (serializerType == JsonSerializerType.JsonDotNet) {
                JsonSerializerSettings a = new JsonSerializerSettings();
                var obj = JsonConvert.DeserializeObject<T>(json);
                return obj;
            } else if (serializerType == JsonSerializerType.Xml) {
                var ser = new XmlSerializer(typeof(T));
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json))) {
                    var obj = (T)ser.Deserialize(ms);
                    return obj;
                }
            } else if (serializerType == JsonSerializerType.JsonSerializer) {
                var obj = System.Text.Json.JsonSerializer.Deserialize<T>(json);
                return obj;
            } else {
                throw new Exception("Invalid Serializer");
            }
        }

        private void Log(string text) {
            this.tbxLog.AppendText(text + Environment.NewLine);
        }

        private void btnToJson_Click(object sender, EventArgs e) {
            var jsonType = (JsonSerializerType)this.cbxJsonType.SelectedIndex;
            var indent = this.cbxIndent.Checked;
            this.Log(string.Format("Object -> Json, JsonType: {0}, Indent: {1}", jsonType, indent));
            try {
                var obj = this.propertyGrid1.SelectedObject;
                var json = this.ObjectToJson(obj, jsonType, indent);
                this.tbxJson.Text = json;
                if (jsonType == JsonSerializerType.Xml)
                    this.tbxJson.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("XML");
                else
                    this.tbxJson.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("JavaScript");
            } catch (Exception ex) {
                this.Log(ex.ToString());
            }
            this.Log("========");
        }

        private void btnFromJson_Click(object sender, EventArgs e) {
            var jsonType = (JsonSerializerType)this.cbxJsonType.SelectedIndex;
            var indent = this.cbxIndent.Checked;
            this.Log(string.Format("Jsont -> Object, JsonType: {0}", jsonType));
            try {
                var json = this.tbxJson.Text;
                var obj = this.JsonToObject<MyType>(json, jsonType);
                this.propertyGrid1.SelectedObject = obj;
            } catch (Exception ex) {
                this.Log(ex.ToString());
            }
            this.tbxLog.AppendText("========");
        }

        private void btnSampleJson_Click(object sender, EventArgs e) {
            this.tbxJson.Text = Properties.Resources.Json0;
        }
    }
}
