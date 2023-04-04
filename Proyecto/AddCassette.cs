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

    public partial class AddCassette : Form
    {
        private Timer T = new Timer();
        private int id;
        private bool ifModify = false;
        private sqlClass sqlClass1 = new sqlClass("localhost", "root", "", "vmsoftware");

        List<string> nombrePelicula = new List<string>();
        List<int> idPelicula = new List<int>();

        private void obtenerNombrePelicula()
        {
            nombrePelicula = sqlClass1.SqlQuery("SELECT nombre FROM pelicula", "nombre");
            idPelicula = sqlClass1.SqlQuery("SELECT id FROM pelicula", "id", 0);
        }
        public AddCassette()
        {
            InitializeComponent(); 
            StartPosition = FormStartPosition.Manual;
            Location = new Point(343, 393);
            txtCostoRemplazo.PlaceHolder = "Costo de Remplazo";
            cmbPelicula.PlaceHolder = "Película";

            obtenerNombrePelicula();

            //Combobox users\
            cmbPelicula.Items.Clear();

            foreach (string name in nombrePelicula)
            {
                cmbPelicula.Items.Add(name);
            }

            cmbPelicula.Enabled = true;
        }

        public AddCassette(int id)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(343, 393);

            txtCostoRemplazo.PlaceHolder = "Costo de Remplazo";
            cmbPelicula.PlaceHolder = "Película";

            obtenerNombrePelicula();

            ifModify = true;
            this.id = id;

            string query = $"SELECT disponibilidad FROM cassette WHERE id={id}";
            object comparativo = sqlClass1.SqlQuery(query);

            if (comparativo == null)
            {
                MessageBox.Show("No existe un cassette con esa id.");
                T.Enabled = true;
                T.Tick += new EventHandler(btnCancelar_Click);
                T.Start();
            }
            else
            {
                foreach (string name in nombrePelicula)
                {
                    cmbPelicula.Items.Add(name);
                }

                cmbPelicula.Enabled = true;

                //Consiguiendo datos...
                query = $"SELECT costoRemplazo FROM cassette WHERE id={id}";
                txtCostoRemplazo.Text = sqlClass1.SqlQuery(query, "costoRemplazo", "");

                query = $"SELECT fkIdPelicula FROM cassette WHERE id={id}";
                int pelicula = sqlClass1.SqlQuery(query, "fkIdPelicula", true);

                query = $"SELECT nombre FROM pelicula WHERE id={pelicula}";
                string peliculaStr = sqlClass1.SqlQuery(query, "nombre", "");
                cmbPelicula.SelectedIndex = cmbPelicula.Items.IndexOf(peliculaStr);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ifModify)
            {
                string dateTemp = dtmTimePicker.SelectionStart.ToString("yyyy-MM-dd");
                int[] idPelicula = this.idPelicula.ToArray();

                string query = $"UPDATE cassette SET fkIdPelicula=\"{idPelicula[cmbPelicula.SelectedIndex]}\", costoRemplazo=\"{txtCostoRemplazo.Text}\"," +
                    $" fechaAdquisicion=\"{dateTemp}\" WHERE id={id} ";

                bool verf = sqlClass1.insertData(query);

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
            else
            {
                string dateTemp = dtmTimePicker.SelectionStart.ToString("yyyy-MM-dd");
                int[] idPelicula = this.idPelicula.ToArray();

                /*string query = $"INSERT INTO cassette(fkIdPelicula,disponibilidad, costoRemplazo, costoRenta, fechaAdquisicion)" +
                     $" VALUES ('{idPelicula[cmbPelicula.SelectedIndex]}','Disponible', '{Single.Parse(txtCostoRemplazo.Text)}', '{Single.Parse(txtCostoRenta.Text)}'" +
                     $"'{dateTemp}')";*/
                
                string query = $"INSERT INTO `cassette` (`fkIdPelicula`, `disponibilidad`, `costoRemplazo`, `fechaAdquisicion`) VALUES ( '{idPelicula[cmbPelicula.SelectedIndex]}', 'Disponible', '{Single.Parse(txtCostoRemplazo.Text)}', '{dateTemp}')";
                bool verf = sqlClass1.insertData(query);

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
        }
    }
}
