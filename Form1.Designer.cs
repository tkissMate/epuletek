
namespace epuletek
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
            this.listBox1_epuletek = new System.Windows.Forms.ListBox();
            this.button_csaladi = new System.Windows.Forms.Button();
            this.button_tomb = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1_epuletek
            // 
            this.listBox1_epuletek.FormattingEnabled = true;
            this.listBox1_epuletek.Location = new System.Drawing.Point(13, 13);
            this.listBox1_epuletek.Name = "listBox1_epuletek";
            this.listBox1_epuletek.Size = new System.Drawing.Size(222, 420);
            this.listBox1_epuletek.TabIndex = 0;
            // 
            // button_csaladi
            // 
            this.button_csaladi.Location = new System.Drawing.Point(267, 13);
            this.button_csaladi.Name = "button_csaladi";
            this.button_csaladi.Size = new System.Drawing.Size(111, 23);
            this.button_csaladi.TabIndex = 1;
            this.button_csaladi.Text = "Uj Családi ház";
            this.button_csaladi.UseVisualStyleBackColor = true;
            this.button_csaladi.Click += new System.EventHandler(this.csaladi_Click);
            // 
            // button_tomb
            // 
            this.button_tomb.Location = new System.Drawing.Point(267, 42);
            this.button_tomb.Name = "button_tomb";
            this.button_tomb.Size = new System.Drawing.Size(111, 23);
            this.button_tomb.TabIndex = 2;
            this.button_tomb.Text = "Uj Tömbház";
            this.button_tomb.UseVisualStyleBackColor = true;
            this.button_tomb.Click += new System.EventHandler(this.button_tomb_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(267, 71);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(111, 23);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Torles";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(267, 100);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(111, 23);
            this.button_change.TabIndex = 4;
            this.button_change.Text = "Modositas";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_tomb);
            this.Controls.Add(this.button_csaladi);
            this.Controls.Add(this.listBox1_epuletek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_csaladi;
        public System.Windows.Forms.ListBox listBox1_epuletek;
        private System.Windows.Forms.Button button_tomb;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_change;
    }
}

