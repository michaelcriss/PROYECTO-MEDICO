namespace Presentation
{
    partial class Sustituciones
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
            btnAceptar = new Button();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            dtpAlta = new DateTimePicker();
            cmbATS = new ComboBox();
            label10 = new Label();
            label3 = new Label();
            button4 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dtpBaja = new DateTimePicker();
            cmbSustituido = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = Color.FromArgb(192, 0, 192);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(96, 364);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(150, 59);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Agregar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 0, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(252, 364);
            button1.Name = "button1";
            button1.Size = new Size(150, 59);
            button1.TabIndex = 6;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 0, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(408, 364);
            button2.Name = "button2";
            button2.Size = new Size(150, 59);
            button2.TabIndex = 7;
            button2.Text = "Verificar ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(231, 235);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 120;
            label2.Text = "Fecha de baja";
            // 
            // dtpAlta
            // 
            dtpAlta.Anchor = AnchorStyles.Bottom;
            dtpAlta.Location = new Point(232, 174);
            dtpAlta.Name = "dtpAlta";
            dtpAlta.Size = new Size(211, 27);
            dtpAlta.TabIndex = 119;
            // 
            // cmbATS
            // 
            cmbATS.Anchor = AnchorStyles.Bottom;
            cmbATS.FormattingEnabled = true;
            cmbATS.Location = new Point(41, 173);
            cmbATS.Name = "cmbATS";
            cmbATS.Size = new Size(151, 28);
            cmbATS.TabIndex = 118;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(64, 0, 64);
            label10.ForeColor = Color.Gainsboro;
            label10.Location = new Point(40, 22);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 117;
            label10.Text = "SUSTITICIONES";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(41, 150);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 116;
            label3.Text = "Sustituto";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(192, 0, 192);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Gainsboro;
            button4.Location = new Point(582, 13);
            button4.Name = "button4";
            button4.Size = new Size(40, 29);
            button4.TabIndex = 115;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(232, 150);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 114;
            label1.Text = "Fecha de alta";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(582, 82);
            dataGridView1.TabIndex = 113;
            // 
            // dtpBaja
            // 
            dtpBaja.Anchor = AnchorStyles.Bottom;
            dtpBaja.Location = new Point(232, 258);
            dtpBaja.Name = "dtpBaja";
            dtpBaja.Size = new Size(211, 27);
            dtpBaja.TabIndex = 121;
            // 
            // cmbSustituido
            // 
            cmbSustituido.Anchor = AnchorStyles.Bottom;
            cmbSustituido.FormattingEnabled = true;
            cmbSustituido.Location = new Point(471, 173);
            cmbSustituido.Name = "cmbSustituido";
            cmbSustituido.Size = new Size(151, 28);
            cmbSustituido.TabIndex = 123;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(471, 150);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 122;
            label4.Text = "Sustituido";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Location = new Point(41, 235);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 125;
            label5.Text = "Id";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Bottom;
            txtId.BackColor = Color.WhiteSmoke;
            txtId.Location = new Point(41, 258);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 124;
            // 
            // Sustituciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 435);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(cmbSustituido);
            Controls.Add(label4);
            Controls.Add(dtpBaja);
            Controls.Add(label2);
            Controls.Add(dtpAlta);
            Controls.Add(cmbATS);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Sustituciones";
            Text = "Sustituciones";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button button1;
        private Button button2;
        private Label label2;
        private DateTimePicker dtpAlta;
        private ComboBox cmbATS;
        private Label label10;
        private Label label3;
        private Button button4;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dtpBaja;
        private ComboBox cmbSustituido;
        private Label label4;
        private Label label5;
        private TextBox txtId;
    }
}