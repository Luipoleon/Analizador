namespace Subproducto_1
{
    partial class Analizador_Lexico
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
            ((System.ComponentModel.ISupportInitialize)dataGridTokens).BeginInit();
            SuspendLayout();
            // 
            // Boton_Ingresar
            // 
            Boton_Ingresar.Location = new Point(465, 176);
            Boton_Ingresar.Margin = new Padding(3, 4, 3, 4);
            Boton_Ingresar.Name = "Boton_Ingresar";
            Boton_Ingresar.Size = new Size(86, 31);
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
            dataGridTokens.Location = new Point(14, 215);
            dataGridTokens.Margin = new Padding(3, 4, 3, 4);
            dataGridTokens.Name = "dataGridTokens";
            dataGridTokens.RowHeadersWidth = 51;
            dataGridTokens.RowTemplate.Height = 25;
            dataGridTokens.Size = new Size(481, 369);
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
            TextBox_Analizador.Location = new Point(14, 15);
            TextBox_Analizador.Margin = new Padding(3, 4, 3, 4);
            TextBox_Analizador.Multiline = true;
            TextBox_Analizador.Name = "TextBox_Analizador";
            TextBox_Analizador.Size = new Size(1037, 153);
            TextBox_Analizador.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(514, 215);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(537, 369);
            textBox1.TabIndex = 3;
            // 
            // Analizador_Lexico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 600);
            Controls.Add(textBox1);
            Controls.Add(TextBox_Analizador);
            Controls.Add(dataGridTokens);
            Controls.Add(Boton_Ingresar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Analizador_Lexico";
            Text = "Analizador Lexico";
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
    }
}