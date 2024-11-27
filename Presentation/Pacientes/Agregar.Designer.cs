namespace Presentation.Pacientes
{
    partial class Agregar
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
            button3 = new Button();
            button2 = new Button();
            cmbMedico = new ComboBox();
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
            txtDireccion = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(192, 0, 192);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(355, 134);
            button3.Name = "button3";
            button3.Size = new Size(101, 33);
            button3.TabIndex = 90;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 0, 192);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(248, 134);
            button2.Name = "button2";
            button2.Size = new Size(101, 33);
            button2.TabIndex = 87;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cmbMedico
            // 
            cmbMedico.Anchor = AnchorStyles.Right;
            cmbMedico.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMedico.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMedico.BackColor = Color.FromArgb(192, 192, 255);
            cmbMedico.FlatStyle = FlatStyle.Flat;
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(75, 137);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(138, 28);
            cmbMedico.TabIndex = 85;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(5, 140);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 83;
            label8.Text = "Medico";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(195, 96);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 82;
            label7.Text = "No. INSS";
            // 
            // txtSeguridadSocial
            // 
            txtSeguridadSocial.Anchor = AnchorStyles.Right;
            txtSeguridadSocial.BackColor = Color.FromArgb(192, 192, 255);
            txtSeguridadSocial.BorderStyle = BorderStyle.None;
            txtSeguridadSocial.Location = new Point(268, 96);
            txtSeguridadSocial.Name = "txtSeguridadSocial";
            txtSeguridadSocial.Size = new Size(185, 20);
            txtSeguridadSocial.TabIndex = 81;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(5, 96);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 80;
            label6.Text = "NIF";
            // 
            // txtNIF
            // 
            txtNIF.Anchor = AnchorStyles.Right;
            txtNIF.BackColor = Color.FromArgb(192, 192, 255);
            txtNIF.BorderStyle = BorderStyle.None;
            txtNIF.Location = new Point(47, 96);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(125, 20);
            txtNIF.TabIndex = 79;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(5, 63);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 78;
            label5.Text = "Codigo Postal";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Anchor = AnchorStyles.Right;
            txtCodigoPostal.BackColor = Color.FromArgb(192, 192, 255);
            txtCodigoPostal.BorderStyle = BorderStyle.None;
            txtCodigoPostal.Location = new Point(112, 63);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(125, 20);
            txtCodigoPostal.TabIndex = 77;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(255, 63);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 76;
            label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Right;
            txtTelefono.BackColor = Color.FromArgb(192, 192, 255);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Location = new Point(328, 63);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 20);
            txtTelefono.TabIndex = 75;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(223, 27);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 74;
            label2.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Right;
            txtDireccion.BackColor = Color.FromArgb(192, 192, 255);
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Location = new Point(301, 27);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(152, 20);
            txtDireccion.TabIndex = 73;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(5, 27);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 72;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Right;
            txtNombre.BackColor = Color.FromArgb(192, 192, 255);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(75, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 20);
            txtNombre.TabIndex = 71;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(468, 192);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(cmbMedico);
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
            Controls.Add(txtDireccion);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Agregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private ComboBox cmbMedico;
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
        private TextBox txtDireccion;
        private Label label1;
        private TextBox txtNombre;
    }
}