namespace SistemaPedidosFarmacia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            cmbTipo = new ComboBox();
            txtCantidad = new TextBox();
            rbCofarma = new RadioButton();
            rbEmpsephar = new RadioButton();
            Cemefar = new RadioButton();
            groupBox1 = new GroupBox();
            chkPrincipal = new CheckBox();
            chkSecundaria = new CheckBox();
            btnBorrar = new Button();
            btnConfirmar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.GradientActiveCaption;
            txtNombre.Location = new Point(69, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(185, 27);
            txtNombre.TabIndex = 0;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = SystemColors.ActiveCaption;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(69, 212);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(185, 28);
            cmbTipo.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.GradientActiveCaption;
            txtCantidad.Location = new Point(69, 301);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(185, 27);
            txtCantidad.TabIndex = 2;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // rbCofarma
            // 
            rbCofarma.AutoSize = true;
            rbCofarma.Location = new Point(6, 26);
            rbCofarma.Name = "rbCofarma";
            rbCofarma.Size = new Size(87, 24);
            rbCofarma.TabIndex = 3;
            rbCofarma.TabStop = true;
            rbCofarma.Text = "Cofarma";
            rbCofarma.UseVisualStyleBackColor = true;
            // 
            // rbEmpsephar
            // 
            rbEmpsephar.AutoSize = true;
            rbEmpsephar.Location = new Point(6, 56);
            rbEmpsephar.Name = "rbEmpsephar";
            rbEmpsephar.Size = new Size(104, 24);
            rbEmpsephar.TabIndex = 4;
            rbEmpsephar.TabStop = true;
            rbEmpsephar.Text = "Empsephar";
            rbEmpsephar.UseVisualStyleBackColor = true;
            rbEmpsephar.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Cemefar
            // 
            Cemefar.AutoSize = true;
            Cemefar.Location = new Point(6, 86);
            Cemefar.Name = "Cemefar";
            Cemefar.Size = new Size(86, 24);
            Cemefar.TabIndex = 5;
            Cemefar.TabStop = true;
            Cemefar.Text = "Cemefar";
            Cemefar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbCofarma);
            groupBox1.Controls.Add(Cemefar);
            groupBox1.Controls.Add(rbEmpsephar);
            groupBox1.Location = new Point(327, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Distribuidor Farmaceútico";
            // 
            // chkPrincipal
            // 
            chkPrincipal.AutoSize = true;
            chkPrincipal.BackgroundImageLayout = ImageLayout.Stretch;
            chkPrincipal.Location = new Point(333, 275);
            chkPrincipal.Name = "chkPrincipal";
            chkPrincipal.Size = new Size(88, 24);
            chkPrincipal.TabIndex = 7;
            chkPrincipal.Text = "Principal";
            chkPrincipal.UseVisualStyleBackColor = true;
            chkPrincipal.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkSecundaria
            // 
            chkSecundaria.AutoSize = true;
            chkSecundaria.BackgroundImageLayout = ImageLayout.Stretch;
            chkSecundaria.Location = new Point(333, 305);
            chkSecundaria.Name = "chkSecundaria";
            chkSecundaria.Size = new Size(104, 24);
            chkSecundaria.TabIndex = 8;
            chkSecundaria.Text = "Secundaria";
            chkSecundaria.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(113, 384);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(110, 29);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(408, 384);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(118, 29);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 78);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 11;
            label1.Text = "Nombre del Medicamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(113, 21);
            label2.Name = "label2";
            label2.Size = new Size(413, 38);
            label2.TabIndex = 12;
            label2.Text = "Sistema de Pedidos de Farmacia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 166);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 13;
            label3.Text = "Tipo de Medicamento";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 260);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 14;
            label4.Text = "Cantidad Solicitada";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 243);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 15;
            label5.Text = "Sede Farmaceútica";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConfirmar);
            Controls.Add(btnBorrar);
            Controls.Add(chkSecundaria);
            Controls.Add(chkPrincipal);
            Controls.Add(groupBox1);
            Controls.Add(txtCantidad);
            Controls.Add(cmbTipo);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private ComboBox cmbTipo;
        private TextBox txtCantidad;
        private RadioButton rbCofarma;
        private RadioButton rbEmpsephar;
        private RadioButton Cemefar;
        private GroupBox groupBox1;
        private CheckBox chkPrincipal;
        private CheckBox chkSecundaria;
        private Button btnBorrar;
        private Button btnConfirmar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
