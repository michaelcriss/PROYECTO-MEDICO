namespace Presentation.Vacaciones.VACAdmin
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
            cmbOpciones = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            dtpFinal = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            cmbAdmin = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            Cancelarbtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmbOpciones
            // 
            cmbOpciones.Anchor = AnchorStyles.Bottom;
            cmbOpciones.BackColor = Color.FromArgb(192, 192, 255);
            cmbOpciones.FormattingEnabled = true;
            cmbOpciones.Location = new Point(295, 7);
            cmbOpciones.Margin = new Padding(3, 2, 3, 2);
            cmbOpciones.Name = "cmbOpciones";
            cmbOpciones.Size = new Size(109, 23);
            cmbOpciones.TabIndex = 151;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Location = new Point(224, 10);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 150;
            label5.Text = "Vacaciones";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(4, 96);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 149;
            label2.Text = "Final";
            // 
            // dtpFinal
            // 
            dtpFinal.Anchor = AnchorStyles.Bottom;
            dtpFinal.Location = new Point(46, 96);
            dtpFinal.Margin = new Padding(3, 2, 3, 2);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(185, 23);
            dtpFinal.TabIndex = 148;
            // 
            // dtpInicio
            // 
            dtpInicio.Anchor = AnchorStyles.Bottom;
            dtpInicio.Location = new Point(46, 50);
            dtpInicio.Margin = new Padding(3, 2, 3, 2);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(185, 23);
            dtpInicio.TabIndex = 147;
            // 
            // cmbAdmin
            // 
            cmbAdmin.Anchor = AnchorStyles.Bottom;
            cmbAdmin.BackColor = Color.FromArgb(192, 192, 255);
            cmbAdmin.FormattingEnabled = true;
            cmbAdmin.Location = new Point(104, 7);
            cmbAdmin.Margin = new Padding(3, 2, 3, 2);
            cmbAdmin.Name = "cmbAdmin";
            cmbAdmin.Size = new Size(109, 23);
            cmbAdmin.TabIndex = 146;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(4, 10);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 145;
            label3.Text = "Administradores";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(4, 50);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 144;
            label1.Text = "Inicio";
            // 
            // Cancelarbtn
            // 
            Cancelarbtn.BackColor = Color.FromArgb(192, 0, 192);
            Cancelarbtn.FlatStyle = FlatStyle.Flat;
            Cancelarbtn.ForeColor = Color.Gainsboro;
            Cancelarbtn.Location = new Point(316, 97);
            Cancelarbtn.Margin = new Padding(3, 2, 3, 2);
            Cancelarbtn.Name = "Cancelarbtn";
            Cancelarbtn.Size = new Size(88, 25);
            Cancelarbtn.TabIndex = 152;
            Cancelarbtn.Text = "Cancelar";
            Cancelarbtn.UseVisualStyleBackColor = false;
            Cancelarbtn.Click += Cancelarbtn_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.FromArgb(192, 0, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(316, 67);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(88, 25);
            button1.TabIndex = 153;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(410, 144);
            Controls.Add(button1);
            Controls.Add(Cancelarbtn);
            Controls.Add(cmbOpciones);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dtpFinal);
            Controls.Add(dtpInicio);
            Controls.Add(cmbAdmin);
            Controls.Add(label3);
            Controls.Add(label1);
            ForeColor = Color.Snow;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Agregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar";
            Load += Agregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOpciones;
        private Label label5;
        private Label label2;
        private DateTimePicker dtpFinal;
        private DateTimePicker dtpInicio;
        private ComboBox cmbAdmin;
        private Label label3;
        private Label label1;
        private Button Cancelarbtn;
        private Button button1;
    }
}