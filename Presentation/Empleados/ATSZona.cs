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
    public partial class ATSZona : Form
    {
        public ATSZona()
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

                ATSZonaCL atszona = new ATSZonaCL();
                atszona.Nombre = txtNombre.Text;
                atszona.Direccion = txtDireccion.Text;
                atszona.Telefono = txtTelefono.Text;
                atszona.Poblacion = txtPoblacion.Text;
                atszona.Provincia = txtProvincia.Text;
                atszona.CodigoPostal = txtCodigoPostal.Text;
                atszona.NIF = txtNIF.Text;
                atszona.NOSS = txtNOSS.Text;


                if (atszona.Add())
                {
                    dataGridView1.DataSource = atszona.Get();
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
                ATSZonaCL atszona = new ATSZonaCL();
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        atszona.Id = id;
                        dataGridView1.DataSource = atszona.GetById();

                        return;
                    }
                }
                else
                {
                    dataGridView1.DataSource = atszona.Get();
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
                ATSZonaCL atszona = new ATSZonaCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        atszona.Id = id;
                        atszona.Nombre = txtNombre.Text;
                        atszona.Direccion = txtDireccion.Text;
                        atszona.Telefono = txtTelefono.Text;
                        atszona.Poblacion = txtPoblacion.Text;
                        atszona.Provincia = txtProvincia.Text;
                        atszona.CodigoPostal = txtCodigoPostal.Text;
                        atszona.NIF = txtNIF.Text;
                        atszona.NOSS = txtNOSS.Text;


                        if (atszona.Edit())
                        {
                            dataGridView1.DataSource = atszona.Get();
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
                ATSZonaCL atszona = new ATSZonaCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        atszona.Id = id;
                        if (atszona.Delete())
                        {
                            dataGridView1.DataSource = atszona.Get();
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
