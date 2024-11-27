namespace Presentation
{
    partial class Medicos
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
            label4 = new Label();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            btnBorrar = new Button();
            btnEditar = new Button();
            btnConsultar = new Button();
            btnAceptar = new Button();
            button1 = new Button();
            txtPoblacion = new TextBox();
            label5 = new Label();
            txtProvincia = new TextBox();
            label6 = new Label();
            txtCodigoPostal = new TextBox();
            label7 = new Label();
            txtNIF = new TextBox();
            label8 = new Label();
            txtNOSS = new TextBox();
            label9 = new Label();
            txtColegiado = new TextBox();
            label10 = new Label();
            label11 = new Label();
            cmbTipo = new ComboBox();
            txtId = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(582, 35);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(445, 101);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Direccion";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(251, 101);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(451, 246);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 4;
            label4.Text = "Telefono";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Bottom;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtDireccion.Location = new Point(445, 124);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Bottom;
            txtNombre.BackColor = Color.WhiteSmoke;
            txtNombre.Location = new Point(253, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Bottom;
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtTelefono.Location = new Point(451, 269);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(119, 27);
            txtTelefono.TabIndex = 8;
            txtTelefono.TextChanged += txtId_TextChanged;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBorrar.BackColor = Color.FromArgb(192, 0, 192);
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.ForeColor = Color.Gainsboro;
            btnBorrar.Location = new Point(497, 364);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(139, 59);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(192, 0, 192);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.Gainsboro;
            btnEditar.Location = new Point(352, 364);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(139, 59);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConsultar.BackColor = Color.FromArgb(192, 0, 192);
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.ForeColor = Color.Gainsboro;
            btnConsultar.Location = new Point(207, 364);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(139, 59);
            btnConsultar.TabIndex = 12;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += button4_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = Color.FromArgb(192, 0, 192);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(54, 364);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(147, 59);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Agregar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 0, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(596, 14);
            button1.Name = "button1";
            button1.Size = new Size(40, 29);
            button1.TabIndex = 14;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPoblacion
            // 
            txtPoblacion.Anchor = AnchorStyles.Bottom;
            txtPoblacion.BackColor = Color.WhiteSmoke;
            txtPoblacion.Location = new Point(54, 195);
            txtPoblacion.Name = "txtPoblacion";
            txtPoblacion.Size = new Size(125, 27);
            txtPoblacion.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Location = new Point(52, 172);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 15;
            label5.Text = "Poblacion";
            // 
            // txtProvincia
            // 
            txtProvincia.Anchor = AnchorStyles.Bottom;
            txtProvincia.BackColor = Color.WhiteSmoke;
            txtProvincia.Location = new Point(253, 195);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(125, 27);
            txtProvincia.TabIndex = 18;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Location = new Point(251, 172);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 17;
            label6.Text = "Provincia";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Anchor = AnchorStyles.Bottom;
            txtCodigoPostal.BackColor = Color.WhiteSmoke;
            txtCodigoPostal.Location = new Point(445, 195);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(125, 27);
            txtCodigoPostal.TabIndex = 20;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Location = new Point(443, 172);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 19;
            label7.Text = "Codigo Postal";
            // 
            // txtNIF
            // 
            txtNIF.Anchor = AnchorStyles.Bottom;
            txtNIF.BackColor = Color.WhiteSmoke;
            txtNIF.Location = new Point(54, 269);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(125, 27);
            txtNIF.TabIndex = 22;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Location = new Point(52, 246);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 21;
            label8.Text = "NIF";
            // 
            // txtNOSS
            // 
            txtNOSS.Anchor = AnchorStyles.Bottom;
            txtNOSS.BackColor = Color.WhiteSmoke;
            txtNOSS.Location = new Point(253, 269);
            txtNOSS.Name = "txtNOSS";
            txtNOSS.Size = new Size(125, 27);
            txtNOSS.TabIndex = 24;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Location = new Point(251, 246);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 23;
            label9.Text = "Seguridad Social";
            // 
            // txtColegiado
            // 
            txtColegiado.Anchor = AnchorStyles.Bottom;
            txtColegiado.BackColor = Color.WhiteSmoke;
            txtColegiado.Location = new Point(253, 330);
            txtColegiado.Name = "txtColegiado";
            txtColegiado.Size = new Size(125, 27);
            txtColegiado.TabIndex = 26;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Location = new Point(253, 308);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 25;
            label10.Text = "Colegiado";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Location = new Point(50, 308);
            label11.Name = "label11";
            label11.Size = new Size(55, 20);
            label11.TabIndex = 27;
            label11.Text = "Estatus";
            // 
            // cmbTipo
            // 
            cmbTipo.Anchor = AnchorStyles.Bottom;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Titular", "Interino", "Sustituto" });
            cmbTipo.Location = new Point(54, 330);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 28;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Bottom;
            txtId.BackColor = Color.WhiteSmoke;
            txtId.Location = new Point(54, 124);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 29;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(54, 101);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 30;
            label3.Text = "Id";
            // 
            // Medicos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 435);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(cmbTipo);
            Controls.Add(label11);
            Controls.Add(txtColegiado);
            Controls.Add(label10);
            Controls.Add(txtNOSS);
            Controls.Add(label9);
            Controls.Add(txtNIF);
            Controls.Add(label8);
            Controls.Add(txtCodigoPostal);
            Controls.Add(label7);
            Controls.Add(txtProvincia);
            Controls.Add(label6);
            Controls.Add(txtPoblacion);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(btnConsultar);
            Controls.Add(btnEditar);
            Controls.Add(btnBorrar);
            Controls.Add(btnAceptar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Medicos";
            Text = "Avion";
            Load += Avion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private TextBox txtCodigoPostal;
        private TextBox txtTelefono;
        private Button btnBorrar;
        private Button btnEditar;
        private Button btnConsultar;
        private Button btnAceptar;
        private Button button1;
        private TextBox txtPoblacion;
        private Label label5;
        private TextBox txtProvincia;
        private Label label6;
        private Label label7;
        private TextBox txtNIF;
        private Label label8;
        private TextBox txtNOSS;
        private Label label9;
        private TextBox txtColegiado;
        private Label label10;
        private Label label11;
        private ComboBox cmbTipo;
        private TextBox txtId;
        private Label label3;
    }
}