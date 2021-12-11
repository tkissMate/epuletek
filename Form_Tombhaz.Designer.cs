
namespace epuletek
{
    partial class Form_Tombhaz
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
            this.button_save = new System.Windows.Forms.Button();
            this.comboBox_fenntartas = new System.Windows.Forms.ComboBox();
            this.numericUpDown_lakasok = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_vege = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_kezdes = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_anyag = new System.Windows.Forms.ComboBox();
            this.numericUpDown_terulet = new System.Windows.Forms.NumericUpDown();
            this.textBox_cim = new System.Windows.Forms.TextBox();
            this.checkBox_lift = new System.Windows.Forms.CheckBox();
            this.label_fenntartas = new System.Windows.Forms.Label();
            this.label_lakasok = new System.Windows.Forms.Label();
            this.label_vege = new System.Windows.Forms.Label();
            this.label_kezdes = new System.Windows.Forms.Label();
            this.label_anyag = new System.Windows.Forms.Label();
            this.label_terulet = new System.Windows.Forms.Label();
            this.label_cim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lakasok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_terulet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(45, 332);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(310, 59);
            this.button_save.TabIndex = 33;
            this.button_save.Text = "Rogzites";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // comboBox_fenntartas
            // 
            this.comboBox_fenntartas.FormattingEnabled = true;
            this.comboBox_fenntartas.Location = new System.Drawing.Point(207, 249);
            this.comboBox_fenntartas.Name = "comboBox_fenntartas";
            this.comboBox_fenntartas.Size = new System.Drawing.Size(120, 21);
            this.comboBox_fenntartas.TabIndex = 32;
            // 
            // numericUpDown_lakasok
            // 
            this.numericUpDown_lakasok.Location = new System.Drawing.Point(207, 211);
            this.numericUpDown_lakasok.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_lakasok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_lakasok.Name = "numericUpDown_lakasok";
            this.numericUpDown_lakasok.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_lakasok.TabIndex = 31;
            this.numericUpDown_lakasok.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker_vege
            // 
            this.dateTimePicker_vege.Location = new System.Drawing.Point(207, 176);
            this.dateTimePicker_vege.Name = "dateTimePicker_vege";
            this.dateTimePicker_vege.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_vege.TabIndex = 30;
            // 
            // dateTimePicker_kezdes
            // 
            this.dateTimePicker_kezdes.Location = new System.Drawing.Point(207, 141);
            this.dateTimePicker_kezdes.Name = "dateTimePicker_kezdes";
            this.dateTimePicker_kezdes.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_kezdes.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "nm";
            // 
            // comboBox_anyag
            // 
            this.comboBox_anyag.FormattingEnabled = true;
            this.comboBox_anyag.Location = new System.Drawing.Point(207, 106);
            this.comboBox_anyag.Name = "comboBox_anyag";
            this.comboBox_anyag.Size = new System.Drawing.Size(121, 21);
            this.comboBox_anyag.TabIndex = 27;
            // 
            // numericUpDown_terulet
            // 
            this.numericUpDown_terulet.Location = new System.Drawing.Point(207, 71);
            this.numericUpDown_terulet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_terulet.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_terulet.Name = "numericUpDown_terulet";
            this.numericUpDown_terulet.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_terulet.TabIndex = 26;
            this.numericUpDown_terulet.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // textBox_cim
            // 
            this.textBox_cim.Location = new System.Drawing.Point(207, 36);
            this.textBox_cim.Name = "textBox_cim";
            this.textBox_cim.Size = new System.Drawing.Size(120, 20);
            this.textBox_cim.TabIndex = 25;
            // 
            // checkBox_lift
            // 
            this.checkBox_lift.AutoSize = true;
            this.checkBox_lift.Location = new System.Drawing.Point(41, 290);
            this.checkBox_lift.Name = "checkBox_lift";
            this.checkBox_lift.Size = new System.Drawing.Size(58, 17);
            this.checkBox_lift.TabIndex = 24;
            this.checkBox_lift.Text = "Van lift";
            this.checkBox_lift.UseVisualStyleBackColor = true;
            // 
            // label_fenntartas
            // 
            this.label_fenntartas.AutoSize = true;
            this.label_fenntartas.Location = new System.Drawing.Point(42, 249);
            this.label_fenntartas.Name = "label_fenntartas";
            this.label_fenntartas.Size = new System.Drawing.Size(90, 13);
            this.label_fenntartas.TabIndex = 23;
            this.label_fenntartas.Text = "Fenntartás típusa";
            // 
            // label_lakasok
            // 
            this.label_lakasok.AutoSize = true;
            this.label_lakasok.Location = new System.Drawing.Point(42, 211);
            this.label_lakasok.Name = "label_lakasok";
            this.label_lakasok.Size = new System.Drawing.Size(81, 13);
            this.label_lakasok.TabIndex = 22;
            this.label_lakasok.Text = "Lakások száma";
            // 
            // label_vege
            // 
            this.label_vege.AutoSize = true;
            this.label_vege.Location = new System.Drawing.Point(42, 176);
            this.label_vege.Name = "label_vege";
            this.label_vege.Size = new System.Drawing.Size(102, 13);
            this.label_vege.TabIndex = 21;
            this.label_vege.Text = "Munkavégzés Vége";
            // 
            // label_kezdes
            // 
            this.label_kezdes.AutoSize = true;
            this.label_kezdes.Location = new System.Drawing.Point(42, 141);
            this.label_kezdes.Name = "label_kezdes";
            this.label_kezdes.Size = new System.Drawing.Size(115, 13);
            this.label_kezdes.TabIndex = 20;
            this.label_kezdes.Text = "Munkavégzés kezdete";
            // 
            // label_anyag
            // 
            this.label_anyag.AutoSize = true;
            this.label_anyag.Location = new System.Drawing.Point(42, 106);
            this.label_anyag.Name = "label_anyag";
            this.label_anyag.Size = new System.Drawing.Size(37, 13);
            this.label_anyag.TabIndex = 19;
            this.label_anyag.Text = "Anyag";
            // 
            // label_terulet
            // 
            this.label_terulet.AutoSize = true;
            this.label_terulet.Location = new System.Drawing.Point(42, 71);
            this.label_terulet.Name = "label_terulet";
            this.label_terulet.Size = new System.Drawing.Size(57, 13);
            this.label_terulet.TabIndex = 18;
            this.label_terulet.Text = "Alapterulet";
            // 
            // label_cim
            // 
            this.label_cim.AutoSize = true;
            this.label_cim.Location = new System.Drawing.Point(42, 36);
            this.label_cim.Name = "label_cim";
            this.label_cim.Size = new System.Drawing.Size(24, 13);
            this.label_cim.TabIndex = 17;
            this.label_cim.Text = "Cim";
            // 
            // Form_Tombhaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.comboBox_fenntartas);
            this.Controls.Add(this.numericUpDown_lakasok);
            this.Controls.Add(this.dateTimePicker_vege);
            this.Controls.Add(this.dateTimePicker_kezdes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_anyag);
            this.Controls.Add(this.numericUpDown_terulet);
            this.Controls.Add(this.textBox_cim);
            this.Controls.Add(this.checkBox_lift);
            this.Controls.Add(this.label_fenntartas);
            this.Controls.Add(this.label_lakasok);
            this.Controls.Add(this.label_vege);
            this.Controls.Add(this.label_kezdes);
            this.Controls.Add(this.label_anyag);
            this.Controls.Add(this.label_terulet);
            this.Controls.Add(this.label_cim);
            this.Name = "Form_Tombhaz";
            this.Text = "Form_Tombhaz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Tombhaz_FormClosed);
            this.Load += new System.EventHandler(this.Form_Tombhaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lakasok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_terulet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox comboBox_fenntartas;
        private System.Windows.Forms.NumericUpDown numericUpDown_lakasok;
        private System.Windows.Forms.DateTimePicker dateTimePicker_vege;
        private System.Windows.Forms.DateTimePicker dateTimePicker_kezdes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_anyag;
        private System.Windows.Forms.NumericUpDown numericUpDown_terulet;
        private System.Windows.Forms.TextBox textBox_cim;
        private System.Windows.Forms.CheckBox checkBox_lift;
        private System.Windows.Forms.Label label_fenntartas;
        private System.Windows.Forms.Label label_lakasok;
        private System.Windows.Forms.Label label_vege;
        private System.Windows.Forms.Label label_kezdes;
        private System.Windows.Forms.Label label_anyag;
        private System.Windows.Forms.Label label_terulet;
        private System.Windows.Forms.Label label_cim;
    }
}