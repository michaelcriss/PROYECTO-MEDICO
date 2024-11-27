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
    public partial class VACATS : Form
    {
        public VACATS()
        {
            InitializeComponent();
            ListarATS();
            ListarOpciones();
        }

        private void ListarATS()
        {
            VacAtsCL vacats = new VacAtsCL(); ;
            cmbATS.DataSource = vacats.ListarEstado();
            cmbATS.DisplayMember = "NOMBRE";
            cmbATS.ValueMember = "IDATS";

        }

        private void ListarOpciones()
        {
            VacAtsCL vacats = new VacAtsCL(); ;
            cmbOpciones.DataSource = vacats.ListarOpciones();
            cmbOpciones.DisplayMember = "OPCIONES";
            cmbOpciones.ValueMember = "IDOPCIONESVAC";

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                VacAtsCL vacats = new VacAtsCL();
                vacats.IDATS = Convert.ToInt32(cmbATS.SelectedValue);
                vacats.Inicio = Convert.ToString(dtpInicio.Value.Date);
                vacats.Final = Convert.ToString(dtpFinal.Value.Date);
                vacats.IDOpcionesVac = Convert.ToInt32(cmbOpciones.SelectedValue);


                if (vacats.Add())
                {
                    dataGridView1.DataSource = vacats.Get();
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
                VacAtsCL vacats = new VacAtsCL();
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int ids = int.Parse(txtId.Text);
                    if (ids > 0)
                    {
                        vacats.Id = ids;
                        dataGridView1.DataSource = vacats.GetById();

                        return;
                    }
                }
                else
                {
                    dataGridView1.DataSource = vacats.Get();
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
                VacAtsCL vacats = new VacAtsCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    vacats.IDATS = Convert.ToInt32(cmbATS.SelectedValue);
                    vacats.Inicio = Convert.ToString(dtpInicio.Value.Date);
                    vacats.Final = Convert.ToString(dtpFinal.Value.Date);
                    vacats.IDOpcionesVac = Convert.ToInt32(cmbOpciones.SelectedValue);
                    if (id > 0)
                    {
                        vacats.Id = id;

                        if (vacats.Edit())
                        {
                            dataGridView1.DataSource = vacats.Get();
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
                VacAtsCL vacats = new VacAtsCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        vacats.Id = id;
                        if (vacats.Delete())
                        {
                            dataGridView1.DataSource = vacats.Get();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisfrutadas_Click(object sender, EventArgs e)
        {
            try
            {
                VacAtsCL vacats = new VacAtsCL();
                int id = 2;
                vacats.IDOpcionesVac = id;
                dataGridView1.DataSource = vacats.GetByDisfrutar();

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
                VacAtsCL vacats = new VacAtsCL();
                int id = 1;
                vacats.IDOpcionesVac = id;
                dataGridView1.DataSource = vacats.GetByPlanificadas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
