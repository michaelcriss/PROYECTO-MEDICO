
namespace Presentation.Pacientes
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label8 = new Label();
            label7 = new Label();
            txtSeguridadSocial = new TextBox();
            label6 = new Label();
            txtNIF = new TextBox();
            label5 = new Label();
            txtCodigoPostal = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            cmbMedico = new ComboBox();
            txtBuscar = new TextBox();
            button2 = new Button();
            label3 = new Label();
            txtId = new TextBox();
            button3 = new Button();
            txtDir = new TextBox();
            txtNom = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(639, 378);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 62;
            label8.Text = "Medico";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(639, 338);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 61;
            label7.Text = "No. INSS";
            // 
            // txtSeguridadSocial
            // 
            txtSeguridadSocial.Anchor = AnchorStyles.Right;
            txtSeguridadSocial.BackColor = Color.FromArgb(192, 192, 255);
            txtSeguridadSocial.BorderStyle = BorderStyle.FixedSingle;
            txtSeguridadSocial.Location = new Point(717, 338);
            txtSeguridadSocial.Name = "txtSeguridadSocial";
            txtSeguridadSocial.Size = new Size(125, 27);
            txtSeguridadSocial.TabIndex = 60;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(639, 302);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 59;
            label6.Text = "NIF";
            // 
            // txtNIF
            // 
            txtNIF.Anchor = AnchorStyles.Right;
            txtNIF.BackColor = Color.FromArgb(192, 192, 255);
            txtNIF.BorderStyle = BorderStyle.FixedSingle;
            txtNIF.Location = new Point(673, 302);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(169, 27);
            txtNIF.TabIndex = 58;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(639, 265);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 57;
            label5.Text = "Codigo Postal";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Anchor = AnchorStyles.Right;
            txtCodigoPostal.BackColor = Color.FromArgb(192, 192, 255);
            txtCodigoPostal.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoPostal.Location = new Point(746, 262);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(96, 27);
            txtCodigoPostal.TabIndex = 56;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(639, 224);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 55;
            label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Right;
            txtTelefono.BackColor = Color.FromArgb(192, 192, 255);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(717, 221);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 54;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(639, 182);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 53;
            label2.Text = "Direccion";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(639, 140);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 51;
            label1.Text = "Nombre";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 0, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(812, 16);
            button1.Name = "button1";
            button1.Size = new Size(30, 29);
            button1.TabIndex = 64;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbMedico
            // 
            cmbMedico.Anchor = AnchorStyles.Right;
            cmbMedico.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMedico.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMedico.BackColor = Color.FromArgb(192, 192, 255);
            cmbMedico.FlatStyle = FlatStyle.Flat;
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(704, 375);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(138, 28);
            cmbMedico.TabIndex = 65;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Right;
            txtBuscar.BackColor = Color.FromArgb(192, 192, 255);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Location = new Point(639, 16);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(167, 29);
            txtBuscar.TabIndex = 66;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 0, 192);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(639, 61);
            button2.Name = "button2";
            button2.Size = new Size(101, 33);
            button2.TabIndex = 67;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(639, 105);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 69;
            label3.Text = "Codigo";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Right;
            txtId.BackColor = Color.FromArgb(192, 192, 255);
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Location = new Point(717, 105);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 68;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(192, 0, 192);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(741, 61);
            button3.Name = "button3";
            button3.Size = new Size(101, 33);
            button3.TabIndex = 70;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtDir
            // 
            txtDir.Anchor = AnchorStyles.Right;
            txtDir.BackColor = Color.FromArgb(192, 192, 255);
            txtDir.BorderStyle = BorderStyle.FixedSingle;
            txtDir.Location = new Point(717, 180);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(125, 27);
            txtDir.TabIndex = 71;
            // 
            // txtNom
            // 
            txtNom.Anchor = AnchorStyles.Right;
            txtNom.BackColor = Color.FromArgb(192, 192, 255);
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.Location = new Point(717, 140);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 72;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Purple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.DarkGray;
            dataGridView1.Location = new Point(21, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(602, 382);
            dataGridView1.TabIndex = 73;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(854, 417);
            Controls.Add(dataGridView1);
            Controls.Add(txtNom);
            Controls.Add(txtDir);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(button2);
            Controls.Add(txtBuscar);
            Controls.Add(cmbMedico);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtSeguridadSocial);
            Controls.Add(label6);
            Controls.Add(txtNIF);
            Controls.Add(label5);
            Controls.Add(txtCodigoPostal);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Editar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label label8;
        private Label label7;
        private TextBox txtSeguridadSocial;
        private Label label6;
        private TextBox txtNIF;
        private Label label5;
        private TextBox txtCodigoPostal;
        private Label label4;
        private TextBox txtTelefono;
        private Label label2;
        private Label label1;
        private Button button1;
        private ComboBox cmbMedico;
        private TextBox txtBuscar;
        private Button button2;
        private Label label3;
        private TextBox txtId;
        private Button button3;
        private TextBox txtDir;
        private TextBox txtNom;
        private DataGridView dataGridView1;
    }
}