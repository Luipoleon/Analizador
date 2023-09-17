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
            TextBox_Analizador.Text = "";

            //Limpiar el grid

            dataGridTokens.Rows.Clear();

            //Agregar los Tokens

            foreach (Token token in listTokens)
            {
                dataGridTokens.Rows.Add(token.Lexema, token.Nombre, token.Valor);
            }

            dataGridTokens.Update();
        }
    }
}