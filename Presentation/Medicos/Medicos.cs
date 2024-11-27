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
    public partial class Medicos : Form
    {
        public Medicos()
        {
            InitializeComponent();
            ListarEstado();
        }
        private void Avion_Load(object sender, EventArgs e)
        {
            // ListarBaseMantenimiento();

        }
        /*  private void ListarBaseMantenimiento()
          {
              Aviones avios = new Aviones();
              cmbBase.DataSource = avios.ListarBase();
              cmbBase.DisplayMember = "Base";
              cmbBase.ValueMember = "IDBASE";
          }*/

        private void ListarEstado()
        {
            Medico medicos = new Medico();
            cmbTipo.DataSource = medicos.ListarEstado();
            cmbTipo.DisplayMember = "ESTADO";
            cmbTipo.ValueMember = "IDESTADO";

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                Medico medicos = new Medico();
                medicos.Nombre = txtNombre.Text;
                medicos.Direccion = txtDireccion.Text;
                medicos.Telefono = txtTelefono.Text;
                medicos.Poblacion = txtPoblacion.Text;
                medicos.Provincia = txtProvincia.Text;
                medicos.CodigoPostal = txtCodigoPostal.Text;
                medicos.NIF = txtNIF.Text;
                medicos.NUMSS = txtNOSS.Text;
                medicos.NOCOLEGIADO = txtColegiado.Text;
                medicos.TIPO = Convert.ToString(cmbTipo.SelectedValue);


                if (medicos.Add())
                {
                    dataGridView1.DataSource = medicos.Get();
                    MessageBox.Show("Los datos fueron registrado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medicos = new Medico();
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        medicos.Id = id;
                        dataGridView1.DataSource = medicos.GetById();

                        return;
                    }
                }
                else
                {
                    dataGridView1.DataSource = medicos.Get();
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
                Medico medicos = new Medico();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        medicos.Id = id;
                        medicos.Nombre = txtNombre.Text;
                        medicos.Direccion = txtDireccion.Text;
                        medicos.Telefono = txtTelefono.Text;
                        medicos.Poblacion = txtPoblacion.Text;
                        medicos.Provincia = txtProvincia.Text;
                        medicos.CodigoPostal = txtCodigoPostal.Text;
                        medicos.NIF = txtNIF.Text;
                        medicos.NUMSS = txtNOSS.Text;
                        medicos.NOCOLEGIADO = txtColegiado.Text;
                        medicos.TIPO = Convert.ToString(cmbTipo.SelectedValue);
                        if (medicos.Edit())
                        {
                            dataGridView1.DataSource = medicos.Get();
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
                Medico medicos = new Medico();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        medicos.Id = id;
                        if (medicos.Delete())
                        {
                            dataGridView1.DataSource = medicos.Get();
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}

