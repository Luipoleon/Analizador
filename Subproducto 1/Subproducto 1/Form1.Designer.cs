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
            TextBox_Analizador = new TextBox();
            Lexema = new DataGridViewTextBoxColumn();
            Símbolo = new DataGridViewTextBoxColumn();
            Token = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridTokens).BeginInit();
            SuspendLayout();
            // 
            // Boton_Ingresar
            // 
            Boton_Ingresar.Location = new Point(358, 12);
            Boton_Ingresar.Name = "Boton_Ingresar";
            Boton_Ingresar.Size = new Size(75, 23);
            Boton_Ingresar.TabIndex = 0;
            Boton_Ingresar.Text = "Ingresar";
            Boton_Ingresar.UseVisualStyleBackColor = true;
            Boton_Ingresar.Click += Boton_Ingresar_Click;
            // 
            // dataGridTokens
            // 
            dataGridTokens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTokens.Columns.AddRange(new DataGridViewColumn[] { Lexema, Símbolo, Token });
            dataGridTokens.Location = new Point(12, 41);
            dataGridTokens.Name = "dataGridTokens";
            dataGridTokens.RowTemplate.Height = 25;
            dataGridTokens.Size = new Size(421, 397);
            dataGridTokens.TabIndex = 1;
            // 
            // TextBox_Analizador
            // 
            TextBox_Analizador.Location = new Point(12, 11);
            TextBox_Analizador.Name = "TextBox_Analizador";
            TextBox_Analizador.Size = new Size(340, 23);
            TextBox_Analizador.TabIndex = 2;
            // 
            // Lexema
            // 
            Lexema.HeaderText = "Lexema";
            Lexema.Name = "Lexema";
            // 
            // Símbolo
            // 
            Símbolo.HeaderText = "Simbolo";
            Símbolo.Name = "Símbolo";
            Símbolo.Width = 200;
            // 
            // Token
            // 
            Token.HeaderText = "Token";
            Token.Name = "Token";
            // 
            // Analizador_Lexico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
            Controls.Add(TextBox_Analizador);
            Controls.Add(dataGridTokens);
            Controls.Add(Boton_Ingresar);
            Name = "Analizador_Lexico";
            Text = "Analizador Lexico";
            ((System.ComponentModel.ISupportInitialize)dataGridTokens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Boton_Ingresar;
        private DataGridView dataGridTokens;
        private TextBox TextBox_Analizador;
        private DataGridViewTextBoxColumn Lexema;
        private DataGridViewTextBoxColumn Símbolo;
        private DataGridViewTextBoxColumn Token;
    }
}