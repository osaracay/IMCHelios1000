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
            ((System.ComponentModel.ISupportInitialize)campoEstatura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)campoPeso).BeginInit();
            SuspendLayout();
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Location = new Point(46, 47);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(62, 20);
            lblEstatura.TabIndex = 0;
            lblEstatura.Text = "Estatura";
            lblEstatura.Click += label1_Click;
            // 
            // lblUnidadEstatura
            // 
            lblUnidadEstatura.AutoSize = true;
            lblUnidadEstatura.Location = new Point(293, 47);
            lblUnidadEstatura.Name = "lblUnidadEstatura";
            lblUnidadEstatura.Size = new Size(133, 20);
            lblUnidadEstatura.TabIndex = 1;
            lblUnidadEstatura.Text = "Unidad de medida";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(46, 122);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(39, 20);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Peso";
            // 
            // lblUnidadPeso
            // 
            lblUnidadPeso.AutoSize = true;
            lblUnidadPeso.Location = new Point(293, 136);
            lblUnidadPeso.Name = "lblUnidadPeso";
            lblUnidadPeso.Size = new Size(133, 20);
            lblUnidadPeso.TabIndex = 3;
            lblUnidadPeso.Text = "Unidad de medida";

            // 
            // campoEstatura
            // 
            campoEstatura.Location = new Point(46, 70);
            campoEstatura.Name = "campoEstatura";
            campoEstatura.Size = new Size(150, 27);
            campoEstatura.TabIndex = 4;
            campoEstatura.Maximum = 200;
            campoEstatura.Minimum = 0;

            campoEstatura.ValueChanged += campoEstatura_ValueChanged;
            // 
            // campoPeso
            // 
            campoPeso.Location = new Point(46, 157);
            campoPeso.Name = "campoPeso";
            campoPeso.Size = new Size(150, 27);
            campoPeso.TabIndex = 5;

            campoPeso.Minimum = 0;
            campoPeso.Maximum = 500;
            // 
            // comboUnidadAltura
            // 
            
            comboUnidadAltura.FormattingEnabled = true;
            comboUnidadAltura.Items.AddRange(new object[] { "metros", "centímetros", "pies", "pulgadas" });
            comboUnidadAltura.SelectedItem = "metros";
            comboUnidadAltura.Location = new Point(234, 69);
            comboUnidadAltura.Name = "comboUnidadAltura";
            comboUnidadAltura.Size = new Size(192, 28);
            comboUnidadAltura.TabIndex = 6;
            // 
            // comboUnidadPeso
            // 
            comboUnidadPeso.FormattingEnabled = true;
            comboUnidadPeso.Items.AddRange(new object[] { "kilogramos", "libras" });
            comboUnidadPeso.SelectedItem = "kilogramos";
            comboUnidadPeso.Location = new Point(234, 159);
            comboUnidadPeso.Name = "comboUnidadPeso";
            comboUnidadPeso.Size = new Size(192, 28);
            comboUnidadPeso.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(334, 214);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Padding = new Padding(10);
            btnCalcular.Size = new Size(92, 44);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // VentanaCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 289);
            Controls.Add(btnCalcular);
            Controls.Add(comboUnidadPeso);
            Controls.Add(comboUnidadAltura);
            Controls.Add(campoPeso);
            Controls.Add(campoEstatura);
            Controls.Add(lblUnidadPeso);
            Controls.Add(lblPeso);
            Controls.Add(lblUnidadEstatura);
            Controls.Add(lblEstatura);
            Name = "VentanaCalculadora";
            Text = "Calculadora IMC";
            Load += VentanaCalculadora_Load;
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
    }
}