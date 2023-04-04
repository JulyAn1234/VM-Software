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
    public partial class AddRent : Form
    {
        private Timer T = new Timer();
        private int id;
        private bool ifModify = false;
        private sqlClass sqlClass1 = new sqlClass("localhost", "root", "", "vmsoftware");

        List<int> idCassette = new List<int>();

        List<string> nombreCliente = new List<string>();
        List<int> idCliente = new List<int>();

        private void obtenerNombreCassette()
        {
            idCassette = sqlClass1.SqlQuery("SELECT id FROM cassette", "id", 0);
        }

        private void obtenerNombreCliente()
        {
            nombreCliente = sqlClass1.SqlQuery("SELECT nombre FROM cliente", "nombre");
            idCliente = sqlClass1.SqlQuery("SELECT id FROM cliente", "id", 0);
        }

        public AddRent()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(343, 393);
            cmbCassettes.PlaceHolder = "Cassette";
            cmbCliente.PlaceHolder = "Miembro";

            obtenerNombreCliente();
            obtenerNombreCassette();

            //Combobox users\
            cmbCliente.Items.Clear();
            cmbCassettes.Items.Clear();

            foreach (string name in nombreCliente)
            {
                cmbCliente.Items.Add(name);
            }
            foreach (int id in idCassette)
            {
                cmbCassettes.Items.Add(id);
            }

            cmbCliente.Enabled = true;
            cmbCassettes.Enabled = true;
        }

        public AddRent(int id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(343, 393);
            cmbCassettes.PlaceHolder = "Cassette";
            cmbCliente.PlaceHolder = "Miembro";

            obtenerNombreCliente();
            obtenerNombreCassette();

            ifModify = true;
            this.id = id;

            string query = $"SELECT fechaAlquiler FROM alquiler WHERE id={id}";
            object comparativo = sqlClass1.SqlQuery(query);

            if (comparativo == null)
            {
                MessageBox.Show("No existe un alquiler con esa id.");
                T.Enabled = true;
                T.Tick += new EventHandler(btnCancelar_Click);
                T.Start();
            }
            else
            {
                //Combobox users\
                cmbCliente.Items.Clear();
                cmbCassettes.Items.Clear();

                foreach (string name in nombreCliente)
                {
                    cmbCliente.Items.Add(name);
                }
                foreach (int idi in idCassette)
                {
                    cmbCassettes.Items.Add(idi);
                }

                cmbCliente.Enabled = true;
                cmbCassettes.Enabled = true;

                //Consiguiendo datos...
                
                query = $"SELECT fkIdCassette FROM alquiler WHERE id={id}";
                int cassette = sqlClass1.SqlQuery(query, "fkIdCassette", true);
                cmbCassettes.SelectedIndex = cmbCassettes.Items.IndexOf(cassette);

                query = $"SELECT fkIdCliente FROM alquiler WHERE id={id}";
                int cliente = sqlClass1.SqlQuery(query, "fkIdCliente", true);

                query = $"SELECT nombre FROM cliente WHERE id={cliente}";
                string clienteStr = sqlClass1.SqlQuery(query, "nombre", "");
                cmbCliente.SelectedIndex = cmbCliente.Items.IndexOf(clienteStr);
            }
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ifModify)
            {
                string disp = "No disponible";
                string dateTemp = dtmTimePicker.SelectionStart.ToString("yyyy-MM-dd");
                string dateTemp2 = dtmTimePicker2.SelectionStart.ToString("yyyy-MM-dd");
                int[] idCassette = this.idCassette.ToArray();
                int[] idCliente = this.idCliente.ToArray();

                string query = $"SELECT disponibilidad FROM cassette WHERE id={idCassette[cmbCassettes.SelectedIndex]}"; ;

                string disponibilidad = sqlClass1.SqlQuery(query, "disponibilidad","");
                
                if(disponibilidad != disp)
                {
                    query = $"UPDATE alquiler SET fkIdCliente=\"{idCliente[cmbCliente.SelectedIndex]}\", fkIdCassette=\"{idCassette[cmbCassettes.SelectedIndex]}\"," +
                    $" fechaAlquiler\"{dateTemp}\", fechaVencimiento=\"{dateTemp2}\" WHERE id={id} ";

                    bool verf = sqlClass1.insertData(query);

                    if (verf)
                    {
                        query = $"UPDATE cassette SET disponibilidad=\"{disp}\" WHERE id={id} ";
                        bool verf2 = sqlClass1.insertData(query);
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
                    MessageBox.Show($"El cassette #{idCassette[cmbCassettes.SelectedIndex]} no se encuentra disponible");
                }
                
            }
            else
            {
                string disp = "No disponible";
                string dateTemp = dtmTimePicker.SelectionStart.ToString("yyyy-MM-dd");
                string dateTemp2 = dtmTimePicker2.SelectionStart.ToString("yyyy-MM-dd");
                int[] idCassette = this.idCassette.ToArray();
                int[] idCliente = this.idCliente.ToArray();


                string query = $"SELECT disponibilidad FROM cassette" +
                    $" WHERE id={idCassette[cmbCassettes.SelectedIndex]}"; ;

                string disponibilidad = sqlClass1.SqlQuery(query, "disponibilidad", "");

                if (disponibilidad != disp)
                {
                    query = $"insert into `alquiler` (`fkIdCliente`, `fkIdCassette`" +
                        $", `fechaAlquiler`, `fechaVencimiento`, `estado`) VALUES " +
                        $"( '{idCliente[cmbCliente.SelectedIndex]}', " +
                        $"'{idCassette[cmbCassettes.SelectedIndex]}'," +
                        $" '{dateTemp}', '{dateTemp2}', 'En curso')";
                    bool verf = sqlClass1.insertData(query);

                    if (verf)
                    {
                        query = $"UPDATE cassette SET disponibilidad=\"{disp}\"" +
                            $" WHERE id={idCassette[cmbCassettes.SelectedIndex]} ";
                        bool verf2 = sqlClass1.insertData(query);
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
                    MessageBox.Show($"El cassette " +
                        $"#{idCassette[cmbCassettes.SelectedIndex]} no se encuentra disponible");
                }
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRent_Load(object sender, EventArgs e)
        {

        }
    }
}
