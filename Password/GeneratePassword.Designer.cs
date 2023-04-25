namespace Password
{
    partial class GeneratePassword
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Characters = new System.Windows.Forms.NumericUpDown();
            this.box_Numbers = new System.Windows.Forms.CheckBox();
            this.box_Symbols = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_Characters)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(160, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate.Location = new System.Drawing.Point(302, 287);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(151, 37);
            this.btn_Generate.TabIndex = 21;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Number of characters:";
            // 
            // num_Characters
            // 
            this.num_Characters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Characters.Location = new System.Drawing.Point(283, 28);
            this.num_Characters.Name = "num_Characters";
            this.num_Characters.Size = new System.Drawing.Size(120, 34);
            this.num_Characters.TabIndex = 23;
            this.num_Characters.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // box_Numbers
            // 
            this.box_Numbers.AutoSize = true;
            this.box_Numbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Numbers.Location = new System.Drawing.Point(33, 90);
            this.box_Numbers.Name = "box_Numbers";
            this.box_Numbers.Size = new System.Drawing.Size(134, 33);
            this.box_Numbers.TabIndex = 24;
            this.box_Numbers.Text = "Numbers";
            this.box_Numbers.UseVisualStyleBackColor = true;
            // 
            // box_Symbols
            // 
            this.box_Symbols.AutoSize = true;
            this.box_Symbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Symbols.Location = new System.Drawing.Point(33, 147);
            this.box_Symbols.Name = "box_Symbols";
            this.box_Symbols.Size = new System.Drawing.Size(128, 33);
            this.box_Symbols.TabIndex = 25;
            this.box_Symbols.Text = "Symbols";
            this.box_Symbols.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(33, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 34);
            this.textBox1.TabIndex = 26;
            // 
            // GeneratePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 348);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.box_Symbols);
            this.Controls.Add(this.box_Numbers);
            this.Controls.Add(this.num_Characters);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.label1);
            this.Name = "GeneratePassword";
            this.Text = "GeneratePassword";
            ((System.ComponentModel.ISupportInitialize)(this.num_Characters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_Characters;
        private System.Windows.Forms.CheckBox box_Numbers;
        private System.Windows.Forms.CheckBox box_Symbols;
        private System.Windows.Forms.TextBox textBox1;
    }
}