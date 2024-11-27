using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Celadores : Form
    {
        public Celadores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                CeladoresCL celadores = new CeladoresCL();
                celadores.Nombre = txtNombre.Text;
                celadores.Direccion = txtDireccion.Text;
                celadores.Telefono = txtTelefono.Text;
                celadores.Poblacion = txtPoblacion.Text;
                celadores.Provincia = txtProvincia.Text;
                celadores.CodigoPostal = txtCodigoPostal.Text;
                celadores.NIF = txtNIF.Text;
                celadores.NOSS = txtNOSS.Text;


                if (celadores.Add())
                {
                    dataGridView1.DataSource = celadores.Get();
                    MessageBox.Show("Los datos fueron registrado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                CeladoresCL celadores = new CeladoresCL();
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        celadores.Id = id;
                        dataGridView1.DataSource = celadores.GetById();

                        return;
                    }
                }
                else
                {
                    dataGridView1.DataSource = celadores.Get();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                CeladoresCL celadores = new CeladoresCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        celadores.Id = id;
                        celadores.Nombre = txtNombre.Text;
                        celadores.Direccion = txtDireccion.Text;
                        celadores.Telefono = txtTelefono.Text;
                        celadores.Poblacion = txtPoblacion.Text;
                        celadores.Provincia = txtProvincia.Text;
                        celadores.CodigoPostal = txtCodigoPostal.Text;
                        celadores.NIF = txtNIF.Text;
                        celadores.NOSS = txtNOSS.Text;


                        if (celadores.Edit())
                        {
                            dataGridView1.DataSource = celadores.Get();
                            MessageBox.Show("Los datos fueron actualizados correctamente");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                CeladoresCL celadores = new CeladoresCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        celadores.Id = id;
                        if (celadores.Delete())
                        {
                            dataGridView1.DataSource = celadores.Get();
                            MessageBox.Show("Los datos fueron eliminados correctamente");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
