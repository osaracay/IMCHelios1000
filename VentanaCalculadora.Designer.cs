namespace CalculadoraIMC
{
    partial class VentanaCalculadora
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
            lblEstatura = new Label();
            lblUnidadEstatura = new Label();
            lblPeso = new Label();
            lblUnidadPeso = new Label();
            campoEstatura = new NumericUpDown();
            campoPeso = new NumericUpDown();
            comboUnidadAltura = new ComboBox();
            comboUnidadPeso = new ComboBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)campoEstatura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)campoPeso).BeginInit();
            SuspendLayout();
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Location = new Point(40, 35);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(49, 15);
            lblEstatura.TabIndex = 0;
            lblEstatura.Text = "Estatura";
            // 
            // lblUnidadEstatura
            // 
            lblUnidadEstatura.AutoSize = true;
            lblUnidadEstatura.Location = new Point(256, 35);
            lblUnidadEstatura.Name = "lblUnidadEstatura";
            lblUnidadEstatura.Size = new Size(104, 15);
            lblUnidadEstatura.TabIndex = 1;
            lblUnidadEstatura.Text = "Unidad de medida";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(40, 92);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Peso";
            // 
            // lblUnidadPeso
            // 
            lblUnidadPeso.AutoSize = true;
            lblUnidadPeso.Location = new Point(256, 102);
            lblUnidadPeso.Name = "lblUnidadPeso";
            lblUnidadPeso.Size = new Size(104, 15);
            lblUnidadPeso.TabIndex = 3;
            lblUnidadPeso.Text = "Unidad de medida";
            // 
            // campoEstatura
            // 
            campoEstatura.Location = new Point(40, 52);
            campoEstatura.Margin = new Padding(3, 2, 3, 2);
            campoEstatura.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            campoEstatura.Name = "campoEstatura";
            campoEstatura.Size = new Size(131, 23);
            campoEstatura.TabIndex = 4;
            campoEstatura.ValueChanged += campoEstatura_ValueChanged;
            // 
            // campoPeso
            // 
            campoPeso.Location = new Point(40, 118);
            campoPeso.Margin = new Padding(3, 2, 3, 2);
            campoPeso.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            campoPeso.Name = "campoPeso";
            campoPeso.Size = new Size(131, 23);
            campoPeso.TabIndex = 5;
            // 
            // comboUnidadAltura
            // 
            comboUnidadAltura.FormattingEnabled = true;
            comboUnidadAltura.Items.AddRange(new object[] { "centímetros", "pies", "pulgadas" });
            comboUnidadAltura.Location = new Point(205, 52);
            comboUnidadAltura.Margin = new Padding(3, 2, 3, 2);
            comboUnidadAltura.Name = "comboUnidadAltura";
            comboUnidadAltura.Size = new Size(168, 23);
            comboUnidadAltura.TabIndex = 6;
            // 
            // comboUnidadPeso
            // 
            comboUnidadPeso.FormattingEnabled = true;
            comboUnidadPeso.Items.AddRange(new object[] { "libras", "kilogramos" });
            comboUnidadPeso.Location = new Point(205, 119);
            comboUnidadPeso.Margin = new Padding(3, 2, 3, 2);
            comboUnidadPeso.Name = "comboUnidadPeso";
            comboUnidadPeso.Size = new Size(168, 23);
            comboUnidadPeso.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(292, 160);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Padding = new Padding(9, 8, 9, 8);
            btnCalcular.Size = new Size(80, 46);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            btnCalcular.MouseClick += btnCalcular_MouseClick;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(40, 165);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(11, 15);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "r";
            // 
            // VentanaCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 244);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(comboUnidadPeso);
            Controls.Add(comboUnidadAltura);
            Controls.Add(campoPeso);
            Controls.Add(campoEstatura);
            Controls.Add(lblUnidadPeso);
            Controls.Add(lblPeso);
            Controls.Add(lblUnidadEstatura);
            Controls.Add(lblEstatura);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VentanaCalculadora";
            Text = "Calculadora IMC";
            ((System.ComponentModel.ISupportInitialize)campoEstatura).EndInit();
            ((System.ComponentModel.ISupportInitialize)campoPeso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstatura;
        private Label lblUnidadEstatura;
        private Label lblPeso;
        private Label lblUnidadPeso;
        private NumericUpDown campoEstatura;
        private NumericUpDown campoPeso;
        private ComboBox comboUnidadAltura;
        private ComboBox comboUnidadPeso;
        private Button btnCalcular;
        private Label lblResultado;
    }
}