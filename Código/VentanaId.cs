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
    public partial class VentanaId : Form
    {
        private sqlClass MySqlClass = new sqlClass("localhost", "root", "", "vmsoftware");
        private string tabla="", clave="", key="";
        private int type;
        private int[] idsArray;
        List<int> ids= new List<int>();

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
            obtenerIds();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Eliminar();
            obtenerIds();
        }

        public void obtenerIds()
        {
            ids= MySqlClass.SqlQuery($"SELECT id FROM {tabla}", "id", 0);
            //Combobox users\
            cmbIds.Items.Clear();


            foreach (int id in ids)
            {
                cmbIds.Items.Add(id);
            }

            cmbIds.Enabled = true;

            idsArray = this.ids.ToArray();
        }


        public VentanaId(int type)
        {
            InitializeComponent();

            Controls.Remove(btnPasarADisponible);
            Controls.Remove(btnPasarANoDisponible);
            Controls.Remove(btnEntregado);
            Controls.Add(btnModificar);

            cmbIds.PlaceHolder = "";
            cmbIds.Text = "";
            cmbIds.ForeColor = Color.Cyan;
            //type 1 = Pelicula
            //type 2 = Director
            //type 3 = Actor
            //type *,1=eliminar
            //type*,2=modificar
            this.type = type;
            if (type == 1)
            {
                Text = "Eliminar película.";
                tabla = "pelicula";
                clave = "Pelicula";
                key = "nombre";
            }
            else if(type == 2)
            {
                Text = "Eliminar director.";
                tabla = "director";
                clave = "Director";
                key = "nombre";
            }
            else if (type == 3)
            {
                Text = "Eliminar actor.";
                tabla = "actor";
                clave = "Actor";
                key = "nombre";
            }
            else if (type == 4)
            {
                Text = "Eliminar papel.";
                tabla = "papel";
                clave = "Papel";
                key = "personaje";
                Controls.Remove(btnModificar);
            }
            else if (type == 5)
            {
                Text = "Eliminar cassette.";
                tabla = "cassette";
                clave = "Cassette";
                key = "	costoRemplazo";

                Controls.Add(btnPasarADisponible);
                Controls.Add(btnPasarANoDisponible);
            }
            else if (type == 6)
            {
                Text = "Eliminar cliente.";
                tabla = "cliente";
                clave = "Cliente";
                key = "nombre";
            }
            else if (type == 7)
            {
                Text = "Eliminar alquiler.";
                tabla = "alquiler";
                clave = "Alquiler";
                key = "	fechaAlquiler";

                Controls.Add(btnEntregado);
            }

            obtenerIds();

        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT fkIdCassette FROM alquiler WHERE id={idsArray[cmbIds.SelectedIndex]}";

                int id = MySqlClass.SqlQuery(query, "fkIdCassette", true);
                if (id == 0)
                {
                    MessageBox.Show($"No Funciona");
                }
                else
                {
                    string disp = "Disponible";
                    query = $"UPDATE cassette SET disponibilidad=\"{disp}\" WHERE id={id} ";
                    bool verf2 = MySqlClass.insertData(query);

                    disp = "Finalizado";
                    query = $"UPDATE alquiler SET estado=\"{disp}\" WHERE id={idsArray[cmbIds.SelectedIndex]} ";
                    verf2 = MySqlClass.insertData(query);

                    if (verf2)
                    {
                        MessageBox.Show($"Se logro...");

                    }
                    else
                    {
                        MessageBox.Show($"No Se logro...");

                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show($"No seleccionó una id.");
            }
            

        }

        private void btnNoDisponible_Click(object sender, EventArgs e)
        {
            try
            {
                int id = idsArray[cmbIds.SelectedIndex];
                string disp2 = "No Disponible";

                string query = $"UPDATE cassette SET disponibilidad=\"{disp2}\" WHERE id = {id} ";
                bool verf2 = MySqlClass.insertData(query);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show($"No seleccionó una id.");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPasarADisponible_Click(object sender, EventArgs e)
        {
            try
            {
                int id = idsArray[cmbIds.SelectedIndex];
                string disp = "Finalizado";
                string disp2 = "Disponible";
                object temp1 = MySqlClass.SqlQuery($"SELECT id FROM alquiler WHERE fkIdCassette= \"{id}\"");
                object temp2 = MySqlClass.SqlQuery($"SELECT id FROM alquiler WHERE fkIdCassette= \"{id}\" AND estado = \"{disp}\"");
                if (temp1 == null)
                {
                    string query = $"UPDATE cassette SET disponibilidad=\"{disp2}\" WHERE id = {id} ";
                    bool verf2 = MySqlClass.insertData(query);
                }
                else if (temp2 == null)
                {
                    string query = $"UPDATE cassette SET disponibilidad=\"{disp2}\" WHERE id = {id} ";
                    bool verf2 = MySqlClass.insertData(query);
                }
                else if (temp2 != null)
                {
                    MessageBox.Show("Ha habido un error, el cassette sigue en un prestamo.");
                }
            }
            catch (IndexOutOfRangeException )
            {
                MessageBox.Show($"No seleccionó una id.");
            }
           
        }

        private void Eliminar()
        {
            try
            {
                string query = $"SELECT {key} FROM {tabla} WHERE id={idsArray[cmbIds.SelectedIndex]}";
                object comparativo = MySqlClass.SqlQuery(query);

                if (comparativo == null)
                {
                    MessageBox.Show($"No existe un registro en la tabla {tabla} con esa id.");
                    this.Close();
                }
                else
                {
                    bool verf = false;
                    bool B = false;
                    if (type == 7)
                    {
                        string disp2 = "Disponible";
                        string estado = MySqlClass.SqlQuery($"SELECT estado FROM alquiler WHERE id \"{idsArray[cmbIds.SelectedIndex]}\"", "estado", "");
                        if (estado == "En curso")
                        {
                            MessageBox.Show("Ha habido un error, no puede eliminar un prestamo aun no finalizado, marcar como entregado primero.");
                            B = true;
                        }
                        else
                        {
                            query = $"SELECT fkIdCassette FROM alquiler WHERE id={idsArray[cmbIds.SelectedIndex]}";
                            int id = MySqlClass.SqlQuery(query, "fkIdCassette", true);
                            query = $"UPDATE cassette SET disponibilidad=\"{disp2}\" WHERE id = {id} ";
                            bool verf2 = MySqlClass.insertData(query);
                            verf = MySqlClass.deleteData($"DELETE FROM {tabla} WHERE id = {idsArray[cmbIds.SelectedIndex]}"); ;
                        }
                    }
                    else
                        verf = MySqlClass.deleteData($"DELETE FROM {tabla} WHERE id = {idsArray[cmbIds.SelectedIndex]}"); ;
                    if (verf)
                    {
                        MessageBox.Show($"{clave} eliminada satisfactoriamente");
                    }
                    else if (!B&&!verf)
                    {
                        MessageBox.Show($"El elemento es imposible de eliminar, dado que seguramente un elemento de otra tabla sea dependiente de él.");

                    }
                }
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show($"No seleccionó una id.");
            }
            

        }

        private void Modificar()
        {
            try
            {
                if (type == 1)
                {
                    AddMovie VentanaMovie = new AddMovie(idsArray[cmbIds.SelectedIndex]);
                    VentanaMovie.ShowDialog();
                }
                else if (type == 2)
                {
                    AddDirector VentanaDirector = new AddDirector(idsArray[cmbIds.SelectedIndex]);
                    VentanaDirector.ShowDialog();
                }
                else if (type == 3)
                {
                    AddActor VentanaActor = new AddActor(idsArray[cmbIds.SelectedIndex]);
                    VentanaActor.ShowDialog();
                }
                else if (type == 4)
                {

                }
                else if (type == 5)
                {
                    AddCassette VentanaCassette = new AddCassette(idsArray[cmbIds.SelectedIndex]);
                    VentanaCassette.ShowDialog();
                }
                else if (type == 6)
                {
                    AddClient VentanaClient = new AddClient(idsArray[cmbIds.SelectedIndex]);
                    VentanaClient.ShowDialog();
                }
                else if (type == 7)
                {
                    AddRent VentanaRenta = new AddRent(idsArray[cmbIds.SelectedIndex]);
                    VentanaRenta.ShowDialog();
                }
            }
            catch (IndexOutOfRangeException )
            {
                MessageBox.Show($"No seleccionó una id. Elija una desde el menú desplegable.");
            }
            
        }
       
    }
}
