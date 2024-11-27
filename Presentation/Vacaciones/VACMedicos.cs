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
    public partial class VACMedicos : Form
    {
        public VACMedicos()
        {
            InitializeComponent();
            ListarMedicos();
            ListarOpciones();
        }

        private void ListarMedicos()
        {
            VacMedicosCL medicos = new VacMedicosCL();
            cmbATS.DataSource = medicos.ListarEstado();
            cmbATS.DisplayMember = "NOMBRE";
            cmbATS.ValueMember = "IDMEDICO";

        }

        private void ListarOpciones()
        {
            VacMedicosCL medicos = new VacMedicosCL();
            cmbOpciones.DataSource = medicos.ListarOpciones();
            cmbOpciones.DisplayMember = "OPCIONES";
            cmbOpciones.ValueMember = "IDOPCIONESVAC";

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                VacMedicosCL medicos = new VacMedicosCL();
                medicos.IDMedico = Convert.ToInt32(cmbATS.SelectedValue);
                medicos.Inicio = Convert.ToString(dtpInicio.Value.Date);
                medicos.Final = Convert.ToString(dtpFinal.Value.Date);
                medicos.IDOpcionesVac = Convert.ToInt32(cmbOpciones.SelectedValue);


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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                VacMedicosCL medicos = new VacMedicosCL();
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int ids = int.Parse(txtId.Text);
                    if (ids > 0)
                    {
                        medicos.Id = ids;
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
                VacMedicosCL medicos = new VacMedicosCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    medicos.IDMedico = Convert.ToInt32(cmbATS.SelectedValue);
                    medicos.Inicio = Convert.ToString(dtpInicio.Value.Date);
                    medicos.Final = Convert.ToString(dtpFinal.Value.Date);
                    medicos.IDOpcionesVac = Convert.ToInt32(cmbOpciones.SelectedValue);
                    if (id > 0)
                    {
                        medicos.Id = id;

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
                VacMedicosCL medicos = new VacMedicosCL();

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

        private void btnPlanificadas_Click(object sender, EventArgs e)
        {
            try
            {
                VacMedicosCL medicos = new VacMedicosCL();
                int id = 1;
                medicos.IDOpcionesVac = id;
                dataGridView1.DataSource = medicos.GetByDisfrutar();

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
                VacMedicosCL medicos = new VacMedicosCL();
                int id = 2;
                medicos.IDOpcionesVac = id;
                dataGridView1.DataSource = medicos.GetByPlanificadas();
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
