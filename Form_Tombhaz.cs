using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace epuletek
{
    public partial class Form_Tombhaz : Form
    {
        private string muvelet = "";
        Tombhaz kiv = null;

        public string Muvelet { get => muvelet; set => muvelet = value; }

        public Form_Tombhaz()
        {
            InitializeComponent();

            //Comboboxok feltoltese
            foreach (string item in Enum.GetNames(typeof(epitesiAnyagok)))
            {
                comboBox_anyag.Items.Add(item);
            }
            foreach (string item in Enum.GetNames(typeof(FenntartasTipusa)))
            {
                comboBox_fenntartas.Items.Add(item);
            }
        }

        private void Form_Tombhaz_Load(object sender, EventArgs e)
        {
            //A modositando elem adatainak betoltese a formba
            if (muvelet == "update")
            {
                kiv = (Tombhaz)Program.form1.listBox1_epuletek.SelectedItem;
                textBox_cim.Text = kiv.Cim;
                textBox_cim.ReadOnly = true;
                numericUpDown_terulet.Value = kiv.Terulet;
                comboBox_anyag.SelectedItem = kiv.Anyag.ToString();
                comboBox_anyag.Enabled = false;
                dateTimePicker_kezdes.Value = kiv.Kezdes;
                dateTimePicker_vege.Value = kiv.Vegzes;
                numericUpDown_lakasok.Value = kiv.LakasokSzama;
                numericUpDown_lakasok.Enabled = false;
                checkBox_lift.Checked = kiv.VanLift;
                checkBox_lift.Enabled = false;
                comboBox_fenntartas.SelectedItem = kiv.Fenntartas.ToString();
                button_save.Text = "Modositas";
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_cim.Text))
            {
                MessageBox.Show("Nem adott meg cimet");
                return;
            }
            if (dateTimePicker_kezdes.Value < DateTime.Today || dateTimePicker_vege.Value < dateTimePicker_kezdes.Value)
            {
                MessageBox.Show("Rossz datumot adott meg!");
                return;
            }


            epitesiAnyagok epitesianyag = (epitesiAnyagok)Enum.Parse(typeof(epitesiAnyagok), comboBox_anyag.SelectedItem.ToString());
            FenntartasTipusa fenntartas = (FenntartasTipusa)Enum.Parse(typeof(FenntartasTipusa), comboBox_fenntartas.SelectedItem.ToString());

            //kivalasztott elem modositasa
            if (muvelet == "update")
            {
                kiv.Terulet = (int)numericUpDown_terulet.Value;
                kiv.Kezdes = dateTimePicker_kezdes.Value;
                kiv.Vegzes = dateTimePicker_vege.Value;
                kiv.Fenntartas = fenntartas;

                reset();


                this.Close();
                return;
            }


            //uj tombhaz hozzaadasa a listahoz
            Tombhaz uj = new Tombhaz(
                textBox_cim.Text,
                (int)numericUpDown_terulet.Value,
                epitesianyag,
                dateTimePicker_kezdes.Value,
                dateTimePicker_vege.Value,
                (int)numericUpDown_lakasok.Value,
                checkBox_lift.Checked,
                fenntartas
                );
            Program.form1.listBox1_epuletek.Items.Add(uj);
            reset();
        }

        private void reset()
        {
            button_save.Text = "Rogzites";
            muvelet = "";
            textBox_cim.ReadOnly = false;
            comboBox_anyag.Enabled = true;
            numericUpDown_lakasok.Enabled = true;
            checkBox_lift.Enabled = true;
            textBox_cim.Text = "";
            numericUpDown_terulet.Value = numericUpDown_terulet.Minimum;
            comboBox_anyag.SelectedItem = -1;
            dateTimePicker_kezdes.Value = DateTime.Now;
            dateTimePicker_vege.Value = DateTime.Now;
            numericUpDown_lakasok.Value = numericUpDown_lakasok.Minimum;
            comboBox_fenntartas.SelectedItem = -1;
        }

        private void Form_Tombhaz_FormClosed(object sender, FormClosedEventArgs e)
        {
            reset();
        }
    }
}
