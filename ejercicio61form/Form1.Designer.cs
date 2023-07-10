namespace ejercicio61form
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
            BTNcancelar = new Button();
            BTNresultado = new Button();
            BTNsalir = new Button();
            text = new Label();
            textbi = new TextBox();
            SuspendLayout();
            // 
            // BTNcancelar
            // 
            BTNcancelar.Location = new Point(543, 97);
            BTNcancelar.Name = "BTNcancelar";
            BTNcancelar.Size = new Size(112, 34);
            BTNcancelar.TabIndex = 0;
            BTNcancelar.Text = "CANCELAR";
            BTNcancelar.UseVisualStyleBackColor = true;
            BTNcancelar.Click += BTNcancelar_Click;
            // 
            // BTNresultado
            // 
            BTNresultado.Location = new Point(338, 210);
            BTNresultado.Name = "BTNresultado";
            BTNresultado.Size = new Size(150, 34);
            BTNresultado.TabIndex = 1;
            BTNresultado.Text = "RESULTADO";
            BTNresultado.UseVisualStyleBackColor = true;
            BTNresultado.Click += BTNresultado_Click;
            // 
            // BTNsalir
            // 
            BTNsalir.Location = new Point(676, 404);
            BTNsalir.Name = "BTNsalir";
            BTNsalir.Size = new Size(112, 34);
            BTNsalir.TabIndex = 2;
            BTNsalir.Text = "SALIR";
            BTNsalir.UseVisualStyleBackColor = true;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Location = new Point(117, 108);
            text.Name = "text";
            text.Size = new Size(162, 25);
            text.TabIndex = 3;
            text.Text = "Ingrese un numero";
            // 
            // textbi
            // 
            textbi.Location = new Point(338, 98);
            textbi.Name = "textbi";
            textbi.Size = new Size(150, 31);
            textbi.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textbi);
            Controls.Add(text);
            Controls.Add(BTNsalir);
            Controls.Add(BTNresultado);
            Controls.Add(BTNcancelar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNcancelar;
        private Button BTNresultado;
        private Button BTNsalir;
        private Label text;
        private TextBox textbi;
    }
}