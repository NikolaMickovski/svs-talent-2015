using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }
        /// <summary>
        /// Metod koj koristejki go servisot, vraka lista od site kucinja
        /// od nekoja zamislena baza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Dog_Service.DogClient proxy = new Dog_Service.DogClient();
            var a = proxy.GetListOfDogs();
            var source = new BindingSource(a, null);
            gvDogLovers.DataSource = source;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Metod koj gi zema vrednostite od vleznite kontroli na formata
        /// i koristejki go kreiraniot servis, proveriva dali
        /// dvete kucinja se kompatibilni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckCompatibility_Click(object sender, EventArgs e)
        {
            Dog_Service.DogClient proxy = new Dog_Service.DogClient();
            bool c = proxy.CompatibleMatchByBreedAndBirth(cmbMale.SelectedItem.ToString(), (DateTime)dtpMale.Value, cmbFemale.SelectedItem.ToString(), (DateTime)dtpFemale.Value);
            if (c)
            {
                lblKompatibilnost.ForeColor = Color.Green;
                lblKompatibilnost.Text = "Компатибилни се!";
            }
            else
            {
                lblKompatibilnost.ForeColor = Color.Red;
                lblKompatibilnost.Text = "Не се компатибилни";
            }
        }
    }
}
