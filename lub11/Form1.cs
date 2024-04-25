using System;
using System.Windows.Forms;

namespace lub11
{
    public partial class Form1 : Form
    {
        public Cars MyCars { get; set; } // Instance of Cars class for data management

        public Form1()
        {
            InitializeComponent();
            MyCars = new Cars(); // Create Cars object on form initialization
        }

        private void addcar_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2(MyCars)) 
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    tbcarinfo.Text += string.Format(
                        "{0}, {1}, {2}. Імя: {3} \r\n" +
                        " Країна: {4:0.00}\r\n." +
                        " Мотор: {5:0.000} л.с.\r\n " +
                        "[{6} | {7}] | Річний дохід на мешканця: {8:0.00} грн\r\n",
                        MyCars.Name,
                        MyCars.Country,
                        MyCars.Motor,
                        MyCars.ObDviguna,
                        MyCars.PotugDviguna,
                        MyCars.MaxSpeed,
                        MyCars.Rnasto,
                        MyCars.DiameterDisk,
                        MyCars.NewCar ? "Новий" : "Старий",
                        MyCars.Automaticgearbox ? "Автоматична" : "Механічна"
                    ).Replace("\r\n", Environment.NewLine); ;
                }
            }
        }

    }
}