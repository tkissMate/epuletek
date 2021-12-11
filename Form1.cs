using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace epuletek
{
    public partial class Form1 : Form
    {
        public string file = "epuletek.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(file))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] sor = sr.ReadLine().Split(';');
                            if (sor[0].Equals("csaladi"))
                            {
                                Csaladihaz uj = new Csaladihaz(
                                    sor[1],
                                    int.Parse(sor[2]),
                                    (epitesiAnyagok)Enum.Parse(typeof(epitesiAnyagok),sor[3]),
                                    DateTime.Parse(sor[4]),
                                    DateTime.Parse(sor[5]),
                                    int.Parse(sor[6]),
                                    bool.Parse(sor[7]),
                                    (TetoAnyaga)Enum.Parse(typeof(TetoAnyaga),sor[8])
                                    );
                                listBox1_epuletek.Items.Add(uj);
                            }
                            else
                            {
                                Tombhaz uj = new Tombhaz(
                                    sor[1],
                                    int.Parse(sor[2]),
                                    (epitesiAnyagok)Enum.Parse(typeof(epitesiAnyagok), sor[3]),
                                    DateTime.Parse(sor[4]),
                                    DateTime.Parse(sor[5]),
                                    int.Parse(sor[6]),
                                    bool.Parse(sor[7]),
                                    (FenntartasTipusa)Enum.Parse(typeof(FenntartasTipusa), sor[8])
                                    );
                                listBox1_epuletek.Items.Add(uj);
                            }
                        }
                    }
                }
                catch (Exception x)
                {

                    MessageBox.Show(x.Message);
                }
            }
        }

        private void csaladi_Click(object sender, EventArgs e)
        {
            Program.form_csalad.ShowDialog();
        }

        private void button_tomb_Click(object sender, EventArgs e)
        {
            Program.form_tomb.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan bezarja a programot?","Megerosites",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Save_Epuletek();
            }
            else
            {
                e.Cancel =true;
            }
        }

        private void Save_Epuletek()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(file))
                {
                    
                    foreach (var item in listBox1_epuletek.Items)
                    {
                        if (typeof(Csaladihaz)== item.GetType())
                        {
                            sw.WriteLine(((Csaladihaz)item).toCSV());
                        }
                        else
                        {
                            sw.WriteLine(((Tombhaz)item).toCSV());
                        }
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            listBox1_epuletek.Items.RemoveAt(listBox1_epuletek.SelectedIndex);
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if (typeof(Csaladihaz)==listBox1_epuletek.SelectedItem.GetType())
            {
                Program.form_csalad.Muvelet = "update";
                Program.form_csalad.ShowDialog();
            }
            else
            {
                Program.form_tomb.Muvelet = "update";
                Program.form_tomb.ShowDialog();
            }
        }
    }
}
