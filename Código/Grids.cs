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
    public partial class Grids : Form
    {
        private int type;
        private string tabla;
        private sqlClass MySqlClass = new sqlClass("localhost", "root", "", "vmsoftware");
        private VentanaId ContenidoVentanaId;
        private void AbrirFormaHija(ref Panel panel,object formahija)
        {
            if (panel.Controls.Count > 0)
                panel.Controls.RemoveAt(0);
            Form fh = formahija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panel.Controls.Add(fh);
            panel.Tag = fh;
            fh.Show();

        }


        public Grids(int type)
        {
            InitializeComponent();
            this.type = type;
            string Path = System.IO.Directory.GetCurrentDirectory();
            ContenidoVentanaId = new VentanaId(type);

            AbrirFormaHija(ref panVenatanId, ContenidoVentanaId);
            if (type != 4)
            {
                btnAgregar.Image = Image.FromFile($"{Path}/src/Imagenes/Iconos/imgAgregar.png");
                btnRecargar.Image = Image.FromFile($"{Path}/src/Imagenes/Iconos/imgRecargar.png");

                ttAgregar.SetToolTip(btnAgregar, "Agregar un elemento.");
                ttRecargar.SetToolTip(btnRecargar, "Actualizar data grid.");
            }
            else
            {

                btnRecargar.Image = Image.FromFile($"{Path}/src/Imagenes/Iconos/imgRecargar.png");

                ttRecargar.SetToolTip(btnRecargar, "Actualizar data grid.");
            }

            //type 1 = Pelicula
            //Type 2 = Director
            //type 3 = actor
            //type 4 = papeles

            this.Controls.Add(btnAgregar);

            if (type == 1)
            {
                tabla = "pelicula";
                lblTitulo.Text = "Películas";
                Size s = new Size(panVenatanId.Width, 113);
                panVenatanId.Size=s;
            }
            else if (type == 2)
            {
                tabla = "director";
                lblTitulo.Text = "Directores";
                Size s = new Size(panVenatanId.Width, 113);
                panVenatanId.Size = s;
            }
            else if (type == 3)
            {
                tabla = "actor";
                lblTitulo.Text = "Actores";
                Size s = new Size(panVenatanId.Width, 113);
                panVenatanId.Size = s;
            }
            else if (type == 4)
            {
                tabla = "papel";
                lblTitulo.Text = "Papeles";
                Size s = new Size(panVenatanId.Width, 113);
                panVenatanId.Size = s;
                this.Controls.Remove(btnAgregar);
            }
            else if (type == 5)
            {
                tabla = "cassette";
                lblTitulo.Text = "Cassettes";
            }
            else if (type == 6)
            {
                tabla = "cliente";
                lblTitulo.Text = "Miembros";
                Size s = new Size(panVenatanId.Width, 113);
                panVenatanId.Size = s;
            }
            else
            {
                tabla = "alquiler";
                lblTitulo.Text = "Prestamos";
            }

            dataGridView1.DataSource = MySqlClass.sqlQueryGridView($"SELECT * FROM {tabla}").Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
           // VentanaEliminar = new mainWindowFuncDeactivate(type,1);
           // VentanaEliminar.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (type == 1)
            {
                AddMovie VentanaMovie = new AddMovie();
                VentanaMovie.ShowDialog();
            }
            else if (type == 2)
            {
                AddDirector VentanaDirector = new AddDirector();
                VentanaDirector.ShowDialog();
            }
            else if (type == 3)
            {
                AddActor VentanaActor = new AddActor();
                VentanaActor.ShowDialog();
            }
            else if(type == 4)
            {
            }
            else if (type == 5)
            {
                AddCassette VentanaCassette = new AddCassette();
                VentanaCassette.ShowDialog();
            }
            else if (type == 6)
            {
                AddClient VentanaClient = new AddClient();
                VentanaClient.ShowDialog();
            }
            else
            {
                AddRent VentanaRent = new AddRent();
                VentanaRent.ShowDialog();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           // VentanaModificar = new mainWindowFuncDeactivate(type, 2);
           // VentanaModificar.ShowDialog();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MySqlClass.sqlQueryGridView($"SELECT * FROM {tabla}").Tables[0];
            ContenidoVentanaId.obtenerIds();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}
