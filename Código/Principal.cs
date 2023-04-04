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
    public partial class Principal : Form
    {
        public Principal()
        {

            InitializeComponent();
            //Consiguiendo el path
            StartPosition = FormStartPosition.Manual;
            Location = new Point(120, 75);
            string Path = System.IO.Directory.GetCurrentDirectory();

            pbMarca.Image = Image.FromFile($"{Path}/src/Imagenes/Iconos/imgMarca.png");
            pbClose.Image=Image.FromFile($"{Path}/src/Imagenes/Iconos/imgClose.png");
            pbMinimize.Image = Image.FromFile($"{Path}/src/Imagenes/Iconos/imgMinimize.png");/*
            btnInicio.Image = Image.FromFile($"{Path}/src/Imagenes/Iconos/imgInicio.png");
            btnFichas.Image = Image.FromFile($"{Path}/src/Imagenes/Iconos/imgFichas.png");*/
            /*btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnFichas.ImageAlign = ContentAlignment.MiddleLeft;*/


            //AbrirFormaHija(new Inicio());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void AbrirFormaHija (object formahija)
        {
            if (this.panContenido.Controls.Count > 0)
                this.panContenido.Controls.RemoveAt(0);
            Form fh = formahija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panContenido.Controls.Add(fh);
            this.panContenido.Tag = fh;
            fh.Show();

        }

        private void btnPelicula_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new Grids(1));
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new Grids(2));
        }

        private void btnActor_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new Grids(3));
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new Grids(4));
        }

        private void btnCassette_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new Grids(5));
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new Grids(6));
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new Grids(7));
        }

        
    }
}
