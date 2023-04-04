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
    public partial class AddClient : Form
    {
        private Timer T = new Timer();
        private int id;
        private bool ifModify = false;
        private sqlClass sqlClass1 = new sqlClass("localhost", "root", "", "vmsoftware");

        public AddClient()
        {
            InitializeComponent();
            txtNombre.PlaceHolder = "Nombre"; 
            StartPosition = FormStartPosition.Manual;
            Location = new Point(343, 393);
        }


        public AddClient(int id)
        {
            InitializeComponent();
            txtNombre.PlaceHolder = "Nombre";
            StartPosition = FormStartPosition.Manual;
            Location = new Point(343, 393);
            this.id = id;
            ifModify = true;
            string query = $"SELECT nombre FROM cliente WHERE id={id}";
            object comparativo = sqlClass1.SqlQuery(query);

            if (comparativo == null)
            {
                MessageBox.Show("No existe un cliente con esa id.");
                T.Enabled = true;
                T.Tick += new EventHandler(btnCancelar_Click);
                T.Start();
            }
            else
            {
                query = $"SELECT nombre FROM cliente WHERE id={id}";
                txtNombre.Text = sqlClass1.SqlQuery(query, "nombre", "");
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
                string dateTemp2 = dtmTimePicker2.SelectionStart.ToString("yyyy-MM-dd");
                string query = $"UPDATE director SET nombre=\"{txtNombre.Text}\", fechaRegistro=\"{dateTemp}\", fechaNacimiento=\"{dateTemp2}\" WHERE id={id}";
                bool verf = sqlClass1.insertData(query);

                if (verf)
                {
                    MessageBox.Show("Los datos han sido actualizados satisfactoriamente");
                }
                else if (!verf)
                {
                    MessageBox.Show("Los datos no han sido actualizados satisfactoriamente");
                }
                this.Close();
            }
            else
            {
                string dateTemp = dtmTimePicker.SelectionStart.ToString("yyyy-MM-dd");
                string dateTemp2 = dtmTimePicker2.SelectionStart.ToString("yyyy-MM-dd");
                string query = $"INSERT INTO cliente(nombre, fechaRegistro, fechaNacimiento	)" +
                    $" VALUES ('{txtNombre.Text}', " +
                    $"'{dateTemp}','{dateTemp2}')";


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
