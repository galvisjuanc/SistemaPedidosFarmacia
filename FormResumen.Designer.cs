namespace SistemaPedidosFarmacia
{
    partial class FormResumen
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
            lblMedicamento = new Label();
            lblDireccion = new Label();
            btnCancelar = new Button();
            btnEnviar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblMedicamento
            // 
            lblMedicamento.AutoSize = true;
            lblMedicamento.Location = new Point(29, 97);
            lblMedicamento.Name = "lblMedicamento";
            lblMedicamento.Size = new Size(118, 20);
            lblMedicamento.TabIndex = 0;
            lblMedicamento.Text = "lblMedicamento";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(29, 156);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(89, 20);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "lblDireccion";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(29, 231);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(256, 231);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 21);
            label1.Name = "label1";
            label1.Size = new Size(321, 38);
            label1.TabIndex = 4;
            label1.Text = "Confirmacion del Pedido";
            // 
            // FormResumen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 302);
            Controls.Add(label1);
            Controls.Add(btnEnviar);
            Controls.Add(btnCancelar);
            Controls.Add(lblDireccion);
            Controls.Add(lblMedicamento);
            Name = "FormResumen";
            Text = "FormResumen";
            Load += FormResumen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMedicamento;
        private Label lblDireccion;
        private Button btnCancelar;
        private Button btnEnviar;
        private Label label1;
    }
}