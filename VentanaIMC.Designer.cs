namespace CalculadoraIMC
{
    partial class VentanaIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaIMC));
            comboUnidadPeso = new ComboBox();
            comboUnidadAltura = new ComboBox();
            lblUnidadPeso = new Label();
            lblUnidadEstatura = new Label();
            lblResultado = new Label();
            btnCalcular = new Button();
            lblPeso = new Label();
            lblEstatura = new Label();
            campoEstatura = new TextBox();
            campoPeso = new TextBox();
            lblValidEstatura = new Label();
            lblValidPeso = new Label();
            pictureBox1 = new PictureBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboUnidadPeso
            // 
            comboUnidadPeso.FormattingEnabled = true;
            comboUnidadPeso.Items.AddRange(new object[] { "libras", "kilogramos" });
            comboUnidadPeso.Location = new Point(14, 199);
            comboUnidadPeso.Name = "comboUnidadPeso";
            comboUnidadPeso.Size = new Size(284, 28);
            comboUnidadPeso.TabIndex = 11;
            // 
            // comboUnidadAltura
            // 
            comboUnidadAltura.FormattingEnabled = true;
            comboUnidadAltura.Items.AddRange(new object[] { "metros", "centímetros", "pies", "pulgadas" });
            comboUnidadAltura.Location = new Point(14, 47);
            comboUnidadAltura.Name = "comboUnidadAltura";
            comboUnidadAltura.Size = new Size(284, 28);
            comboUnidadAltura.TabIndex = 10;
            comboUnidadAltura.SelectedIndexChanged += comboUnidadAltura_SelectedIndexChanged;
            // 
            // lblUnidadPeso
            // 
            lblUnidadPeso.AutoSize = true;
            lblUnidadPeso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidadPeso.Location = new Point(14, 176);
            lblUnidadPeso.Name = "lblUnidadPeso";
            lblUnidadPeso.Size = new Size(136, 20);
            lblUnidadPeso.TabIndex = 9;
            lblUnidadPeso.Text = "Unidad de medida";
            // 
            // lblUnidadEstatura
            // 
            lblUnidadEstatura.AutoSize = true;
            lblUnidadEstatura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidadEstatura.Location = new Point(14, 24);
            lblUnidadEstatura.Name = "lblUnidadEstatura";
            lblUnidadEstatura.Size = new Size(136, 20);
            lblUnidadEstatura.TabIndex = 8;
            lblUnidadEstatura.Text = "Unidad de medida";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.PaleGoldenrod;
            lblResultado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(321, 377);
            lblResultado.MaximumSize = new Size(429, 100);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 23);
            lblResultado.TabIndex = 15;
            
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightGreen;
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(14, 312);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Padding = new Padding(10, 11, 10, 11);
            btnCalcular.Size = new Size(284, 61);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeso.Location = new Point(14, 232);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(42, 20);
            lblPeso.TabIndex = 13;
            lblPeso.Text = "Peso";
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstatura.Location = new Point(14, 87);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(67, 20);
            lblEstatura.TabIndex = 12;
            lblEstatura.Text = "Estatura";
            // 
            // campoEstatura
            // 
            campoEstatura.Location = new Point(14, 111);
            campoEstatura.Margin = new Padding(3, 4, 3, 4);
            campoEstatura.Name = "campoEstatura";
            campoEstatura.Size = new Size(284, 27);
            campoEstatura.TabIndex = 2;
            campoEstatura.TextChanged += campoEstatura_TextChanged;
            // 
            // campoPeso
            // 
            campoPeso.Location = new Point(14, 255);
            campoPeso.Margin = new Padding(3, 4, 3, 4);
            campoPeso.Name = "campoPeso";
            campoPeso.Size = new Size(284, 27);
            campoPeso.TabIndex = 4;
            campoPeso.TextChanged += campoPeso_TextChanged;
            // 
            // lblValidEstatura
            // 
            lblValidEstatura.AutoSize = true;
            lblValidEstatura.Location = new Point(150, 145);
            lblValidEstatura.Name = "lblValidEstatura";
            lblValidEstatura.Size = new Size(15, 20);
            lblValidEstatura.TabIndex = 18;
            lblValidEstatura.Text = "-";
            // 
            // lblValidPeso
            // 
            lblValidPeso.AutoSize = true;
            lblValidPeso.Location = new Point(150, 289);
            lblValidPeso.Name = "lblValidPeso";
            lblValidPeso.Size = new Size(15, 20);
            lblValidPeso.TabIndex = 19;
            lblValidPeso.Text = "-";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(321, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 369);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Crimson;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(14, 379);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Padding = new Padding(10, 11, 10, 11);
            btnLimpiar.Size = new Size(284, 61);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // VentanaIMC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(688, 467);
            Controls.Add(btnLimpiar);
            Controls.Add(pictureBox1);
            Controls.Add(lblValidPeso);
            Controls.Add(lblValidEstatura);
            Controls.Add(campoPeso);
            Controls.Add(campoEstatura);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(lblPeso);
            Controls.Add(lblEstatura);
            Controls.Add(comboUnidadPeso);
            Controls.Add(comboUnidadAltura);
            Controls.Add(lblUnidadPeso);
            Controls.Add(lblUnidadEstatura);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VentanaIMC";
            Text = "Calculadora - Índice de Masa Corporal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboUnidadPeso;
        private ComboBox comboUnidadAltura;
        private Label lblUnidadPeso;
        private Label lblUnidadEstatura;
        private Label lblResultado;
        private Button btnCalcular;
        private Label lblPeso;
        private Label lblEstatura;
        private TextBox campoEstatura;
        private TextBox campoPeso;
        private Label lblValidEstatura;
        private Label lblValidPeso;
        private PictureBox pictureBox1;
        private Button btnLimpiar;
    }
}