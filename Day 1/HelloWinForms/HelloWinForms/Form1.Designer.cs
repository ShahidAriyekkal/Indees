namespace HelloWinForms
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
            lblMessage = new Label();
            btnHello = new Button();
            txtName = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(411, 349);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(103, 45);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "label1";
            lblMessage.Click += label1_Click;
            // 
            // btnHello
            // 
            btnHello.Location = new Point(387, 223);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(75, 23);
            btnHello.TabIndex = 1;
            btnHello.Text = "button1";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(311, 115);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 23);
            txtName.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(576, 228);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 3;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 611);
            Controls.Add(checkBox1);
            Controls.Add(txtName);
            Controls.Add(btnHello);
            Controls.Add(lblMessage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private Button btnHello;
        private TextBox txtName;
        private CheckBox checkBox1;
    }
}
