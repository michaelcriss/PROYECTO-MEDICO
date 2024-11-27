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
    public partial class VACATSZona : Form
    {
        public VACATSZona()
        {
            InitializeComponent();
            ListarATSZonas();
            ListarOpciones();
        }

        private void ListarATSZonas()
        {
            VacATSZonaCL atszona = new VacATSZonaCL();
            cmbATSZona.DataSource = atszona.ListarAtsZona();
            cmbATSZona.DisplayMember = "NOMBRE";
            cmbATSZona.ValueMember = "IDATSZONA";

        }

        private void ListarOpciones()
        {
            VacATSZonaCL atszona = new VacATSZonaCL();
            cmbOpciones.DataSource = atszona.ListarOpciones();
            cmbOpciones.DisplayMember = "OPCIONES";
            cmbOpciones.ValueMember = "IDOPCIONESVAC";

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                VacATSZonaCL atszona = new VacATSZonaCL();
                atszona.IDATSZona = Convert.ToInt32(cmbATSZona.SelectedValue);
                atszona.Inicio = Convert.ToString(dtpInicio.Value.Date);
                atszona.Final = Convert.ToString(dtpFinal.Value.Date);
                atszona.IDOpcionesVac = Convert.ToInt32(cmbOpciones.SelectedValue);


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
                VacATSZonaCL atszona = new VacATSZonaCL();
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int ids = int.Parse(txtId.Text);
                    if (ids > 0)
                    {
                        atszona.Id = ids;
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
                VacATSZonaCL atszona = new VacATSZonaCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    atszona.IDATSZona = Convert.ToInt32(cmbATSZona.SelectedValue);
                    atszona.Inicio = Convert.ToString(dtpInicio.Value.Date);
                    atszona.Final = Convert.ToString(dtpFinal.Value.Date);
                    atszona.IDOpcionesVac = Convert.ToInt32(cmbOpciones.SelectedValue);
                    if (id > 0)
                    {
                        atszona.Id = id;

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
                VacATSZonaCL atszona = new VacATSZonaCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        atszona.Id = id;
                        if (atszona.Delete())
                        {
                            dataGridView1.DataSource =  atszona.Get();
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
                VacATSZonaCL atszona = new VacATSZonaCL();
                int id = 1;
                atszona.IDOpcionesVac = id;
                dataGridView1.DataSource = atszona.GetByPlanificadas();
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
                VacATSZonaCL atszona = new VacATSZonaCL();
                int id = 2;
                atszona.IDOpcionesVac = id;
                dataGridView1.DataSource = atszona.GetByPlanificadas();
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
