namespace L55
{
    partial class FileFormatDialog
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
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(134, 12);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(104, 52);
            this.btnCsv.TabIndex = 0;
            this.btnCsv.Text = "Csv";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click_1);
            // 
            // btnJson
            // 
            this.btnJson.Location = new System.Drawing.Point(12, 12);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(116, 52);
            this.btnJson.TabIndex = 1;
            this.btnJson.Text = "Json";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click_1);
            // 
            // FileFormatDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 78);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.btnCsv);
            this.Name = "FileFormatDialog";
            this.Text = "FileFormatDialog";
            this.Load += new System.EventHandler(this.FileFormatDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnJson;
    }
}