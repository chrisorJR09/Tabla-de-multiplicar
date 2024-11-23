namespace prac1
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
            panel1 = new Panel();
            button1 = new Button();
            richTextBoxresultados = new RichTextBox();
            textBoxnum = new TextBox();
            Ver = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fondo2;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(richTextBoxresultados);
            panel1.Controls.Add(textBoxnum);
            panel1.Controls.Add(Ver);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(24, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 316);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Nova Cut", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(13, 265);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.BackColor = Color.DarkGray;
            richTextBoxresultados.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxresultados.Font = new Font("Modern No. 20", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxresultados.Location = new Point(200, 96);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(88, 155);
            richTextBoxresultados.TabIndex = 5;
            richTextBoxresultados.Text = "";
            // 
            // textBoxnum
            // 
            textBoxnum.BackColor = SystemColors.ActiveCaption;
            textBoxnum.BorderStyle = BorderStyle.FixedSingle;
            textBoxnum.Font = new Font("Courier New", 6F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxnum.Location = new Point(13, 116);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(76, 17);
            textBoxnum.TabIndex = 4;
            // 
            // Ver
            // 
            Ver.BackColor = Color.Green;
            Ver.FlatAppearance.BorderColor = Color.LimeGreen;
            Ver.FlatStyle = FlatStyle.Popup;
            Ver.Font = new Font("Nova Oval", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Ver.ForeColor = Color.WhiteSmoke;
            Ver.Location = new Point(13, 157);
            Ver.Name = "Ver";
            Ver.Size = new Size(75, 23);
            Ver.TabIndex = 3;
            Ver.Text = "Ver Tabla";
            Ver.UseVisualStyleBackColor = false;
            Ver.Click += Ver_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 73);
            label3.Name = "label3";
            label3.Size = new Size(176, 21);
            label3.TabIndex = 2;
            label3.Text = "¿Cuál tabla deseas ver?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Orbitron", 11.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 39);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 1;
            label2.Text = "Tabla de multiplicar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cursive Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(311, 19);
            label1.TabIndex = 0;
            label1.Text = "Christopher Orlando Jauregui Rangel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Ver;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBoxresultados;
        private TextBox textBoxnum;
        private Button button1;
    }
}
