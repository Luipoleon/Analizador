namespace Subproducto_1
{
    partial class Analizador
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
            Boton_Ingresar = new Button();
            dataGridTokens = new DataGridView();
            Lexema = new DataGridViewTextBoxColumn();
            Símbolo = new DataGridViewTextBoxColumn();
            Token = new DataGridViewTextBoxColumn();
            TextBox_Analizador = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridTokens).BeginInit();
            SuspendLayout();
            // 
            // Boton_Ingresar
            // 
            Boton_Ingresar.Location = new Point(1006, 22);
            Boton_Ingresar.Name = "Boton_Ingresar";
            Boton_Ingresar.Size = new Size(117, 31);
            Boton_Ingresar.TabIndex = 0;
            Boton_Ingresar.TabStop = false;
            Boton_Ingresar.Text = "Analizar";
            Boton_Ingresar.UseVisualStyleBackColor = true;
            Boton_Ingresar.Click += Boton_Ingresar_Click;
            // 
            // dataGridTokens
            // 
            dataGridTokens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTokens.Columns.AddRange(new DataGridViewColumn[] { Lexema, Símbolo, Token });
            dataGridTokens.Location = new Point(12, 161);
            dataGridTokens.Name = "dataGridTokens";
            dataGridTokens.RowHeadersWidth = 51;
            dataGridTokens.RowTemplate.Height = 25;
            dataGridTokens.Size = new Size(421, 278);
            dataGridTokens.TabIndex = 1;
            // 
            // Lexema
            // 
            Lexema.HeaderText = "Lexema";
            Lexema.MinimumWidth = 6;
            Lexema.Name = "Lexema";
            Lexema.Width = 125;
            // 
            // Símbolo
            // 
            Símbolo.HeaderText = "Simbolo";
            Símbolo.MinimumWidth = 6;
            Símbolo.Name = "Símbolo";
            Símbolo.Width = 200;
            // 
            // Token
            // 
            Token.HeaderText = "Token";
            Token.MinimumWidth = 6;
            Token.Name = "Token";
            Token.Width = 125;
            // 
            // TextBox_Analizador
            // 
            TextBox_Analizador.Location = new Point(12, 11);
            TextBox_Analizador.Multiline = true;
            TextBox_Analizador.Name = "TextBox_Analizador";
            TextBox_Analizador.Size = new Size(929, 116);
            TextBox_Analizador.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(450, 161);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(370, 278);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(1006, 75);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(120, 34);
            button1.TabIndex = 4;
            button1.Text = "Abrir archivo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(838, 161);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(370, 278);
            textBox2.TabIndex = 5;
            // 
            // Analizador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 509);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(TextBox_Analizador);
            Controls.Add(dataGridTokens);
            Controls.Add(Boton_Ingresar);
            Name = "Analizador";
            Text = "Analizador";
            ((System.ComponentModel.ISupportInitialize)dataGridTokens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Boton_Ingresar;
        private DataGridView dataGridTokens;
        private DataGridViewTextBoxColumn Lexema;
        private DataGridViewTextBoxColumn Símbolo;
        private DataGridViewTextBoxColumn Token;
        private TextBox TextBox_Analizador;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
    }
}