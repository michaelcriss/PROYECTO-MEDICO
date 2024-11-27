using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class VACAuxiliar : Form
    {
        public VACAuxiliar()
        {
            InitializeComponent();
        }

        private void VACAuxiliar_Load(object sender, EventArgs e)
        {
            ListarAuxiliar();
            ListarOpciones();

        }

        private void ListarAuxiliar()
        {
            VacAuxiliarCL auxiliar = new VacAuxiliarCL();
            cmbAuxiliar.DataSource = auxiliar.ListarAuxiliares();
            cmbAuxiliar.DisplayMember = "NOMBRE";
            cmbAuxiliar.ValueMember = "IDAUXILIAR";

        }

        private void ListarOpciones()
        {
            VacAuxiliarCL auxiliar = new VacAuxiliarCL();
            cmbOpciones.DataSource = auxiliar.ListarOpciones();
            cmbOpciones.DisplayMember = "OPCIONES";
            cmbOpciones.ValueMember = "IDOPCIONESVAC";

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                VacAuxiliarCL auxiliar = new VacAuxiliarCL();
                auxiliar.IDAuxiliar = Convert.ToInt32(cmbAuxiliar.SelectedValue);
                auxiliar.Inicio = Convert.ToString(dtpInicio.Value.Date);
                auxiliar.Final = Convert.ToString(dtpFinal.Value.Date);
                auxiliar.IDOpcionesVac = Convert.ToInt32(cmbOpciones.SelectedValue);


                if (auxiliar.Add())
                {
                    dataGridView1.DataSource = auxiliar.Get();
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
                VacAuxiliarCL auxiliar = new VacAuxiliarCL();
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int ids = int.Parse(txtId.Text);
                    if (ids > 0)
                    {
                        auxiliar.Id = ids;
                        dataGridView1.DataSource = auxiliar.GetById();

                        return;
                    }
                }
                else
                {
                    dataGridView1.DataSource = auxiliar.Get();
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
                VacAuxiliarCL auxiliar = new VacAuxiliarCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    auxiliar.IDAuxiliar = Convert.ToInt32(cmbAuxiliar.SelectedValue);
                    auxiliar.Inicio = Convert.ToString(dtpInicio.Value.Date);
                    auxiliar.Final = Convert.ToString(dtpFinal.Value.Date);
                    auxiliar.IDOpcionesVac = Convert.ToInt32(cmbOpciones.SelectedValue);
                    if (id > 0)
                    {
                            auxiliar.Id = id;

                        if (auxiliar.Edit())
                        {
                            dataGridView1.DataSource = auxiliar.Get();
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
                VacAuxiliarCL auxiliar = new VacAuxiliarCL();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        auxiliar.Id = id;
                        if (auxiliar.Delete())
                        {
                            dataGridView1.DataSource = auxiliar.Get();
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
                VacAuxiliarCL auxiliar = new VacAuxiliarCL();
                int id = 1;
                auxiliar.IDOpcionesVac = id;
                dataGridView1.DataSource = auxiliar.GetByPlanificadas();
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
                VacAuxiliarCL auxiliar = new VacAuxiliarCL();
                int id = 2;
                auxiliar.IDOpcionesVac = id;
                dataGridView1.DataSource = auxiliar.GetByDisfrutar();

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
