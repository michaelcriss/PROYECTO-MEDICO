
namespace Presentation
{
    partial class Paciente
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paciente));
            dataGridView1 = new DataGridView();
            txtBuscar = new TextBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnBorrar = new Button();
            btnAceptar = new Button();
            X = new Button();
            label10 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.Purple;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle10.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.DarkGray;
            dataGridView1.Location = new Point(36, 74);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.Silver;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = Color.Silver;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(886, 232);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscar.BackColor = Color.Silver;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Location = new Point(556, 42);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(157, 20);
            txtBuscar.TabIndex = 31;
            txtBuscar.TextChanged += this.txtBuscar_TextChanged;
            txtBuscar.KeyUp += txtId_KeyUp;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultar.BackColor = Color.FromArgb(192, 0, 192);
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.ForeColor = Color.Gainsboro;
            btnConsultar.Image = (Image)resources.GetObject("btnConsultar.Image");
            btnConsultar.Location = new Point(520, 42);
            btnConsultar.Margin = new Padding(0);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(33, 20);
            btnConsultar.TabIndex = 50;
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(192, 0, 192);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.Gainsboro;
            btnEditar.Location = new Point(788, 42);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(65, 20);
            btnEditar.TabIndex = 49;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBorrar.BackColor = Color.FromArgb(192, 0, 192);
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.ForeColor = Color.Gainsboro;
            btnBorrar.Location = new Point(858, 42);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(65, 20);
            btnBorrar.TabIndex = 48;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAceptar.BackColor = Color.FromArgb(192, 0, 192);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(718, 42);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(65, 20);
            btnAceptar.TabIndex = 47;
            btnAceptar.Text = "Agregar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // X
            // 
            X.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            X.BackColor = Color.FromArgb(192, 0, 192);
            X.FlatAppearance.BorderSize = 0;
            X.FlatStyle = FlatStyle.Flat;
            X.ForeColor = Color.Gainsboro;
            X.Location = new Point(892, 9);
            X.Margin = new Padding(3, 2, 3, 2);
            X.Name = "X";
            X.Size = new Size(30, 23);
            X.TabIndex = 51;
            X.Text = "X";
            X.UseVisualStyleBackColor = false;
            X.Click += X_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkViolet;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gainsboro;
            label10.Location = new Point(36, 44);
            label10.Name = "label10";
            label10.Size = new Size(70, 17);
            label10.TabIndex = 85;
            label10.Text = "Pacientes";
            label10.Click += this.label10_Click;
            // 
            // txtId
            // 
            txtId.BackColor = Color.Silver;
            txtId.BorderStyle = BorderStyle.None;
            txtId.Enabled = false;
            txtId.Location = new Point(200, 44);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(36, 18);
            txtId.TabIndex = 86;
            txtId.TextChanged += this.txtId_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(282, 46);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 87;
            label1.Text = "vista general";
            label1.Click += label1_Click;
            // 
            // Paciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(950, 326);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(label10);
            Controls.Add(X);
            Controls.Add(btnConsultar);
            Controls.Add(btnEditar);
            Controls.Add(btnBorrar);
            Controls.Add(btnAceptar);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Paciente";
            Text = "Paciente";
            Load += Paciente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnBorrar;
        private Button btnAceptar;
        private Button X;
        private Label label10;
        private TextBox txtId;
        private Label label1;
    }
}