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
    public partial class Administracion : Form
    {
        public Administracion()
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

                AdministracionCL admin = new AdministracionCL();
                admin.Nombre = txtNombre.Text;
                admin.Direccion = txtDireccion.Text;
                admin.Telefono = txtTelefono.Text;
                admin.Poblacion = txtPoblacion.Text;
                admin.Provincia = txtProvincia.Text;
                admin.CodigoPostal = txtCodigoPostal.Text;
                admin.NIF = txtNIF.Text;
                admin.NOSS = txtNOSS.Text;


                if (admin.Add())
                {
                    dataGridView1.DataSource = admin.Get();
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
                AdministracionCL admin = new AdministracionCL();        
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        admin.Id = id;
                        dataGridView1.DataSource = admin.GetById();

                        return;
                    }
                }
                else
                {
                    dataGridView1.DataSource = admin.Get();
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
                AdministracionCL admin = new AdministracionCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        admin.Id = id;
                        admin.Nombre = txtNombre.Text;
                        admin.Direccion = txtDireccion.Text;
                        admin.Telefono = txtTelefono.Text;
                        admin.Poblacion = txtPoblacion.Text;
                        admin.Provincia = txtProvincia.Text;
                        admin.CodigoPostal = txtCodigoPostal.Text;
                        admin.NIF = txtNIF.Text;
                        admin.NOSS = txtNOSS.Text;


                        if (admin.Edit())
                        {
                            dataGridView1.DataSource = admin.Get();
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
                AdministracionCL admin = new AdministracionCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        admin.Id = id;
                        if (admin.Delete())
                        {
                            dataGridView1.DataSource = admin.Get();
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
