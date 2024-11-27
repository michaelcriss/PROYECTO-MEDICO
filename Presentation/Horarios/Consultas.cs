using BusinessLogic;

namespace Presentation
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
            ListarMedicos();
        }
        private void ListarMedicos()
        {
            Consulta horarios = new Consulta();
            cmbMedico.DataSource = horarios.ListarMedico();
            cmbMedico.DisplayMember = "NOMBRE";
            cmbMedico.ValueMember = "IDMEDICO";

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta horarios = new Consulta();
                horarios.IDMedico = Convert.ToInt32(cmbMedico.SelectedValue);
                horarios.Lunes = txtLunes.Text;
                horarios.Martes = txtMartes.Text;
                horarios.Miercoles = txtMiercoles.Text;
                horarios.Jueves = txtJueves.Text;
                horarios.Viernes = txtViernes.Text;
                horarios.Sabado = txtSabado.Text;
                horarios.Domingo = txtDomingo.Text;


                if (horarios.Add())
                {
                    dataGridView1.DataSource = horarios.Get();
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
                Consulta horarios = new Consulta();
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        horarios.Id = id;
                        dataGridView1.DataSource = horarios.GetById();
                        return;
                    }
                }
                else
                {
                    dataGridView1.DataSource = horarios.Get();
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
                Consulta horarios = new Consulta();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        horarios.Id = id;
                        horarios.IDMedico = Convert.ToInt32(cmbMedico.SelectedValue);
                        horarios.Lunes = txtLunes.Text;
                        horarios.Martes = txtMartes.Text;
                        horarios.Miercoles = txtMiercoles.Text;
                        horarios.Jueves = txtJueves.Text;
                        horarios.Viernes = txtViernes.Text;
                        horarios.Sabado = txtSabado.Text;
                        horarios.Domingo = txtDomingo.Text;

                        if (horarios.Edit())
                        {
                            dataGridView1.DataSource = horarios.Get();
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

                Consulta horarios = new Consulta();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        horarios.Id = id;
                        if (horarios.Delete())
                        {
                            dataGridView1.DataSource = horarios.Get();
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

        private void btnSustituciones_Click(object sender, EventArgs e)
        {
            Sustituciones ver = new Sustituciones();
            ver.Show();
           
        }
    }
}
