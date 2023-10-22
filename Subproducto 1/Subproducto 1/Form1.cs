using analizador;
namespace Subproducto_1
{
    public partial class Analizador_Lexico : Form
    {

        public Analizador_Lexico()
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
            Stack<string> pila = AnalizadorSintactico.Sintactico(listTokens);
            string input1 = textBox1.Text.Trim();
            textBox1.Text = "";
            if (pila.Count == 1)
            {
                textBox1.Text = "Se esperaba un simbolo de cierre en la fila: " + pila.Pop();

            }
            else if (pila.Count == 2)
            {
                textBox1.Text = pila.Pop() + "\n en la fila: " + pila.Pop();
            }
            else
            {
                textBox1.Text = "No se han encontrado errores sintacticos";
            }
            textBox1.Update();
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