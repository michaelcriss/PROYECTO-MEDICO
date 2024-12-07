namespace Presentation.Vacaciones.VACATSZona
{
    partial class EditarVATSZONA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarVATSZONA));
            label2 = new Label();
            dtpFinal = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtBuscar = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(547, 157);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 162;
            label2.Text = "Final";
            // 
            // dtpFinal
            // 
            dtpFinal.Anchor = AnchorStyles.Bottom;
            dtpFinal.Location = new Point(547, 174);
            dtpFinal.Margin = new Padding(3, 2, 3, 2);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(185, 23);
            dtpFinal.TabIndex = 161;
            // 
            // dtpInicio
            // 
            dtpInicio.Anchor = AnchorStyles.Bottom;
            dtpInicio.Location = new Point(547, 106);
            dtpInicio.Margin = new Padding(3, 2, 3, 2);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(185, 23);
            dtpInicio.TabIndex = 160;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(547, 78);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 159;
            label3.Text = "Inicio";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(192, 0, 192);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(643, 229);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(88, 25);
            button3.TabIndex = 158;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 0, 192);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(547, 229);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(88, 25);
            button2.TabIndex = 157;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 0, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(705, 28);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(26, 22);
            button1.TabIndex = 156;
            button1.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Right;
            txtBuscar.BackColor = Color.FromArgb(192, 192, 255);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Location = new Point(547, 28);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(146, 22);
            txtBuscar.TabIndex = 155;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.GridColor = Color.DarkGray;
            dataGridView1.Location = new Point(14, 13);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(527, 286);
            dataGridView1.TabIndex = 154;
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(747, 313);
            Controls.Add(label2);
            Controls.Add(dtpFinal);
            Controls.Add(dtpInicio);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridView1);
            ForeColor = Color.Gainsboro;
            Name = "Editar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DateTimePicker dtpFinal;
        private DateTimePicker dtpInicio;
        private Label label3;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtBuscar;
        private DataGridView dataGridView1;
    }
}