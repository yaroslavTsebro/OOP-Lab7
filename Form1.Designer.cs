namespace L55
{
    partial class Form1
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
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.displayFormatComboBox = new System.Windows.Forms.ComboBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.amountOfWindowsTextBox = new System.Windows.Forms.TextBox();
            this.doorsListBox = new System.Windows.Forms.ListBox();
            this.doorSignTextBox = new System.Windows.Forms.TextBox();
            this.isOpenedCheckBox = new System.Windows.Forms.CheckBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddObjectButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FindObjectButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialComboBox
            // 
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(12, 140);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(121, 21);
            this.materialComboBox.TabIndex = 0;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(12, 113);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 1;
            // 
            // displayFormatComboBox
            // 
            this.displayFormatComboBox.FormattingEnabled = true;
            this.displayFormatComboBox.Location = new System.Drawing.Point(628, 15);
            this.displayFormatComboBox.Name = "displayFormatComboBox";
            this.displayFormatComboBox.Size = new System.Drawing.Size(121, 21);
            this.displayFormatComboBox.TabIndex = 2;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(14, 12);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 3;
            // 
            // amountOfWindowsTextBox
            // 
            this.amountOfWindowsTextBox.Location = new System.Drawing.Point(14, 87);
            this.amountOfWindowsTextBox.Name = "amountOfWindowsTextBox";
            this.amountOfWindowsTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountOfWindowsTextBox.TabIndex = 4;
            // 
            // doorsListBox
            // 
            this.doorsListBox.FormattingEnabled = true;
            this.doorsListBox.Location = new System.Drawing.Point(209, 12);
            this.doorsListBox.Name = "doorsListBox";
            this.doorsListBox.Size = new System.Drawing.Size(404, 95);
            this.doorsListBox.TabIndex = 5;
            // 
            // doorSignTextBox
            // 
            this.doorSignTextBox.Location = new System.Drawing.Point(14, 38);
            this.doorSignTextBox.Name = "doorSignTextBox";
            this.doorSignTextBox.Size = new System.Drawing.Size(100, 20);
            this.doorSignTextBox.TabIndex = 6;
            // 
            // isOpenedCheckBox
            // 
            this.isOpenedCheckBox.AutoSize = true;
            this.isOpenedCheckBox.Location = new System.Drawing.Point(14, 64);
            this.isOpenedCheckBox.Name = "isOpenedCheckBox";
            this.isOpenedCheckBox.Size = new System.Drawing.Size(74, 17);
            this.isOpenedCheckBox.TabIndex = 7;
            this.isOpenedCheckBox.Text = "is Opened";
            this.isOpenedCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(468, 124);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(145, 20);
            this.searchTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "windows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "sign";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "0";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // AddObjectButton
            // 
            this.AddObjectButton.Location = new System.Drawing.Point(12, 167);
            this.AddObjectButton.Name = "AddObjectButton";
            this.AddObjectButton.Size = new System.Drawing.Size(168, 23);
            this.AddObjectButton.TabIndex = 13;
            this.AddObjectButton.Text = "AddObjectButton";
            this.AddObjectButton.UseVisualStyleBackColor = true;
            this.AddObjectButton.Click += new System.EventHandler(this.AddObjectButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FindObjectButton
            // 
            this.FindObjectButton.Location = new System.Drawing.Point(357, 122);
            this.FindObjectButton.Name = "FindObjectButton";
            this.FindObjectButton.Size = new System.Drawing.Size(75, 23);
            this.FindObjectButton.TabIndex = 15;
            this.FindObjectButton.Text = "FindObjectButton";
            this.FindObjectButton.UseVisualStyleBackColor = true;
            this.FindObjectButton.Click += new System.EventHandler(this.FindObjectButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "material";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "toList";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 214);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "toString";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(377, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(628, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "info";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 289);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FindObjectButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddObjectButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.isOpenedCheckBox);
            this.Controls.Add(this.doorSignTextBox);
            this.Controls.Add(this.doorsListBox);
            this.Controls.Add(this.amountOfWindowsTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.displayFormatComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.materialComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox displayFormatComboBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox amountOfWindowsTextBox;
        private System.Windows.Forms.ListBox doorsListBox;
        private System.Windows.Forms.TextBox doorSignTextBox;
        private System.Windows.Forms.CheckBox isOpenedCheckBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddObjectButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button FindObjectButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

