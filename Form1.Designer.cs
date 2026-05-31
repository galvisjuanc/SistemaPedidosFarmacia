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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "txtNombre";
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(113, 166);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(113, 265);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 2;
            txtCantidad.Text = "txtCantidad";
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
            Cemefar.Size = new Size(100, 24);
            Cemefar.TabIndex = 5;
            Cemefar.TabStop = true;
            Cemefar.Text = "rbCemefar";
            Cemefar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbCofarma);
            groupBox1.Controls.Add(Cemefar);
            groupBox1.Controls.Add(rbEmpsephar);
            groupBox1.Location = new Point(453, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // chkPrincipal
            // 
            chkPrincipal.AutoSize = true;
            chkPrincipal.BackgroundImageLayout = ImageLayout.Stretch;
            chkPrincipal.Location = new Point(453, 265);
            chkPrincipal.Name = "chkPrincipal";
            chkPrincipal.Size = new Size(110, 24);
            chkPrincipal.TabIndex = 7;
            chkPrincipal.Text = "chkPrincipal";
            chkPrincipal.UseVisualStyleBackColor = true;
            chkPrincipal.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkSecundaria
            // 
            chkSecundaria.AutoSize = true;
            chkSecundaria.BackgroundImageLayout = ImageLayout.Stretch;
            chkSecundaria.Location = new Point(453, 295);
            chkSecundaria.Name = "chkSecundaria";
            chkSecundaria.Size = new Size(126, 24);
            chkSecundaria.TabIndex = 8;
            chkSecundaria.Text = "chkSecundaria";
            chkSecundaria.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(128, 384);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(110, 29);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(459, 384);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(118, 29);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
