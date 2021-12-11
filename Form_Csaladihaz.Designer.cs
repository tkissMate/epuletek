
namespace epuletek
{
    partial class Form_Csaladihaz
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
            this.label_cim = new System.Windows.Forms.Label();
            this.label_terulet = new System.Windows.Forms.Label();
            this.label_anyag = new System.Windows.Forms.Label();
            this.label_kezdes = new System.Windows.Forms.Label();
            this.label_vege = new System.Windows.Forms.Label();
            this.label_ottelok = new System.Windows.Forms.Label();
            this.label_teto = new System.Windows.Forms.Label();
            this.checkBox_garazs = new System.Windows.Forms.CheckBox();
            this.textBox_cim = new System.Windows.Forms.TextBox();
            this.numericUpDown_terulet = new System.Windows.Forms.NumericUpDown();
            this.comboBox_anyag = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_kezdes = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_vege = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_ottelok = new System.Windows.Forms.NumericUpDown();
            this.comboBox_teto = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_terulet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ottelok)).BeginInit();
            this.SuspendLayout();
            // 
            // label_cim
            // 
            this.label_cim.AutoSize = true;
            this.label_cim.Location = new System.Drawing.Point(43, 38);
            this.label_cim.Name = "label_cim";
            this.label_cim.Size = new System.Drawing.Size(24, 13);
            this.label_cim.TabIndex = 0;
            this.label_cim.Text = "Cim";
            // 
            // label_terulet
            // 
            this.label_terulet.AutoSize = true;
            this.label_terulet.Location = new System.Drawing.Point(43, 73);
            this.label_terulet.Name = "label_terulet";
            this.label_terulet.Size = new System.Drawing.Size(57, 13);
            this.label_terulet.TabIndex = 1;
            this.label_terulet.Text = "Alapterulet";
            // 
            // label_anyag
            // 
            this.label_anyag.AutoSize = true;
            this.label_anyag.Location = new System.Drawing.Point(43, 108);
            this.label_anyag.Name = "label_anyag";
            this.label_anyag.Size = new System.Drawing.Size(37, 13);
            this.label_anyag.TabIndex = 2;
            this.label_anyag.Text = "Anyag";
            // 
            // label_kezdes
            // 
            this.label_kezdes.AutoSize = true;
            this.label_kezdes.Location = new System.Drawing.Point(43, 143);
            this.label_kezdes.Name = "label_kezdes";
            this.label_kezdes.Size = new System.Drawing.Size(115, 13);
            this.label_kezdes.TabIndex = 3;
            this.label_kezdes.Text = "Munkavégzés kezdete";
            // 
            // label_vege
            // 
            this.label_vege.AutoSize = true;
            this.label_vege.Location = new System.Drawing.Point(43, 178);
            this.label_vege.Name = "label_vege";
            this.label_vege.Size = new System.Drawing.Size(102, 13);
            this.label_vege.TabIndex = 4;
            this.label_vege.Text = "Munkavégzés Vége";
            // 
            // label_ottelok
            // 
            this.label_ottelok.AutoSize = true;
            this.label_ottelok.Location = new System.Drawing.Point(43, 213);
            this.label_ottelok.Name = "label_ottelok";
            this.label_ottelok.Size = new System.Drawing.Size(77, 13);
            this.label_ottelok.TabIndex = 5;
            this.label_ottelok.Text = "Ott élők száma";
            // 
            // label_teto
            // 
            this.label_teto.AutoSize = true;
            this.label_teto.Location = new System.Drawing.Point(43, 287);
            this.label_teto.Name = "label_teto";
            this.label_teto.Size = new System.Drawing.Size(62, 13);
            this.label_teto.TabIndex = 6;
            this.label_teto.Text = "Tető típusa";
            // 
            // checkBox_garazs
            // 
            this.checkBox_garazs.AutoSize = true;
            this.checkBox_garazs.Location = new System.Drawing.Point(46, 248);
            this.checkBox_garazs.Name = "checkBox_garazs";
            this.checkBox_garazs.Size = new System.Drawing.Size(79, 17);
            this.checkBox_garazs.TabIndex = 7;
            this.checkBox_garazs.Text = "Van garázs";
            this.checkBox_garazs.UseVisualStyleBackColor = true;
            // 
            // textBox_cim
            // 
            this.textBox_cim.Location = new System.Drawing.Point(208, 38);
            this.textBox_cim.Name = "textBox_cim";
            this.textBox_cim.Size = new System.Drawing.Size(120, 20);
            this.textBox_cim.TabIndex = 8;
            // 
            // numericUpDown_terulet
            // 
            this.numericUpDown_terulet.Location = new System.Drawing.Point(208, 73);
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
            this.numericUpDown_terulet.TabIndex = 9;
            this.numericUpDown_terulet.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // comboBox_anyag
            // 
            this.comboBox_anyag.FormattingEnabled = true;
            this.comboBox_anyag.Location = new System.Drawing.Point(208, 108);
            this.comboBox_anyag.Name = "comboBox_anyag";
            this.comboBox_anyag.Size = new System.Drawing.Size(121, 21);
            this.comboBox_anyag.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "nm";
            // 
            // dateTimePicker_kezdes
            // 
            this.dateTimePicker_kezdes.Location = new System.Drawing.Point(208, 143);
            this.dateTimePicker_kezdes.Name = "dateTimePicker_kezdes";
            this.dateTimePicker_kezdes.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_kezdes.TabIndex = 12;
            // 
            // dateTimePicker_vege
            // 
            this.dateTimePicker_vege.Location = new System.Drawing.Point(208, 178);
            this.dateTimePicker_vege.Name = "dateTimePicker_vege";
            this.dateTimePicker_vege.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_vege.TabIndex = 13;
            // 
            // numericUpDown_ottelok
            // 
            this.numericUpDown_ottelok.Location = new System.Drawing.Point(208, 213);
            this.numericUpDown_ottelok.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_ottelok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ottelok.Name = "numericUpDown_ottelok";
            this.numericUpDown_ottelok.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_ottelok.TabIndex = 14;
            this.numericUpDown_ottelok.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_teto
            // 
            this.comboBox_teto.FormattingEnabled = true;
            this.comboBox_teto.Location = new System.Drawing.Point(208, 287);
            this.comboBox_teto.Name = "comboBox_teto";
            this.comboBox_teto.Size = new System.Drawing.Size(120, 21);
            this.comboBox_teto.TabIndex = 15;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(46, 334);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(310, 59);
            this.button_save.TabIndex = 16;
            this.button_save.Text = "Rogzites";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Form_Csaladihaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 434);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.comboBox_teto);
            this.Controls.Add(this.numericUpDown_ottelok);
            this.Controls.Add(this.dateTimePicker_vege);
            this.Controls.Add(this.dateTimePicker_kezdes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_anyag);
            this.Controls.Add(this.numericUpDown_terulet);
            this.Controls.Add(this.textBox_cim);
            this.Controls.Add(this.checkBox_garazs);
            this.Controls.Add(this.label_teto);
            this.Controls.Add(this.label_ottelok);
            this.Controls.Add(this.label_vege);
            this.Controls.Add(this.label_kezdes);
            this.Controls.Add(this.label_anyag);
            this.Controls.Add(this.label_terulet);
            this.Controls.Add(this.label_cim);
            this.Name = "Form_Csaladihaz";
            this.Text = "Form_Csaladihaz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Csaladihaz_FormClosed);
            this.Load += new System.EventHandler(this.Form_Csaladihaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_terulet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ottelok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cim;
        private System.Windows.Forms.Label label_terulet;
        private System.Windows.Forms.Label label_anyag;
        private System.Windows.Forms.Label label_kezdes;
        private System.Windows.Forms.Label label_vege;
        private System.Windows.Forms.Label label_ottelok;
        private System.Windows.Forms.Label label_teto;
        private System.Windows.Forms.CheckBox checkBox_garazs;
        private System.Windows.Forms.TextBox textBox_cim;
        private System.Windows.Forms.NumericUpDown numericUpDown_terulet;
        private System.Windows.Forms.ComboBox comboBox_anyag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_kezdes;
        private System.Windows.Forms.DateTimePicker dateTimePicker_vege;
        private System.Windows.Forms.NumericUpDown numericUpDown_ottelok;
        private System.Windows.Forms.ComboBox comboBox_teto;
        private System.Windows.Forms.Button button_save;
    }
}