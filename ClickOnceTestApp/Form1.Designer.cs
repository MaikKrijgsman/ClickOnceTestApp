namespace ClickOnceTestApp
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
            label1 = new Label();
            Btn_Click_me = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 0;
            label1.Text = "Version 2";
            // 
            // Btn_Click_me
            // 
            Btn_Click_me.Location = new Point(12, 42);
            Btn_Click_me.Name = "Btn_Click_me";
            Btn_Click_me.Size = new Size(131, 40);
            Btn_Click_me.TabIndex = 1;
            Btn_Click_me.Text = "Click Me!";
            Btn_Click_me.UseVisualStyleBackColor = true;
            Btn_Click_me.Click += Btn_Click_me_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Click_me);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Btn_Click_me;
    }
}