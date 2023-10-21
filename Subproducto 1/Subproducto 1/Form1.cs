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
            if (pila.Count > 0 )
            {
                textBox1.Text = "Se ha encontrado un error en el token: " +pila.Pop() + "\n en la fila: " + pila.Pop();

            }
            else
            {
                textBox1.Text = "No se han encontrado errores sintacticos";
            }
            textBox1.Update();
        }
    }
}