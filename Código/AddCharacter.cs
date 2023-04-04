using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_Topicos
{
    public partial class AddCharacter : Form
    {
        private sqlClass sqlClass1 = new sqlClass("localhost", "root", "", "vmsoftware");

        List<string> nombreActor = new List<string>();
        List<int> idActor = new List<int>();
        
        public List <int> ids = new List<int>();
        public List<string> personajes = new List<string>();

        private void obtenerNombreActor()
        {
            nombreActor = sqlClass1.SqlQuery("SELECT nombre FROM actor", "nombre");
            idActor = sqlClass1.SqlQuery("SELECT id FROM actor", "id", 0);
        }

        public AddCharacter()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(343+ 531+10, 393-90);
            txtPapel.PlaceHolder = "Nombre del papel";
            cmbActors.PlaceHolder = "Actor";
            obtenerNombreActor();



            //Combobox users
            cmbActors.Items.Clear();
            cmbActors.BackColor = Color.Black;
            cmbActors.Text = "Actor";

            foreach (string name in nombreActor)
            {
                cmbActors.Items.Add(name);
            }
            

            dataGridView1.DataSource = sqlClass1.sqlQueryGridView("SELECT * FROM papeltemp").Tables[0];
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int[] idActor = this.idActor.ToArray();
            string query = $"INSERT INTO papeltemp(fkIdActor, personaje) VALUES" +
                $" ('{idActor[cmbActors.SelectedIndex]}', '{txtPapel.Text}')";
            bool verf = sqlClass1.insertData(query);
            ids.Add(idActor[cmbActors.SelectedIndex]);
            personajes.Add(txtPapel.Text);

            dataGridView1.DataSource = sqlClass1.sqlQueryGridView("SELECT * FROM papeltemp").Tables[0];
            if (verf)
            {
                MessageBox.Show("Los datos han sido insertados satisfactoriamente");
            }
            else if (!verf)
            {
                MessageBox.Show("Los datos no han sido insertados satisfactoriamente");
            }
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
