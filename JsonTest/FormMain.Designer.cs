namespace JsonTest {
   partial class FormMain {
      /// <summary>
      /// 필수 디자이너 변수입니다.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 사용 중인 모든 리소스를 정리합니다.
      /// </summary>
      /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 디자이너에서 생성한 코드

      /// <summary>
      /// 디자이너 지원에 필요한 메서드입니다. 
      /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
      /// </summary>
      private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxIndent = new System.Windows.Forms.CheckBox();
            this.cbxJsonType = new System.Windows.Forms.ComboBox();
            this.btnFromJson = new System.Windows.Forms.Button();
            this.btnToJson = new System.Windows.Forms.Button();
            this.btnNewObject = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSampleJson = new System.Windows.Forms.Button();
            this.tbxJson = new ICSharpCode.TextEditor.TextEditorControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.propertyGrid1.Size = new System.Drawing.Size(331, 530);
            this.propertyGrid1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxJson);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.tbxLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(334, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 634);
            this.panel1.TabIndex = 1;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 530);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(657, 3);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // tbxLog
            // 
            this.tbxLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbxLog.Font = new System.Drawing.Font("돋움체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxLog.Location = new System.Drawing.Point(0, 533);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxLog.Size = new System.Drawing.Size(657, 101);
            this.tbxLog.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Indent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Serializer";
            // 
            // cbxIndent
            // 
            this.cbxIndent.AutoSize = true;
            this.cbxIndent.Checked = true;
            this.cbxIndent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIndent.Location = new System.Drawing.Point(159, 61);
            this.cbxIndent.Name = "cbxIndent";
            this.cbxIndent.Size = new System.Drawing.Size(15, 14);
            this.cbxIndent.TabIndex = 3;
            this.cbxIndent.UseVisualStyleBackColor = true;
            // 
            // cbxJsonType
            // 
            this.cbxJsonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJsonType.FormattingEnabled = true;
            this.cbxJsonType.Location = new System.Drawing.Point(159, 34);
            this.cbxJsonType.Name = "cbxJsonType";
            this.cbxJsonType.Size = new System.Drawing.Size(100, 20);
            this.cbxJsonType.TabIndex = 2;
            // 
            // btnFromJson
            // 
            this.btnFromJson.Location = new System.Drawing.Point(3, 61);
            this.btnFromJson.Name = "btnFromJson";
            this.btnFromJson.Size = new System.Drawing.Size(86, 23);
            this.btnFromJson.TabIndex = 1;
            this.btnFromJson.Text = "From Json";
            this.btnFromJson.UseVisualStyleBackColor = true;
            this.btnFromJson.Click += new System.EventHandler(this.btnFromJson_Click);
            // 
            // btnToJson
            // 
            this.btnToJson.Location = new System.Drawing.Point(3, 32);
            this.btnToJson.Name = "btnToJson";
            this.btnToJson.Size = new System.Drawing.Size(86, 23);
            this.btnToJson.TabIndex = 1;
            this.btnToJson.Text = "To Json";
            this.btnToJson.UseVisualStyleBackColor = true;
            this.btnToJson.Click += new System.EventHandler(this.btnToJson_Click);
            // 
            // btnNewObject
            // 
            this.btnNewObject.Location = new System.Drawing.Point(3, 3);
            this.btnNewObject.Name = "btnNewObject";
            this.btnNewObject.Size = new System.Drawing.Size(86, 23);
            this.btnNewObject.TabIndex = 0;
            this.btnNewObject.Text = "New Object";
            this.btnNewObject.UseVisualStyleBackColor = true;
            this.btnNewObject.Click += new System.EventHandler(this.btnNewObject_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(331, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 634);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.propertyGrid1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 634);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSampleJson);
            this.panel3.Controls.Add(this.btnNewObject);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnToJson);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnFromJson);
            this.panel3.Controls.Add(this.cbxIndent);
            this.panel3.Controls.Add(this.cbxJsonType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 530);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 104);
            this.panel3.TabIndex = 0;
            // 
            // btnSampleJson
            // 
            this.btnSampleJson.Location = new System.Drawing.Point(225, 3);
            this.btnSampleJson.Name = "btnSampleJson";
            this.btnSampleJson.Size = new System.Drawing.Size(103, 23);
            this.btnSampleJson.TabIndex = 0;
            this.btnSampleJson.Text = "Sample Json";
            this.btnSampleJson.UseVisualStyleBackColor = true;
            this.btnSampleJson.Click += new System.EventHandler(this.btnSampleJson_Click);
            // 
            // tbxJson
            // 
            this.tbxJson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxJson.ConvertTabsToSpaces = true;
            this.tbxJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxJson.IsReadOnly = false;
            this.tbxJson.Location = new System.Drawing.Point(0, 0);
            this.tbxJson.Name = "tbxJson";
            this.tbxJson.Size = new System.Drawing.Size(657, 530);
            this.tbxJson.TabIndex = 7;
            this.tbxJson.Text = resources.GetString("tbxJson.Text");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 634);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Name = "FormMain";
            this.Text = "Json Serializer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.PropertyGrid propertyGrid1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Splitter splitter1;
      private System.Windows.Forms.Button btnFromJson;
      private System.Windows.Forms.Button btnToJson;
      private System.Windows.Forms.Button btnNewObject;
      private System.Windows.Forms.TextBox tbxLog;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.CheckBox cbxIndent;
      private System.Windows.Forms.ComboBox cbxJsonType;
      private System.Windows.Forms.Splitter splitter2;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Button btnSampleJson;
        private ICSharpCode.TextEditor.TextEditorControl tbxJson;
    }
}

