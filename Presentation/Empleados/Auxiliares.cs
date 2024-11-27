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
    public partial class Auxiliares : Form
    {
        public Auxiliares()
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

                AuxiliarCL aux = new AuxiliarCL();
                aux.Nombre = txtNombre.Text;
                aux.Direccion = txtDireccion.Text;
                aux.Telefono = txtTelefono.Text;
                aux.Poblacion = txtPoblacion.Text;
                aux.Provincia = txtProvincia.Text;
                aux.CodigoPostal = txtCodigoPostal.Text;
                aux.NIF = txtNIF.Text;
                aux.NOSS = txtNOSS.Text;


                if (aux.Add())
                {
                    dataGridView1.DataSource = aux.Get();
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
                AuxiliarCL aux = new AuxiliarCL();
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        aux.Id = id;
                        dataGridView1.DataSource = aux.GetById();

                        return;
                    }
                }
                else
                {
                    dataGridView1.DataSource = aux.Get();
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
                AuxiliarCL aux = new AuxiliarCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        aux.Id = id;
                        aux.Nombre = txtNombre.Text;
                        aux.Direccion = txtDireccion.Text;
                        aux.Telefono = txtTelefono.Text;
                        aux.Poblacion = txtPoblacion.Text;
                        aux.Provincia = txtProvincia.Text;
                        aux.CodigoPostal = txtCodigoPostal.Text;
                        aux.NIF = txtNIF.Text;
                        aux.NOSS = txtNOSS.Text;


                        if (aux.Edit())
                        {
                            dataGridView1.DataSource = aux.Get();
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
                AuxiliarCL aux = new AuxiliarCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        aux.Id = id;
                        if (aux.Delete())
                        {
                            dataGridView1.DataSource = aux.Get();
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
