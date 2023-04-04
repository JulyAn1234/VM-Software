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
    public partial class AddActor : Form
    {
        private Timer T = new Timer();
        private int id;
        private bool ifModify = false;
        private sqlClass sqlClass1 = new sqlClass("localhost", "root", "", "vmsoftware");

        public AddActor()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(343, 393);

            txtNacionalidad.PlaceHolder = "Nacionalidad";
            txtNombre.PlaceHolder = "Nombre";

            StartPosition = FormStartPosition.Manual;
            Location = new Point(343, 393);
        }
        public AddActor(int id)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(343, 393);

            StartPosition = FormStartPosition.Manual;
            Location = new Point(343, 393);
            txtNacionalidad.PlaceHolder = "Nacionalidad";
            txtNombre.PlaceHolder = "Nombre";
            this.id = id;
            ifModify = true;
            string query = $"SELECT nombre FROM actor WHERE id={id}";
            object comparativo = sqlClass1.SqlQuery(query);

            if (comparativo == null)
            {
                MessageBox.Show("No existe un director con esa id.");
                T.Enabled = true;
                T.Tick += new EventHandler(Cerrar);
                T.Start();
            }
            else
            {
                query = $"SELECT nacionalidad FROM actor WHERE id={id}";
                txtNacionalidad.Text = sqlClass1.SqlQuery(query, "nacionalidad", "");

                query = $"SELECT nombre FROM actor WHERE id={id}";
                txtNombre.Text = sqlClass1.SqlQuery(query, "nombre", "");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Clear()
        {
            txtNombre.Text="Nombre";
            txtNacionalidad.Text= "Nacionalidad";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (ifModify)
            {
                string dateTemp = dtmTimePicker.SelectionStart.ToString("yyyy-MM-dd");
                string query = $"UPDATE actor  SET nombre=\"{txtNombre.Text}\", nacionalidad=\"{txtNacionalidad.Text}\", fechaNacimiento=\"{dateTemp}\" WHERE id={id}";
                bool verf = sqlClass1.insertData(query);

                if (verf)
                {
                    MessageBox.Show("Los datos han sido actualizados satisfactoriamente");
                }
                else if (!verf)
                {
                    MessageBox.Show("Los datos no han sido actualizados satisfactoriamente");
                }
            }
            else
            {
                string dateTemp = dtmTimePicker.SelectionStart.ToString("yyyy-MM-dd");
                string query = $"INSERT INTO actor(nombre, nacionalidad, fechaNacimiento) VALUES " +
                    $"('{txtNombre.Text}', '{txtNacionalidad.Text}', '{dateTemp}')";
                bool verf = sqlClass1.insertData(query);

                if (verf)
                {
                    MessageBox.Show("Los datos han sido insertados satisfactoriamente");
                }
                else if (!verf)
                {
                    MessageBox.Show("Los datos no han sido insertados satisfactoriamente");
                }
            }

            this.Close();
        }

        private void txtSummary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
