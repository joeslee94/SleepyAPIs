
namespace RobustAPIConsumption
{
    partial class APIGetDeserializer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEndPoint = new System.Windows.Forms.TextBox();
            this.buttonGetRawJSON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSerializedJSON = new System.Windows.Forms.TextBox();
            this.buttonDeserializeJSON = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClearForm = new System.Windows.Forms.Button();
            this.textBoxDeserializedJSON = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL for API";
            // 
            // textBoxEndPoint
            // 
            this.textBoxEndPoint.Location = new System.Drawing.Point(85, 6);
            this.textBoxEndPoint.Name = "textBoxEndPoint";
            this.textBoxEndPoint.Size = new System.Drawing.Size(508, 23);
            this.textBoxEndPoint.TabIndex = 1;
            this.textBoxEndPoint.TextChanged += new System.EventHandler(this.textBoxEndPoint_TextChanged);
            // 
            // buttonGetRawJSON
            // 
            this.buttonGetRawJSON.Location = new System.Drawing.Point(85, 35);
            this.buttonGetRawJSON.Name = "buttonGetRawJSON";
            this.buttonGetRawJSON.Size = new System.Drawing.Size(508, 23);
            this.buttonGetRawJSON.TabIndex = 2;
            this.buttonGetRawJSON.Text = "Get Serialized JSON";
            this.buttonGetRawJSON.UseVisualStyleBackColor = true;
            this.buttonGetRawJSON.Click += new System.EventHandler(this.buttonGetRawJSON_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serialized\r\nJSON";
            // 
            // textBoxSerializedJSON
            // 
            this.textBoxSerializedJSON.Location = new System.Drawing.Point(85, 64);
            this.textBoxSerializedJSON.Multiline = true;
            this.textBoxSerializedJSON.Name = "textBoxSerializedJSON";
            this.textBoxSerializedJSON.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSerializedJSON.Size = new System.Drawing.Size(508, 190);
            this.textBoxSerializedJSON.TabIndex = 4;
            this.textBoxSerializedJSON.TextChanged += new System.EventHandler(this.textBoxSerializedJSON_TextChanged);
            // 
            // buttonDeserializeJSON
            // 
            this.buttonDeserializeJSON.Location = new System.Drawing.Point(85, 260);
            this.buttonDeserializeJSON.Name = "buttonDeserializeJSON";
            this.buttonDeserializeJSON.Size = new System.Drawing.Size(508, 23);
            this.buttonDeserializeJSON.TabIndex = 6;
            this.buttonDeserializeJSON.Text = "Deserialize JSON";
            this.buttonDeserializeJSON.UseVisualStyleBackColor = true;
            this.buttonDeserializeJSON.Click += new System.EventHandler(this.buttonDeserializeJSON_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Deserialized\r\nJSON\r\n";
            // 
            // buttonClearForm
            // 
            this.buttonClearForm.Location = new System.Drawing.Point(85, 480);
            this.buttonClearForm.Name = "buttonClearForm";
            this.buttonClearForm.Size = new System.Drawing.Size(508, 23);
            this.buttonClearForm.TabIndex = 8;
            this.buttonClearForm.Text = "Clear Form";
            this.buttonClearForm.UseVisualStyleBackColor = true;
            this.buttonClearForm.Click += new System.EventHandler(this.buttonClearForm_Click);
            // 
            // textBoxDeserializedJSON
            // 
            this.textBoxDeserializedJSON.Location = new System.Drawing.Point(85, 289);
            this.textBoxDeserializedJSON.Multiline = true;
            this.textBoxDeserializedJSON.Name = "textBoxDeserializedJSON";
            this.textBoxDeserializedJSON.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDeserializedJSON.Size = new System.Drawing.Size(508, 190);
            this.textBoxDeserializedJSON.TabIndex = 9;
            this.textBoxDeserializedJSON.TextChanged += new System.EventHandler(this.textBoxDeserializedJSON_TextChanged);
            // 
            // APIGetDeserializer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 504);
            this.Controls.Add(this.textBoxDeserializedJSON);
            this.Controls.Add(this.buttonClearForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDeserializeJSON);
            this.Controls.Add(this.textBoxSerializedJSON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGetRawJSON);
            this.Controls.Add(this.textBoxEndPoint);
            this.Controls.Add(this.label1);
            this.Name = "APIGetDeserializer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEndPoint;
        private System.Windows.Forms.Button buttonGetRawJSON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSerializedJSON;
        private System.Windows.Forms.Button buttonDeserializeJSON;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClearForm;
        private System.Windows.Forms.TextBox textBoxDeserializedJSON;
    }
}

