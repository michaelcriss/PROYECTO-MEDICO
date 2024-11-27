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
    public partial class Sustituciones : Form
    {
        public Sustituciones()
        {
            InitializeComponent();
            ListarMedicos();
            ListarSustituto();
            

        }
        private void ListarMedicos()
        {
            VacMedicosCL medicos = new VacMedicosCL();
            cmbATS.DataSource = medicos.ListarEstado();
            cmbATS.DisplayMember = "NOMBRE";
            cmbATS.ValueMember = "IDMEDICO";

        }

        private void ListarSustituto()
        {
            VacMedicosCL medicos = new VacMedicosCL();
            cmbSustituido.DataSource = medicos.ListarEstado();
            cmbSustituido.DisplayMember = "NOMBRE";
            cmbSustituido.ValueMember = "IDMEDICO";

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Sustitucion sust =  new Sustitucion();
                sust.IDMEDICO = Convert.ToInt32(cmbATS.SelectedValue);
                sust.FECHAALTA = Convert.ToString(dtpAlta.Value.Date);
                sust.FECHABAJA = Convert.ToString(dtpBaja.Value.Date);
                sust.IDSUSTITUIDO = Convert.ToInt32(cmbSustituido.SelectedValue);


                if (sust.Add())
                {
                    dataGridView1.DataSource = sust.Get();
                    MessageBox.Show("Los datos fueron registrado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Sustitucion sust = new Sustitucion();
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int ids = int.Parse(txtId.Text);
                    if (ids > 0)
                    {
                        sust.Id = ids;
                        dataGridView1.DataSource = sust.GetById();

                        return;
                    }
                }
                else
                {
                    dataGridView1.DataSource = sust.Get();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)

        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
