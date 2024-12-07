using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelSubMenuMedia.Visible = false;
            panelSubMenuVacaciones.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelSubMenuMedia.Visible == true)
                panelSubMenuMedia.Visible = false;
            if (panelSubMenuVacaciones.Visible == true)
                panelSubMenuVacaciones.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;

            }
            else
            {
                subMenu.Visible = false;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Paciente());
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private Form formActual = null;
        public void abrirFormHijo(object formHijo)
        {
            if (formActual != null)
            {
                this.middlePanel.Controls.Remove(formActual);
            }

            Form fH = formHijo as Form;
            fH.TopLevel = false;
            fH.Dock = DockStyle.Fill;
            this.middlePanel.Controls.Add(fH);
            this.middlePanel.Tag = fH;
            fH.BringToFront();
            fH.Show();
            formActual = fH as Form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Medicos());
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuMedia);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Presentation.Empleados.ATS.ATS());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Presentation.Empleados.ATSZona.ATZona());
        }


        private void button10_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Presentation.Empleados.Auxiliares.Auxiliares());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Presentation.Empleados.Celadores.Celadores());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Presentation.Empleados.Administracion.Administracion());
        }

        private void btnVacaciones_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuVacaciones);
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Consultas());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new VACATS());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new VACMedicos());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new VACAuxiliar());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new VACATSZona());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new VACAdmin());
        }
    }
}
