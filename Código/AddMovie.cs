using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace proyecto_Topicos
{
    public partial class AddMovie : Form
    {
       
        private AddCharacter VentanaPapel = new AddCharacter();
        private Timer T = new Timer();
        private int id;
        private bool ifModify = false;
        private sqlClass sqlClass1 = new sqlClass("localhost", "root", "", "vmsoftware");
       
        List<string> nombreDirector = new List<string>();
        List<int> idDirector = new List<int>();

        private void obtenerNombreDirector()
        {
            nombreDirector = sqlClass1.SqlQuery("SELECT nombre FROM director", "nombre");
            idDirector = sqlClass1.SqlQuery("SELECT id FROM director", "id", 0);
        }


        public AddMovie()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(343, 393);
            txtLanguage.PlaceHolder = "Idioma";
            txtTitle.PlaceHolder = "Título";
            cmbUsers.PlaceHolder = "Director";

            obtenerNombreDirector();
            
            //Combobox users\
            cmbUsers.Items.Clear();


            foreach (string name in nombreDirector)
            {
                cmbUsers.Items.Add(name);
            }

            cmbUsers.Enabled = true;
           
        }

        public AddMovie(int id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(343, 393);
            txtLanguage.PlaceHolder = "Idioma";
            txtTitle.PlaceHolder = "Título";
            cmbUsers.PlaceHolder = "Director";

            ifModify = true;
            this.id = id;
            obtenerNombreDirector();

            
            string query = $"SELECT nombre FROM pelicula WHERE id={id}";
            object comparativo = sqlClass1.SqlQuery(query);

            if (comparativo == null)
            {
                MessageBox.Show("No existe una película con esa id.");
                T.Enabled = true;
                T.Tick += new EventHandler(Cerrar);
                T.Start();
            }
            else
            {
                foreach (string name in nombreDirector)
                {
                    cmbUsers.Items.Add(name);
                }

                cmbUsers.Enabled = true;

                //Consiguiendo datos...
                query = $"SELECT nombre FROM pelicula WHERE id={id}";
                txtTitle.Text = sqlClass1.SqlQuery(query, "nombre", "");

                query = $"SELECT idioma FROM pelicula WHERE id={id}";
                txtLanguage.Text = sqlClass1.SqlQuery(query, "idioma", "");

                query = $"SELECT fkIdDirector FROM pelicula WHERE id={id}";
                int director = sqlClass1.SqlQuery(query, "fkIdDirector", true);

                query = $"SELECT nombre FROM director WHERE id={director}";
                string directorStr = sqlClass1.SqlQuery(query, "nombre", "");
                cmbUsers.SelectedIndex = cmbUsers.Items.IndexOf(directorStr);
            }

        }

        public void Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clear()
        {
            txtLanguage.Clear();
            txtTitle.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            txtTitle.Select();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ifModify)
            {
                
                int[] ids = VentanaPapel.ids.ToArray();
                string[] personajes = VentanaPapel.personajes.ToArray();
                string dateTemp = dtmTimePicker.SelectionStart.ToString("yyyy-MM-dd");
                int[] idDirector = this.idDirector.ToArray();

                string query = $"UPDATE pelicula SET fkIdDirector=\"{idDirector[cmbUsers.SelectedIndex]}\", nombre=\"{txtTitle.Text}\"," +
                    $" idioma=\"{txtLanguage.Text}\", fechaPublicacíon=\"{dateTemp}\" WHERE id={id} ";

                bool verf = sqlClass1.insertData(query);

                bool verf2 = false;
                for (int i = 0; i < ids.Length; i++)
                {
                    query = $"INSERT INTO papel(fkIdActor, fkIdPelicula, personaje) VALUES ('{ids[i]}', '{id}', " +
                    $"'{personajes[i]}')";
                    verf2 = sqlClass1.insertData(query);
                }

                if (verf && verf2)
                {
                    MessageBox.Show("Los datos han sido actualizados satisfactoriamente");
                }
                else if (!verf2)
                {
                    MessageBox.Show("No se han insertado los papeles");
                }
                else if (!verf && !verf2)
                {
                    MessageBox.Show("Los datos no han sido actualizados satisfactoriamente");
                }

                bool deleter = sqlClass1.deleteData("DELETE FROM papeltemp");

            }
            else
            {
                int[] ids = VentanaPapel.ids.ToArray();
                string[] personajes = VentanaPapel.personajes.ToArray();
                int IdPelicula = 0;
                string dateTemp = dtmTimePicker.SelectionStart.ToString("yyyy-MM-dd");
                int[] idDirector = this.idDirector.ToArray();
                string query = $"INSERT INTO pelicula(fkIdDirector, nombre, idioma, fechaPublicacion)" +
                    $" VALUES ('{idDirector[cmbUsers.SelectedIndex]}', '{txtTitle.Text}', " +
                    $"'{txtLanguage.Text}','{dateTemp}')";

                bool verf = sqlClass1.insertData(query);

                //Consiguiendo la ID de la pelicula
                try
                {
                    query = "SELECT MAX(id) AS id FROM pelicula";
                    IdPelicula = sqlClass1.SqlQuery(query, "id", true);
                }
                catch( Exception )
                {
                    IdPelicula = 1;
                } 
                
                bool verf2 = false;
                for (int i = 0; i < ids.Length; i++)
                {
                    query = $"INSERT INTO papel(fkIdPelicula, fkIdActor, personaje) " +
                        $"VALUES ('{IdPelicula}', '{ids[i]}', " +
                    $"'{personajes[i]}')";
                    verf2 = sqlClass1.insertData(query);
                }

                if (verf && verf2)
                {
                    MessageBox.Show("Los datos han sido insertados satisfactoriamente");
                }
                else if (!verf2)
                {
                    MessageBox.Show("No se han insertado los papeles");
                }
                else if (!verf && !verf2)
                {
                    MessageBox.Show("Los datos no han sido insertados satisfactoriamente");
                }

                bool deleter = sqlClass1.deleteData("DELETE FROM papeltemp");
            }

            this.Close();            

        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            VentanaPapel.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddMovie_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
