using analizador;
using System.Runtime.CompilerServices;

namespace Subproducto_1
{
    public partial class Analizador : Form
    {

        public Analizador()
        {
            InitializeComponent();

        }

        private void Boton_Ingresar_Click(object sender, EventArgs e)
        {
            string input = TextBox_Analizador.Text.Trim();
            List<Token> listTokens = AnalizadorLexico.Analizar(input);

            //Limpiar el grid

            dataGridTokens.Rows.Clear();

            //Agregar los Tokens

            foreach (Token token in listTokens)
            {
                dataGridTokens.Rows.Add(token.Lexema, token.Nombre, token.Valor);
            }


            dataGridTokens.Update();

            //LLamada a analizador sintactico
            Stack<string>[] errores = AnalizadorSintactico.Sintactico(listTokens);
            Stack<string> pilaSemantico = errores[0];
            Stack<string> pilaSintactico = errores[1];
            List<string> codigoFinal;


            UpdateErrorText(pilaSemantico, textBox1);
            UpdateErrorText2(pilaSintactico, textBox2);

            if (pilaSemantico.Count != 0 || pilaSintactico.Count != 0)
            {
                return;
            }

            codigoFinal = GeneradorCodigo.GenerarCodigo(listTokens);
            UpdateGeneratedCode(codigoFinal, textBox3);

        }

        private void UpdateGeneratedCode(List<string> codigoFinal, TextBox textBox)
        {
            textBox.Text = "";
            foreach (string codigo in codigoFinal)
            {
                textBox.Text += codigo;
            }
        }
        private void UpdateErrorText(Stack<string> pila, TextBox textBox)
        {
            textBox.Text.Trim();
            textBox.Text = "";
            if (pila.Count == 1)
            {
                textBox.Text = "Se esperaba un simbolo de cierre en la fila " + pila.Pop();

            }
            else if (pila.Count == 2)
            {
                textBox.Text = pila.Pop() + ". \nFila: " + pila.Pop();
            }
            else
            {
                textBox.Text = "No se han encontrado errores sintácticos";
            }
            textBox.Update();
        }

        private void UpdateErrorText2(Stack<string> pila, TextBox textBox)
        {
            textBox.Text.Trim();
            textBox.Text = "";

            if (pila.Count >= 1)
            {
                while (pila.Count > 0)
                {
                    textBox.Multiline = true;
                    textBox.Text += pila.Pop() + ". Fila: " + pila.Pop() + "\r\n";
                }
            }
            else
            {
                textBox.Text = "No se han encontrado errores semánticos";
            }
            textBox.Update();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        TextBox_Analizador.Text = reader.ReadToEnd();
                    }
                }
            }
        }
    }
}