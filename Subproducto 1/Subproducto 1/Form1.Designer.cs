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
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridTokens).BeginInit();
            SuspendLayout();
            // 
            // Boton_Ingresar
            // 
            Boton_Ingresar.Location = new Point(1025, 74);
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
            dataGridTokens.Location = new Point(12, 271);
            dataGridTokens.Name = "dataGridTokens";
            dataGridTokens.RowHeadersWidth = 51;
            dataGridTokens.RowTemplate.Height = 25;
            dataGridTokens.Size = new Size(421, 266);
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
            TextBox_Analizador.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_Analizador.Location = new Point(450, 34);
            TextBox_Analizador.Multiline = true;
            TextBox_Analizador.Name = "TextBox_Analizador";
            TextBox_Analizador.Size = new Size(512, 204);
            TextBox_Analizador.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(450, 271);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(370, 266);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(1022, 148);
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
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(838, 271);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(370, 266);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(12, 34);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(421, 204);
            textBox3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(686, 16);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 7;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 16);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 8;
            label2.Text = "Código Generado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(602, 254);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 9;
            label3.Text = "Semántico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(982, 254);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 10;
            label4.Text = "Sintáctico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 253);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 11;
            label5.Text = "Léxico";
            // 
            // Analizador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 552);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(TextBox_Analizador);
            Controls.Add(dataGridTokens);
            Controls.Add(Boton_Ingresar);
            MaximizeBox = false;
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
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}