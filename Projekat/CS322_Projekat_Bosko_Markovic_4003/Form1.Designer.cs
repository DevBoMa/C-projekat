namespace CS322_Projekat_Bosko_Markovic_4003
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prijava = new System.Windows.Forms.Button();
            this.pravljenjeNaloga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(126, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 31);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(126, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = 'x';
            this.textBox2.Size = new System.Drawing.Size(140, 31);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Налог:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Шифра:";
            // 
            // prijava
            // 
            this.prijava.BackColor = System.Drawing.Color.Red;
            this.prijava.ForeColor = System.Drawing.Color.Gold;
            this.prijava.Location = new System.Drawing.Point(103, 150);
            this.prijava.Name = "prijava";
            this.prijava.Size = new System.Drawing.Size(93, 35);
            this.prijava.TabIndex = 4;
            this.prijava.Text = "Пријави се";
            this.prijava.UseVisualStyleBackColor = false;
            this.prijava.Click += new System.EventHandler(this.prijava_Click);
            // 
            // pravljenjeNaloga
            // 
            this.pravljenjeNaloga.BackColor = System.Drawing.Color.Red;
            this.pravljenjeNaloga.ForeColor = System.Drawing.Color.Gold;
            this.pravljenjeNaloga.Location = new System.Drawing.Point(103, 200);
            this.pravljenjeNaloga.Name = "pravljenjeNaloga";
            this.pravljenjeNaloga.Size = new System.Drawing.Size(93, 35);
            this.pravljenjeNaloga.TabIndex = 5;
            this.pravljenjeNaloga.Text = "Нови налог";
            this.pravljenjeNaloga.UseVisualStyleBackColor = false;
            this.pravljenjeNaloga.Click += new System.EventHandler(this.pravljenjeNaloga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(303, 243);
            this.Controls.Add(this.pravljenjeNaloga);
            this.Controls.Add(this.prijava);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Почетна";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button prijava;
        private System.Windows.Forms.Button pravljenjeNaloga;
    }
}

