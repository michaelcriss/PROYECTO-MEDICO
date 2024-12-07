namespace Presentation
{
    partial class VACATS
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
            label10 = new Label();
            label3 = new Label();
            button1 = new Button();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnBorrar = new Button();
            btnAceptar = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            cmbATS = new ComboBox();
            dtpInicio = new DateTimePicker();
            dtpFinal = new DateTimePicker();
            label2 = new Label();
            btnPlanificadas = new Button();
            btnDisfrutadas = new Button();
            label4 = new Label();
            cmbOpciones = new ComboBox();
            label5 = new Label();
            txtId = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(64, 0, 64);
            label10.ForeColor = Color.Gainsboro;
            label10.Location = new Point(45, 16);
            label10.Name = "label10";
            label10.Size = new Size(100, 15);
            label10.TabIndex = 84;
            label10.Text = "VACACIONES ATS";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(46, 112);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 83;
            label3.Text = "ATS";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 0, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(519, 10);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(35, 22);
            button1.TabIndex = 71;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Bottom;
            btnConsultar.BackColor = Color.FromArgb(192, 0, 192);
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.ForeColor = Color.Gainsboro;
            btnConsultar.Location = new Point(178, 272);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(122, 44);
            btnConsultar.TabIndex = 70;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom;
            btnEditar.BackColor = Color.FromArgb(192, 0, 192);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.Gainsboro;
            btnEditar.Location = new Point(305, 272);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(122, 44);
            btnEditar.TabIndex = 69;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Bottom;
            btnBorrar.BackColor = Color.FromArgb(192, 0, 192);
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.ForeColor = Color.Gainsboro;
            btnBorrar.Location = new Point(432, 272);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(122, 44);
            btnBorrar.TabIndex = 68;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom;
            btnAceptar.BackColor = Color.FromArgb(192, 0, 192);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(45, 272);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(129, 44);
            btnAceptar.TabIndex = 67;
            btnAceptar.Text = "Agregar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(213, 112);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 61;
            label1.Text = "Inicio";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 36);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(509, 62);
            dataGridView1.TabIndex = 60;
            // 
            // cmbATS
            // 
            cmbATS.Anchor = AnchorStyles.Bottom;
            cmbATS.FormattingEnabled = true;
            cmbATS.Location = new Point(46, 130);
            cmbATS.Margin = new Padding(3, 2, 3, 2);
            cmbATS.Name = "cmbATS";
            cmbATS.Size = new Size(133, 23);
            cmbATS.TabIndex = 85;
            // 
            // dtpInicio
            // 
            dtpInicio.Anchor = AnchorStyles.Bottom;
            dtpInicio.Location = new Point(213, 130);
            dtpInicio.Margin = new Padding(3, 2, 3, 2);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(185, 23);
            dtpInicio.TabIndex = 86;
            // 
            // dtpFinal
            // 
            dtpFinal.Anchor = AnchorStyles.Bottom;
            dtpFinal.Location = new Point(213, 194);
            dtpFinal.Margin = new Padding(3, 2, 3, 2);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(185, 23);
            dtpFinal.TabIndex = 87;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(213, 176);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 88;
            label2.Text = "Final";
            // 
            // btnPlanificadas
            // 
            btnPlanificadas.Anchor = AnchorStyles.Bottom;
            btnPlanificadas.BackColor = Color.FromArgb(192, 0, 192);
            btnPlanificadas.FlatStyle = FlatStyle.Flat;
            btnPlanificadas.ForeColor = Color.Gainsboro;
            btnPlanificadas.Location = new Point(432, 130);
            btnPlanificadas.Margin = new Padding(3, 2, 3, 2);
            btnPlanificadas.Name = "btnPlanificadas";
            btnPlanificadas.Size = new Size(129, 44);
            btnPlanificadas.TabIndex = 89;
            btnPlanificadas.Text = "PLANIFICADAS";
            btnPlanificadas.UseVisualStyleBackColor = false;
            btnPlanificadas.Click += btnPlanificadas_Click;
            // 
            // btnDisfrutadas
            // 
            btnDisfrutadas.Anchor = AnchorStyles.Bottom;
            btnDisfrutadas.BackColor = Color.FromArgb(192, 0, 192);
            btnDisfrutadas.FlatStyle = FlatStyle.Flat;
            btnDisfrutadas.ForeColor = Color.Gainsboro;
            btnDisfrutadas.Location = new Point(432, 176);
            btnDisfrutadas.Margin = new Padding(3, 2, 3, 2);
            btnDisfrutadas.Name = "btnDisfrutadas";
            btnDisfrutadas.Size = new Size(129, 44);
            btnDisfrutadas.TabIndex = 90;
            btnDisfrutadas.Text = "DISFRUTADAS";
            btnDisfrutadas.UseVisualStyleBackColor = false;
            btnDisfrutadas.Click += btnDisfrutadas_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(432, 112);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 91;
            label4.Text = "Visualizar";
            // 
            // cmbOpciones
            // 
            cmbOpciones.Anchor = AnchorStyles.Bottom;
            cmbOpciones.FormattingEnabled = true;
            cmbOpciones.Location = new Point(46, 195);
            cmbOpciones.Margin = new Padding(3, 2, 3, 2);
            cmbOpciones.Name = "cmbOpciones";
            cmbOpciones.Size = new Size(133, 23);
            cmbOpciones.TabIndex = 93;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Location = new Point(46, 178);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 92;
            label5.Text = "Vacaciones";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Bottom;
            txtId.Location = new Point(228, 231);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 94;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Location = new Point(192, 233);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 95;
            label6.Text = "Id";
            // 
            // VACATS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(598, 326);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(cmbOpciones);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnDisfrutadas);
            Controls.Add(btnPlanificadas);
            Controls.Add(label2);
            Controls.Add(dtpFinal);
            Controls.Add(dtpInicio);
            Controls.Add(cmbATS);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(btnConsultar);
            Controls.Add(btnEditar);
            Controls.Add(btnBorrar);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "VACATS";
            Text = "VACATS";
            Load += VACATS_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label3;
        private Button button1;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnBorrar;
        private Button btnAceptar;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox cmbATS;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFinal;
        private Label label2;
        private Button btnPlanificadas;
        private Button btnDisfrutadas;
        private Label label4;
        private ComboBox cmbOpciones;
        private Label label5;
        private TextBox txtId;
        private Label label6;
    }
}