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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboUnidadPeso
            // 
            comboUnidadPeso.FormattingEnabled = true;
            comboUnidadPeso.Items.AddRange(new object[] { "libras", "kilogramos" });
            comboUnidadPeso.Location = new Point(12, 149);
            comboUnidadPeso.Margin = new Padding(3, 2, 3, 2);
            comboUnidadPeso.Name = "comboUnidadPeso";
            comboUnidadPeso.Size = new Size(249, 23);
            comboUnidadPeso.TabIndex = 11;
            // 
            // comboUnidadAltura
            // 
            comboUnidadAltura.FormattingEnabled = true;
            comboUnidadAltura.Items.AddRange(new object[] { "metros", "centímetros", "pies", "pulgadas" });
            comboUnidadAltura.Location = new Point(12, 35);
            comboUnidadAltura.Margin = new Padding(3, 2, 3, 2);
            comboUnidadAltura.Name = "comboUnidadAltura";
            comboUnidadAltura.Size = new Size(249, 23);
            comboUnidadAltura.TabIndex = 10;
            comboUnidadAltura.SelectedIndexChanged += comboUnidadAltura_SelectedIndexChanged;
            // 
            // lblUnidadPeso
            // 
            lblUnidadPeso.AutoSize = true;
            lblUnidadPeso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidadPeso.Location = new Point(12, 132);
            lblUnidadPeso.Name = "lblUnidadPeso";
            lblUnidadPeso.Size = new Size(107, 15);
            lblUnidadPeso.TabIndex = 9;
            lblUnidadPeso.Text = "Unidad de medida";
            // 
            // lblUnidadEstatura
            // 
            lblUnidadEstatura.AutoSize = true;
            lblUnidadEstatura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidadEstatura.Location = new Point(12, 18);
            lblUnidadEstatura.Name = "lblUnidadEstatura";
            lblUnidadEstatura.Size = new Size(107, 15);
            lblUnidadEstatura.TabIndex = 8;
            lblUnidadEstatura.Text = "Unidad de medida";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.PaleGoldenrod;
            lblResultado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(12, 282);
            lblResultado.MaximumSize = new Size(375, 75);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 17);
            lblResultado.TabIndex = 15;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightGreen;
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(12, 234);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Padding = new Padding(9, 8, 9, 8);
            btnCalcular.Size = new Size(249, 46);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeso.Location = new Point(12, 174);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(33, 15);
            lblPeso.TabIndex = 13;
            lblPeso.Text = "Peso";
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstatura.Location = new Point(12, 65);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(52, 15);
            lblEstatura.TabIndex = 12;
            lblEstatura.Text = "Estatura";
            // 
            // campoEstatura
            // 
            campoEstatura.Location = new Point(12, 83);
            campoEstatura.Name = "campoEstatura";
            campoEstatura.Size = new Size(249, 23);
            campoEstatura.TabIndex = 16;
            campoEstatura.TextChanged += campoEstatura_TextChanged;
            // 
            // campoPeso
            // 
            campoPeso.Location = new Point(12, 191);
            campoPeso.Name = "campoPeso";
            campoPeso.Size = new Size(249, 23);
            campoPeso.TabIndex = 17;
            campoPeso.TextChanged += campoPeso_TextChanged;
            // 
            // lblValidEstatura
            // 
            lblValidEstatura.AutoSize = true;
            lblValidEstatura.Location = new Point(131, 109);
            lblValidEstatura.Name = "lblValidEstatura";
            lblValidEstatura.Size = new Size(12, 15);
            lblValidEstatura.TabIndex = 18;
            lblValidEstatura.Text = "-";
            // 
            // lblValidPeso
            // 
            lblValidPeso.AutoSize = true;
            lblValidPeso.Location = new Point(131, 217);
            lblValidPeso.Name = "lblValidPeso";
            lblValidPeso.Size = new Size(12, 15);
            lblValidPeso.TabIndex = 19;
            lblValidPeso.Text = "-";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(306, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // VentanaIMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(571, 350);
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
            Name = "VentanaIMC";
            Text = "VentanaIMC";
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
    }
}