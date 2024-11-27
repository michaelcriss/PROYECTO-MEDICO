namespace Presentation
{
    partial class Consultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAceptar = new Button();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnBorrar = new Button();
            txtMartes = new TextBox();
            txtMiercoles = new TextBox();
            button1 = new Button();
            txtJueves = new TextBox();
            txtViernes = new TextBox();
            txtSabado = new TextBox();
            txtDomingo = new TextBox();
            txtLunes = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtId = new TextBox();
            cmbMedico = new ComboBox();
            btnSustituciones = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(582, 37);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(51, 163);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Medico";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(442, 97);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Horarios";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(508, 234);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = Color.FromArgb(192, 0, 192);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(51, 351);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(150, 59);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Agregar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConsultar.BackColor = Color.FromArgb(192, 0, 192);
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.ForeColor = Color.Gainsboro;
            btnConsultar.Location = new Point(206, 351);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(139, 59);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(192, 0, 192);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.Gainsboro;
            btnEditar.Location = new Point(350, 351);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(139, 59);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBorrar.BackColor = Color.FromArgb(192, 0, 192);
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.ForeColor = Color.Gainsboro;
            btnBorrar.Location = new Point(494, 351);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(139, 59);
            btnBorrar.TabIndex = 7;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtMartes
            // 
            txtMartes.Anchor = AnchorStyles.Bottom;
            txtMartes.Location = new Point(404, 153);
            txtMartes.Name = "txtMartes";
            txtMartes.Size = new Size(173, 27);
            txtMartes.TabIndex = 9;
            // 
            // txtMiercoles
            // 
            txtMiercoles.Anchor = AnchorStyles.Bottom;
            txtMiercoles.Location = new Point(404, 186);
            txtMiercoles.Name = "txtMiercoles";
            txtMiercoles.Size = new Size(173, 27);
            txtMiercoles.TabIndex = 10;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 0, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(593, 12);
            button1.Name = "button1";
            button1.Size = new Size(40, 29);
            button1.TabIndex = 11;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtJueves
            // 
            txtJueves.Anchor = AnchorStyles.Bottom;
            txtJueves.Location = new Point(404, 219);
            txtJueves.Name = "txtJueves";
            txtJueves.Size = new Size(173, 27);
            txtJueves.TabIndex = 12;
            // 
            // txtViernes
            // 
            txtViernes.Anchor = AnchorStyles.Bottom;
            txtViernes.Location = new Point(404, 252);
            txtViernes.Name = "txtViernes";
            txtViernes.Size = new Size(173, 27);
            txtViernes.TabIndex = 13;
            // 
            // txtSabado
            // 
            txtSabado.Anchor = AnchorStyles.Bottom;
            txtSabado.Location = new Point(404, 285);
            txtSabado.Name = "txtSabado";
            txtSabado.Size = new Size(173, 27);
            txtSabado.TabIndex = 14;
            // 
            // txtDomingo
            // 
            txtDomingo.Anchor = AnchorStyles.Bottom;
            txtDomingo.Location = new Point(404, 318);
            txtDomingo.Name = "txtDomingo";
            txtDomingo.Size = new Size(173, 27);
            txtDomingo.TabIndex = 15;
            // 
            // txtLunes
            // 
            txtLunes.Anchor = AnchorStyles.Bottom;
            txtLunes.Location = new Point(404, 120);
            txtLunes.Name = "txtLunes";
            txtLunes.Size = new Size(173, 27);
            txtLunes.TabIndex = 16;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(326, 123);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 17;
            label4.Text = "Lunes";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Location = new Point(326, 156);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 18;
            label5.Text = "Martes";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Location = new Point(326, 189);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 19;
            label6.Text = "Miercoles";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Location = new Point(326, 219);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 20;
            label7.Text = "Jueves";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Location = new Point(326, 252);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 21;
            label8.Text = "Viernes";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Location = new Point(326, 285);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 22;
            label9.Text = "Sabado";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Location = new Point(326, 318);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 23;
            label10.Text = "Domingo";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Location = new Point(51, 97);
            label11.Name = "label11";
            label11.Size = new Size(22, 20);
            label11.TabIndex = 24;
            label11.Text = "Id";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Bottom;
            txtId.Location = new Point(51, 120);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 25;
            // 
            // cmbMedico
            // 
            cmbMedico.Anchor = AnchorStyles.Bottom;
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(51, 185);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(151, 28);
            cmbMedico.TabIndex = 26;
            // 
            // btnSustituciones
            // 
            btnSustituciones.Anchor = AnchorStyles.Bottom;
            btnSustituciones.BackColor = Color.FromArgb(0, 64, 64);
            btnSustituciones.FlatStyle = FlatStyle.Flat;
            btnSustituciones.ForeColor = Color.Gainsboro;
            btnSustituciones.Location = new Point(52, 246);
            btnSustituciones.Name = "btnSustituciones";
            btnSustituciones.Size = new Size(150, 59);
            btnSustituciones.TabIndex = 27;
            btnSustituciones.Text = "Sustituciones";
            btnSustituciones.UseVisualStyleBackColor = false;
            btnSustituciones.Click += btnSustituciones_Click;
            // 
            // Consultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 435);
            Controls.Add(btnSustituciones);
            Controls.Add(cmbMedico);
            Controls.Add(txtId);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtLunes);
            Controls.Add(txtDomingo);
            Controls.Add(txtSabado);
            Controls.Add(txtViernes);
            Controls.Add(txtJueves);
            Controls.Add(button1);
            Controls.Add(txtMiercoles);
            Controls.Add(txtMartes);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(btnConsultar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Consultas";
            Text = "MiembrosTripulacion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAceptar;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnBorrar;
        private TextBox txtMartes;
        private TextBox txtMiercoles;
        private Button button1;
        private TextBox txtJueves;
        private TextBox txtViernes;
        private TextBox txtSabado;
        private TextBox txtDomingo;
        private TextBox txtLunes;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtId;
        private ComboBox cmbMedico;
        private Button btnSustituciones;
    }
}