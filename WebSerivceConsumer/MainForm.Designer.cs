namespace WebSerivceConsumer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxFibonacciResult = new System.Windows.Forms.TextBox();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelFibonacci = new System.Windows.Forms.Label();
            this.textBoxXmlResult = new System.Windows.Forms.RichTextBox();
            this.textBoxXmlToConvert = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelXmlValue = new System.Windows.Forms.Label();
            this.labelXmlJson = new System.Windows.Forms.Label();
            this.textBoxValueToCompute = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxValueToCompute);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxFibonacciResult);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCompute);
            this.splitContainer1.Panel1.Controls.Add(this.labelValue);
            this.splitContainer1.Panel1.Controls.Add(this.labelFibonacci);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxXmlResult);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxXmlToConvert);
            this.splitContainer1.Panel2.Controls.Add(this.buttonConvert);
            this.splitContainer1.Panel2.Controls.Add(this.labelXmlValue);
            this.splitContainer1.Panel2.Controls.Add(this.labelXmlJson);
            this.splitContainer1.Size = new System.Drawing.Size(784, 280);
            this.splitContainer1.SplitterDistance = 385;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBoxFibonacciResult
            // 
            this.textBoxFibonacciResult.Enabled = false;
            this.textBoxFibonacciResult.Location = new System.Drawing.Point(160, 150);
            this.textBoxFibonacciResult.Name = "textBoxFibonacciResult";
            this.textBoxFibonacciResult.Size = new System.Drawing.Size(200, 22);
            this.textBoxFibonacciResult.TabIndex = 4;
            // 
            // buttonCompute
            // 
            this.buttonCompute.Location = new System.Drawing.Point(17, 145);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(83, 32);
            this.buttonCompute.TabIndex = 2;
            this.buttonCompute.Text = "Compute";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(14, 105);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(118, 17);
            this.labelValue.TabIndex = 1;
            this.labelValue.Text = "Value to compute";
            // 
            // labelFibonacci
            // 
            this.labelFibonacci.AutoSize = true;
            this.labelFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFibonacci.Location = new System.Drawing.Point(12, 9);
            this.labelFibonacci.Name = "labelFibonacci";
            this.labelFibonacci.Size = new System.Drawing.Size(298, 25);
            this.labelFibonacci.TabIndex = 0;
            this.labelFibonacci.Text = "Compute Fibonacci sequence";
            // 
            // textBoxXmlResult
            // 
            this.textBoxXmlResult.Location = new System.Drawing.Point(164, 145);
            this.textBoxXmlResult.Name = "textBoxXmlResult";
            this.textBoxXmlResult.Size = new System.Drawing.Size(200, 123);
            this.textBoxXmlResult.TabIndex = 5;
            this.textBoxXmlResult.Text = "";
            // 
            // textBoxXmlToConvert
            // 
            this.textBoxXmlToConvert.Location = new System.Drawing.Point(164, 102);
            this.textBoxXmlToConvert.Name = "textBoxXmlToConvert";
            this.textBoxXmlToConvert.Size = new System.Drawing.Size(200, 22);
            this.textBoxXmlToConvert.TabIndex = 4;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(8, 145);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(83, 32);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // labelXmlValue
            // 
            this.labelXmlValue.AutoSize = true;
            this.labelXmlValue.Location = new System.Drawing.Point(8, 105);
            this.labelXmlValue.Name = "labelXmlValue";
            this.labelXmlValue.Size = new System.Drawing.Size(98, 17);
            this.labelXmlValue.TabIndex = 1;
            this.labelXmlValue.Text = "Xml to convert";
            // 
            // labelXmlJson
            // 
            this.labelXmlJson.AutoSize = true;
            this.labelXmlJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXmlJson.Location = new System.Drawing.Point(3, 9);
            this.labelXmlJson.Name = "labelXmlJson";
            this.labelXmlJson.Size = new System.Drawing.Size(208, 25);
            this.labelXmlJson.TabIndex = 0;
            this.labelXmlJson.Text = "Convert Xml to Json";
            // 
            // textBoxValueToCompute
            // 
            this.textBoxValueToCompute.Location = new System.Drawing.Point(160, 102);
            this.textBoxValueToCompute.Name = "textBoxValueToCompute";
            this.textBoxValueToCompute.Size = new System.Drawing.Size(200, 22);
            this.textBoxValueToCompute.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 280);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxFibonacciResult;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelFibonacci;
        private System.Windows.Forms.TextBox textBoxXmlToConvert;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelXmlValue;
        private System.Windows.Forms.Label labelXmlJson;
        private System.Windows.Forms.RichTextBox textBoxXmlResult;
        private System.Windows.Forms.TextBox textBoxValueToCompute;
    }
}

