namespace Presentation.Vacaciones.VACAuxiliar
{
    partial class AgregarVAUXILIAR
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
            Cancelarbtn = new Button();
            cmbOpciones = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            dtpFinal = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            cmbAdmin = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // Cancelarbtn
            // 
            Cancelarbtn.BackColor = Color.FromArgb(192, 0, 192);
            Cancelarbtn.FlatStyle = FlatStyle.Flat;
            Cancelarbtn.ForeColor = Color.Gainsboro;
            Cancelarbtn.Location = new Point(317, 105);
            Cancelarbtn.Margin = new Padding(3, 2, 3, 2);
            Cancelarbtn.Name = "Cancelarbtn";
            Cancelarbtn.Size = new Size(88, 25);
            Cancelarbtn.TabIndex = 162;
            Cancelarbtn.Text = "Cancelar";
            Cancelarbtn.UseVisualStyleBackColor = false;
            // 
            // cmbOpciones
            // 
            cmbOpciones.Anchor = AnchorStyles.Bottom;
            cmbOpciones.BackColor = Color.FromArgb(192, 192, 255);
            cmbOpciones.FormattingEnabled = true;
            cmbOpciones.Location = new Point(296, 15);
            cmbOpciones.Margin = new Padding(3, 2, 3, 2);
            cmbOpciones.Name = "cmbOpciones";
            cmbOpciones.Size = new Size(109, 23);
            cmbOpciones.TabIndex = 161;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Location = new Point(225, 18);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 160;
            label5.Text = "Vacaciones";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(5, 104);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 159;
            label2.Text = "Final";
            // 
            // dtpFinal
            // 
            dtpFinal.Anchor = AnchorStyles.Bottom;
            dtpFinal.Location = new Point(47, 104);
            dtpFinal.Margin = new Padding(3, 2, 3, 2);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(185, 23);
            dtpFinal.TabIndex = 158;
            // 
            // dtpInicio
            // 
            dtpInicio.Anchor = AnchorStyles.Bottom;
            dtpInicio.Location = new Point(47, 58);
            dtpInicio.Margin = new Padding(3, 2, 3, 2);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(185, 23);
            dtpInicio.TabIndex = 157;
            // 
            // cmbAdmin
            // 
            cmbAdmin.Anchor = AnchorStyles.Bottom;
            cmbAdmin.BackColor = Color.FromArgb(192, 192, 255);
            cmbAdmin.FormattingEnabled = true;
            cmbAdmin.Location = new Point(105, 15);
            cmbAdmin.Margin = new Padding(3, 2, 3, 2);
            cmbAdmin.Name = "cmbAdmin";
            cmbAdmin.Size = new Size(109, 23);
            cmbAdmin.TabIndex = 156;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(5, 18);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 155;
            label3.Text = "Administradores";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(5, 58);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 154;
            label1.Text = "Inicio";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 0, 192);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(317, 75);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(88, 25);
            btnAceptar.TabIndex = 153;
            btnAceptar.Text = "Agregar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(410, 144);
            Controls.Add(Cancelarbtn);
            Controls.Add(cmbOpciones);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dtpFinal);
            Controls.Add(dtpInicio);
            Controls.Add(cmbAdmin);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            ForeColor = Color.Snow;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Agregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelarbtn;
        private ComboBox cmbOpciones;
        private Label label5;
        private Label label2;
        private DateTimePicker dtpFinal;
        private DateTimePicker dtpInicio;
        private ComboBox cmbAdmin;
        private Label label3;
        private Label label1;
        private Button btnAceptar;
    }
}