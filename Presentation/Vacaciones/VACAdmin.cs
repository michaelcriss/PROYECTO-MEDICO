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
    public partial class VACAdmin : Form
    {
        public VACAdmin()
        {
            InitializeComponent();
            ListarAdministracion();
            ListarOpciones();
        }

        private void ListarAdministracion()
        {
            VacAdministracionCL vacadmin = new VacAdministracionCL(); 
            cmbAdmin.DataSource = vacadmin.ListarAdministracion();
            cmbAdmin.DisplayMember = "NOMBRE";
            cmbAdmin.ValueMember = "IDADMIN";

        }

        private void ListarOpciones()
        {
            VacAdministracionCL vacadmin = new VacAdministracionCL();
            cmbOpciones.DataSource = vacadmin.ListarOpciones();
            cmbOpciones.DisplayMember = "OPCIONES";
            cmbOpciones.ValueMember = "IDOPCIONESVAC";

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                VacAdministracionCL vacadmin = new VacAdministracionCL();
                vacadmin.IDAdmin = Convert.ToInt32(cmbAdmin.SelectedValue);
                vacadmin.Inicio = Convert.ToString(dtpInicio.Value.Date);
                vacadmin.Final = Convert.ToString(dtpFinal.Value.Date);
                vacadmin.IDOpcionesVac = Convert.ToInt32(cmbOpciones.SelectedValue);


                if (vacadmin.Add())
                {
                    dataGridView1.DataSource = vacadmin.Get();
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
                VacAdministracionCL vacadmin = new VacAdministracionCL();
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int ids = int.Parse(txtId.Text);
                    if (ids > 0)
                    {
                        vacadmin.Id = ids;
                        dataGridView1.DataSource = vacadmin.GetById();

                        return;
                    }
                }
                else
                {
                    dataGridView1.DataSource = vacadmin .Get();
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
                VacAdministracionCL vacadmin = new VacAdministracionCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    vacadmin.IDAdmin = Convert.ToInt32(cmbAdmin.SelectedValue);
                    vacadmin.Inicio = Convert.ToString(dtpInicio.Value.Date);
                    vacadmin.Final = Convert.ToString(dtpFinal.Value.Date);
                    vacadmin.IDOpcionesVac = Convert.ToInt32(cmbOpciones.SelectedValue);

                    if (id > 0)
                    {
                        vacadmin.Id = id;

                        if (vacadmin.Edit())
                        {
                            dataGridView1.DataSource = vacadmin.Get();
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
                VacAdministracionCL vacadmin = new VacAdministracionCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        vacadmin.Id = id;
                        if (vacadmin.Delete())
                        {
                            dataGridView1.DataSource = vacadmin.Get();
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

        private void btnPlanificadas_Click(object sender, EventArgs e)
        {
            try
            {
                VacAdministracionCL vacadmin = new VacAdministracionCL();
                int id = 1;
                vacadmin.IDOpcionesVac = id;
                dataGridView1.DataSource = vacadmin.GetByPlanificadas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDisfrutadas_Click(object sender, EventArgs e)
        {
            try
            {
                VacAdministracionCL vacadmin = new VacAdministracionCL();
                int id = 2;
                vacadmin.IDOpcionesVac = id;
                dataGridView1.DataSource = vacadmin.GetByDisfrutar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
