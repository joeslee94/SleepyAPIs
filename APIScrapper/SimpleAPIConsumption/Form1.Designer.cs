
namespace SimpleAPIConsumption
{
    partial class Form1
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
            this.textBoxEndpointInput = new System.Windows.Forms.TextBox();
            this.textBoxResultJSONList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGetResult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDeserializedResults = new System.Windows.Forms.TextBox();
            this.buttonDeserializeResults = new System.Windows.Forms.Button();
            this.buttonClearDeserializedResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEndpointInput
            // 
            this.textBoxEndpointInput.Location = new System.Drawing.Point(109, 6);
            this.textBoxEndpointInput.Name = "textBoxEndpointInput";
            this.textBoxEndpointInput.Size = new System.Drawing.Size(679, 23);
            this.textBoxEndpointInput.TabIndex = 0;
            // 
            // textBoxResultJSONList
            // 
            this.textBoxResultJSONList.Location = new System.Drawing.Point(109, 58);
            this.textBoxResultJSONList.Multiline = true;
            this.textBoxResultJSONList.Name = "textBoxResultJSONList";
            this.textBoxResultJSONList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultJSONList.Size = new System.Drawing.Size(679, 152);
            this.textBoxResultJSONList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input API HTML";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serialized Result";
            // 
            // buttonGetResult
            // 
            this.buttonGetResult.Location = new System.Drawing.Point(109, 32);
            this.buttonGetResult.Name = "buttonGetResult";
            this.buttonGetResult.Size = new System.Drawing.Size(679, 23);
            this.buttonGetResult.TabIndex = 4;
            this.buttonGetResult.Text = "Get Result";
            this.buttonGetResult.UseVisualStyleBackColor = true;
            this.buttonGetResult.Click += new System.EventHandler(this.buttonGetResult_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Deserialized\r\nResults";
            // 
            // textBoxDeserializedResults
            // 
            this.textBoxDeserializedResults.Location = new System.Drawing.Point(109, 239);
            this.textBoxDeserializedResults.Multiline = true;
            this.textBoxDeserializedResults.Name = "textBoxDeserializedResults";
            this.textBoxDeserializedResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDeserializedResults.Size = new System.Drawing.Size(679, 178);
            this.textBoxDeserializedResults.TabIndex = 7;
            // 
            // buttonDeserializeResults
            // 
            this.buttonDeserializeResults.Location = new System.Drawing.Point(109, 213);
            this.buttonDeserializeResults.Name = "buttonDeserializeResults";
            this.buttonDeserializeResults.Size = new System.Drawing.Size(676, 23);
            this.buttonDeserializeResults.TabIndex = 8;
            this.buttonDeserializeResults.Text = "Deserialize Results";
            this.buttonDeserializeResults.UseVisualStyleBackColor = true;
            this.buttonDeserializeResults.Click += new System.EventHandler(this.buttonDeserializeResults_Click);
            // 
            // buttonClearDeserializedResults
            // 
            this.buttonClearDeserializedResults.Location = new System.Drawing.Point(109, 421);
            this.buttonClearDeserializedResults.Name = "buttonClearDeserializedResults";
            this.buttonClearDeserializedResults.Size = new System.Drawing.Size(679, 23);
            this.buttonClearDeserializedResults.TabIndex = 9;
            this.buttonClearDeserializedResults.Text = "Clear Form";
            this.buttonClearDeserializedResults.UseVisualStyleBackColor = true;
            this.buttonClearDeserializedResults.Click += new System.EventHandler(this.buttonClearDeserializedResults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClearDeserializedResults);
            this.Controls.Add(this.buttonDeserializeResults);
            this.Controls.Add(this.textBoxDeserializedResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGetResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResultJSONList);
            this.Controls.Add(this.textBoxEndpointInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEndpointInput;
        private System.Windows.Forms.TextBox textBoxResultJSONList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGetResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDeserializedResults;
        private System.Windows.Forms.Button buttonDeserializeResults;
        private System.Windows.Forms.Button buttonClearDeserializedResults;
    }
}

