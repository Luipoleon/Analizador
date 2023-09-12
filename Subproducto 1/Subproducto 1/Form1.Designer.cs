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
            dataGridView1 = new DataGridView();
            Lexema = new DataGridViewTextBoxColumn();
            Token = new DataGridViewTextBoxColumn();
            Simbolo = new DataGridViewTextBoxColumn();
            TextBox_Analizador = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Boton_Ingresar
            // 
            Boton_Ingresar.Location = new Point(281, 11);
            Boton_Ingresar.Name = "Boton_Ingresar";
            Boton_Ingresar.Size = new Size(75, 23);
            Boton_Ingresar.TabIndex = 0;
            Boton_Ingresar.Text = "Ingresar";
            Boton_Ingresar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Lexema, Token, Simbolo });
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(343, 397);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Lexema
            // 
            Lexema.HeaderText = "Lexema";
            Lexema.Name = "Lexema";
            // 
            // Token
            // 
            Token.HeaderText = "Token";
            Token.Name = "Token";
            // 
            // Simbolo
            // 
            Simbolo.HeaderText = "Simbolo";
            Simbolo.Name = "Simbolo";
            // 
            // TextBox_Analizador
            // 
            TextBox_Analizador.Location = new Point(12, 11);
            TextBox_Analizador.Name = "TextBox_Analizador";
            TextBox_Analizador.Size = new Size(263, 23);
            TextBox_Analizador.TabIndex = 2;
            // 
            // Analizador_Lexico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 450);
            Controls.Add(TextBox_Analizador);
            Controls.Add(dataGridView1);
            Controls.Add(Boton_Ingresar);
            Name = "Analizador_Lexico";
            Text = "Analizador Lexico";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Boton_Ingresar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Lexema;
        private DataGridViewTextBoxColumn Token;
        private DataGridViewTextBoxColumn Simbolo;
        private TextBox TextBox_Analizador;
    }
}