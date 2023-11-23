using analizador;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;


namespace Subproducto_1
{
    internal static class GeneradorCodigo
    {

        #region Métodos públicos

        #region GenerarCodigo
        public static List<string> GenerarCodigo(List<Token> listaTokens)
        {
            //1) Crear una cola de Tokens
            Queue<Token> colaTokens = ConvertirACola(listaTokens);
            //2) Crear variables para almacenar valores de manera temporal
            List <Token> elemento  = new List<Token>();
            Dictionary<string, string> dict;
            List<string> elementosConvertidos = new List<string>();
            
            // 3) Convertir elementos
            while(colaTokens.Count > 0 )
            {
                Token token = colaTokens.Dequeue();
                elemento.Add(token);
                if(token.Lexema.Equals(";"))
                {
                    dict = IdentificarValoresElemento(elemento);
                    elementosConvertidos.Add(ConvertirElemento(dict));
                    elemento.Clear();
                    dict.Clear();
                }
            }

            return elementosConvertidos;
            
        }

        #endregion

        #endregion

        #region Métodos privados
        #region IdentificarValoresElemento
        private static Dictionary<string, string> IdentificarValoresElemento(List<Token> tokens)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            int contadorValores = 0;
            
            // Identificar tipo de elemento
            dict["tipo"] = IdentificarTipoElemento(tokens);

            #region Identificar Valores
            foreach (Token token in tokens)
            {
                string lexema = token.Lexema;

                #region Agregar Valores
                if (EsValor(token))
                {
                    string key = "valor-" + ++contadorValores;
                    dict[key] = lexema;
                }
                #endregion
            }
            #endregion
            return dict;
        }

        #endregion

        #region IdentificarTipoElemento
        private static string IdentificarTipoElemento(List<Token> tokens)
        {
            List<string> tipos = new List<string>();

            foreach (Token t in tokens)
            {
                if(t.Lexema.Equals("=")) tipos.Add("=");
                if (t.Valor == (int)TokenType.TIPO_DATO) tipos.Add("declaracion");
                if (t.Lexema.Equals("+")) tipos.Add("+");
                if (t.Lexema.Equals("-")) tipos.Add("-");
                if (t.Lexema.Equals("*")) tipos.Add("*");
                if (t.Lexema.Equals("/")) tipos.Add("/");
            }
            return string.Join('_', tipos);
        }
        #endregion

        #region EsValor
        private static bool EsValor(Token token)
        {
            if
            (
                token.Valor == (int)TokenType.IDENTIFICADOR ||
                token.Valor == (int)TokenType.ENTERO ||
                token.Valor == (int)TokenType.DECIMAL
             
            )
            {
                return true;
            }
           

            return false;
        }

        #endregion

        #region ConvertirElemento
        private static string ConvertirElemento(Dictionary<string, string> dict)
        {
            string conversion = "";
            switch (dict["tipo"])
            {
                case "declaracion_=":
                    break;
                case "=":
                    break;
                case "=_+":
                    break;
                case "=_*":
                    break;
                case "=_-":
                    break;
                case "=_/":
                    break;
            }
            return conversion;
        }
        #endregion

        #region ConvertirACola
        private static Queue<Token> ConvertirACola(List<Token> listaTokens)
        { 

            Queue<Token> colaTokens = new Queue<Token>();
            foreach(Token t in listaTokens)
            {
                colaTokens.Enqueue(t);
            }
            return colaTokens;
        }
        #endregion

        #region Conversiones
        public static string Inicio()
        {
            string cadena = ".CODE\n";
            return cadena;
        }
        public static string Fin()
        {
            string cadena = "END\n";
            return cadena;
        }
        public static string Sumar(string a, string b)
        {
            string cadena = "";
            cadena += "MOV AX," + a + "\n";
            cadena += "ADD AX," + b + "\n";
            cadena += "MOV [100], AX\n";
            return cadena;
        }
        public static string Sumar(string a, string b, string c)
        {
            string cadena = "";
            cadena += "MOV AX," + b + "\n";
            cadena += "ADD AX," + c + "\n";
            cadena += "MOV " + a + ", AX\n";
            return cadena;
        }
        public static string Restar(string a, string b)
        {
            string cadena = "";
            cadena += "MOV AX," + a + "\n";
            cadena += "SUB AX," + b + "\n";
            cadena += "MOV [100], AX\n";
            return cadena;
        }
        public static string Restar(string a, string b, string c)
        {
            string cadena = "";
            cadena += "MOV AX," + b + "\n";
            cadena += "SUB AX," + c + "\n";
            cadena += "MOV " + a + ", AX\n";
            return cadena;
        }
        public static string Dividir(string a, string b)
        {
            string cadena = "";
            cadena += "MOV AX," + a + "\n";
            cadena += "DIV AX," + b + "\n";
            cadena += "MOV [100], AX\n";
            return cadena;
        }
        public static string Dividir(string a, string b, string c)
        {
            string cadena = "";
            cadena += "MOV AX," + b + "\n";
            cadena += "DIV AX," + c + "\n";
            cadena += "MOV " + a + ", AX\n";
            return cadena;
        }
        public static string Multiplicar(string a, string b)
        {
            string cadena = "";
            cadena += "MOV AX," + a + "\n";
            cadena += "MUL AX," + b + "\n";
            cadena += "MOV [100], AX\n";
            return cadena;
        }
        public static string Multiplicar(string a, string b, string c)
        {
            string cadena = "";
            cadena += "MOV AX," + b + "\n";
            cadena += "MUL AX," + c + "\n";
            cadena += "MOV " + a + ", AX\n";
            return cadena;
        }
        public static string Asignar(string a, string b)
        {
            string cadena = "";
            cadena += a + " db 4\n";
            cadena += "MOV AX, " + b + "\n";
            cadena += "MOV " + a + ",AX\n";
            return cadena;
        }

        #endregion

        #endregion

    }
}
