﻿using analizador;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Policy;


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
            elementosConvertidos.Add(Inicio());
            while (colaTokens.Count > 0 )
            {
                Token token = colaTokens.Dequeue();
                elemento.Add(token);
                if(token.Lexema.Equals(";") || token.Lexema.Equals("{"))
                {
                    dict = IdentificarValoresElemento(elemento);
                    elementosConvertidos.Add(ConvertirElemento(dict));
                    elemento.Clear();
                    dict.Clear();
                }
                else if (token.Lexema.Equals("}"))
                {

                }
            }
            elementosConvertidos.Add(Fin());

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
                if (t.Valor == (int)TokenType.OPERADOR_RELACIONAL) tipos.Add("logico");
                if (t.Lexema == "if") tipos.Add("if");
                if (t.Lexema == "{") tipos.Add("inicio_bloque");
                if (t.Lexema == "}") tipos.Add("fin_bloque");
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
                || token.Valor == (int) TokenType.CHAR
             
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
                case "declaracion":
                    conversion = Declarar(dict["valor-1"]);
                    break;
                case "declaracion_=":
                    conversion = Declarar(dict["valor-1"], dict["valor-2"]);
                    break;
                case "=":
                    conversion = Asignar(dict["valor-1"], dict["valor-2"]);
                    break;
                case "=_+":
                    conversion = Sumar(dict["valor-1"], dict["valor-2"], dict["valor-3"]);
                    break;
                case "=_*":
                    conversion = Multiplicar(dict["valor-1"], dict["valor-2"], dict["valor-3"]);
                    break;
                case "=_-":
                    conversion = Restar(dict["valor-1"], dict["valor-2"], dict["valor-3"]);
                    break;
                case "=_/":
                    conversion = Dividir(dict["valor-1"], dict["valor-2"], dict["valor-3"]);
                    break;
                case "+":
                    conversion = Sumar(dict["valor-1"], dict["valor-2"]);
                    break;
                case "*":
                    conversion = Multiplicar(dict["valor-1"], dict["valor-2"]);
                    break;
                case "-":
                    conversion = Restar(dict["valor-1"], dict["valor-2"]);
                    break;
                case "/":
                    conversion = Dividir(dict["valor-1"], dict["valor-2"]);
                    break;
                case "logico":
                    conversion = Logico(dict["valor-1"], dict["valor-2"]);
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
            string cadena = ".CODE\r\n\r\n";
            return cadena;
        }
        public static string Fin()
        {
            string cadena = "\r\nEND";
            return cadena;
        }
        public static string Sumar(string a, string b)
        {
            string cadena = "";
            cadena += "MOV AX," + a + "\r\n";
            cadena += "ADD AX," + b + "\r\n";
            cadena += "MOV [100], AX\r\n";
            return cadena;
        }
        public static string Sumar(string a, string b, string c)
        {
            string cadena = "";
            cadena += "MOV AX," + b + "\r\n";
            cadena += "ADD AX," + c + "\r\n";
            cadena += "MOV " + a + ", AX\r\n";
            return cadena;
        }
        public static string Restar(string a, string b)
        {
            string cadena = "";
            cadena += "MOV AX," + a + "\r\n";
            cadena += "SUB AX," + b + "\r\n";
            cadena += "MOV [100], AX\r\n";
            return cadena;
        }
        public static string Restar(string a, string b, string c)
        {
            string cadena = "";
            cadena += "MOV AX," + b + "\r\n";
            cadena += "SUB AX," + c + "\r\n";
            cadena += "MOV " + a + ", AX\r\n";
            return cadena;
        }
        public static string Dividir(string a, string b)
        {
            string cadena = "";
            cadena += "MOV AX," + a + "\r\n";
            cadena += "DIV AX," + b + "\r\n";
            cadena += "MOV [100], AX\r\n";
            return cadena;
        }
        public static string Dividir(string a, string b, string c)
        {
            string cadena = "";
            cadena += "MOV AX," + b + "\r\n";
            cadena += "DIV AX," + c + "\r\n";
            cadena += "MOV " + a + ", AX\r\n";
            return cadena;
        }
        public static string Multiplicar(string a, string b)
        {
            string cadena = "";
            cadena += "MOV AX," + a + "\r\n";
            cadena += "MUL AX," + b + "\r\n";
            cadena += "MOV [100], AX\r\n";
            return cadena;
        }
        public static string Multiplicar(string a, string b, string c)
        {
            string cadena = "";
            cadena += "MOV AX," + b + "\r\n";
            cadena += "MUL AX," + c + "\r\n";
            cadena += "MOV " + a + ", AX\r\n";
            return cadena;
        }

        public static string Declarar(string a)
        {
            string cadena = "";
            cadena += a + " db 8\r\n";
            return cadena;
        }

        public static string Declarar(string a, string b)
        {
            string cadena = "";
            cadena += a + " db 8\r\n";
            cadena += Asignar(a, b);
            return cadena;
        }
        public static string Asignar(string a, string b)
        {
            string cadena = "";
            cadena += "MOV AX, " + b + "\r\n";
            cadena += "MOV " + a + ",AX\r\n";
            return cadena;
        }
        public static string Logico(string a, string b)
        {
            string cadena = "MOV AX,"+ a +"\r\n";
            cadena += "CMP AX," + b + "\r\n";
            return cadena;
        }
        #endregion

        #endregion

    }
}
