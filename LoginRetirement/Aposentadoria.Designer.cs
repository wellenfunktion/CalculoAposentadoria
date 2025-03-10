namespace LoginRetirement
{
    partial class Aposentadoria
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
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            buttonCalcular = new Button();
            comboBoxGenero = new ComboBox();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(388, 198);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(203, 148);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 3;
            label1.Text = "Genero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(388, 148);
            label2.Name = "label2";
            label2.Size = new Size(150, 21);
            label2.TabIndex = 4;
            label2.Text = "Data de Nascimento";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(513, 257);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 5;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click_1;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Homem", "Mulher" });
            comboBoxGenero.Location = new Point(203, 198);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(121, 23);
            comboBoxGenero.TabIndex = 6;
            // 
            // Aposentadoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxGenero);
            Controls.Add(buttonCalcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            Name = "Aposentadoria";
            Text = "Calculo de Aposentadoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker;
        private Label label1;
        private Label label2;
        private Button buttonCalcular;
        private ComboBox comboBoxGenero;
    }
}