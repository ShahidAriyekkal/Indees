namespace RegistrationForm
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
            this.nm = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.ph = new System.Windows.Forms.Label();
            this.em = new System.Windows.Forms.Label();
            this.gr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.b1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nm
            // 
            this.nm.AutoSize = true;
            this.nm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm.Location = new System.Drawing.Point(351, 95);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(48, 16);
            this.nm.TabIndex = 0;
            this.nm.Text = "Name";
            this.nm.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(496, 88);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(165, 20);
            this.tb1.TabIndex = 1;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(496, 137);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(165, 20);
            this.tb2.TabIndex = 1;
            // 
            // ph
            // 
            this.ph.AutoSize = true;
            this.ph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ph.Location = new System.Drawing.Point(351, 144);
            this.ph.Name = "ph";
            this.ph.Size = new System.Drawing.Size(51, 16);
            this.ph.TabIndex = 0;
            this.ph.Text = "Phone";
            // 
            // em
            // 
            this.em.AutoSize = true;
            this.em.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.em.Location = new System.Drawing.Point(351, 191);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(46, 16);
            this.em.TabIndex = 0;
            this.em.Text = "Email";
            this.em.Click += new System.EventHandler(this.label3_Click);
            // 
            // gr
            // 
            this.gr.AutoSize = true;
            this.gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr.Location = new System.Drawing.Point(351, 255);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(58, 16);
            this.gr.TabIndex = 0;
            this.gr.Text = "Gender";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "REGISTRATION FORM";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(496, 188);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(165, 20);
            this.tb3.TabIndex = 1;
            // 
            // rb1
            // 
            this.rb1.Location = new System.Drawing.Point(496, 251);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(80, 17);
            this.rb1.TabIndex = 2;
            this.rb1.TabStop = true;
            this.rb1.Text = "Male";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.Location = new System.Drawing.Point(582, 253);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(79, 17);
            this.rb2.TabIndex = 2;
            this.rb2.TabStop = true;
            this.rb2.Text = "Female";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(456, 360);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 3;
            this.b1.Text = "SUBMIT";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(384, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 34);
            this.label1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 586);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.ph);
            this.Controls.Add(this.em);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nm;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label ph;
        private System.Windows.Forms.Label em;
        private System.Windows.Forms.Label gr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label label1;
    }
}

