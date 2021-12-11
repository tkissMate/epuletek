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
    public partial class Form_Csaladihaz : Form
    {
        private string muvelet = "";
        Csaladihaz kiv = null;

        public string Muvelet { get => muvelet; set => muvelet = value; }

        public Form_Csaladihaz()
        {
            InitializeComponent();

            //Comboboxok feltoltese
            foreach (string item in Enum.GetNames(typeof(epitesiAnyagok)))
            {
                comboBox_anyag.Items.Add(item);
            }
            foreach (string item in Enum.GetNames(typeof(TetoAnyaga)))
            {
                comboBox_teto.Items.Add(item);
            }
        }

        private void Form_Csaladihaz_Load(object sender, EventArgs e)
        {
            //A modositando elem adatainak betoltese a formba
            if (muvelet =="update")
            {
                kiv = (Csaladihaz)Program.form1.listBox1_epuletek.SelectedItem;
                textBox_cim.Text = kiv.Cim;
                textBox_cim.ReadOnly = true;
                numericUpDown_terulet.Value = kiv.Terulet;
                comboBox_anyag.SelectedItem = kiv.Anyag.ToString();
                comboBox_anyag.Enabled = false;
                dateTimePicker_kezdes.Value = kiv.Kezdes;
                dateTimePicker_vege.Value = kiv.Vegzes;
                numericUpDown_ottelok.Value = kiv.OttElok;
                checkBox_garazs.Checked = kiv.VanGarazs;
                comboBox_teto.SelectedItem = kiv.Teto.ToString();
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
            TetoAnyaga tetoanyaga = (TetoAnyaga)Enum.Parse(typeof(TetoAnyaga), comboBox_teto.SelectedItem.ToString());
            
            //kivalasztott elem modositasa
            if (muvelet == "update")
            {
                kiv.Terulet = (int)numericUpDown_terulet.Value;
                kiv.Kezdes = dateTimePicker_kezdes.Value;
                kiv.Vegzes = dateTimePicker_vege.Value;
                kiv.OttElok = (int)numericUpDown_ottelok.Value;
                kiv.VanGarazs = checkBox_garazs.Checked;
                kiv.Teto = tetoanyaga;

                reset();

                this.Close();
                return;
            }

            //Uj csaladihaz hozzaadasa a listahoz
            Csaladihaz uj = new Csaladihaz(
                textBox_cim.Text,
                (int)numericUpDown_terulet.Value,
                epitesianyag,
                dateTimePicker_kezdes.Value,
                dateTimePicker_vege.Value,
                (int)numericUpDown_ottelok.Value,
                checkBox_garazs.Checked,
                tetoanyaga
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
            textBox_cim.Text = "";
            numericUpDown_terulet.Value = numericUpDown_terulet.Minimum;
            comboBox_anyag.SelectedItem = -1;
            dateTimePicker_kezdes.Value = DateTime.Now;
            dateTimePicker_vege.Value = DateTime.Now;
            numericUpDown_ottelok.Value = numericUpDown_ottelok.Minimum;
            comboBox_teto.SelectedItem = -1;
        }

        private void Form_Csaladihaz_FormClosed(object sender, FormClosedEventArgs e)
        {
            reset();
        }
    }
}
