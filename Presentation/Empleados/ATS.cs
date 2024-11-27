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
    public partial class ATS : Form
    {
        public ATS()
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

                ATScl ats = new ATScl();
                ats.Nombre = txtNombre.Text;
                ats.Direccion = txtDireccion.Text;
                ats.Telefono = txtTelefono.Text;
                ats.Poblacion = txtPoblacion.Text;
                ats.Provincia = txtProvincia.Text;
                ats.CodigoPostal = txtCodigoPostal.Text;
                ats.NIF = txtNIF.Text;
                ats.NOSS = txtNOSS.Text;


                if (ats.Add())
                {
                    dataGridView1.DataSource = ats.Get();
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
                ATScl ats = new ATScl();
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        ats.Id = id;
                        dataGridView1.DataSource = ats.GetById();

                        return;
                    }
                }
                else
                {
                    dataGridView1.DataSource = ats.Get();
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
                ATScl ats = new ATScl();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        ats.Id = id;
                        ats.Nombre = txtNombre.Text;
                        ats.Direccion = txtDireccion.Text;
                        ats.Telefono = txtTelefono.Text;
                        ats.Poblacion = txtPoblacion.Text;
                        ats.Provincia = txtProvincia.Text;
                        ats.CodigoPostal = txtCodigoPostal.Text;
                        ats.NIF = txtNIF.Text;
                        ats.NOSS = txtNOSS.Text;


                        if (ats.Edit())
                        {
                            dataGridView1.DataSource = ats.Get();
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
                ATScl ats = new ATScl();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        ats.Id = id;
                        if (ats.Delete())
                        {
                            dataGridView1.DataSource = ats.Get();
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

