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

namespace Presentation.Vacaciones.VACATS
{
    public partial class AgregarVAtS : Form
    {
        public AgregarVAtS()
        {
            InitializeComponent();
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
    }
}
