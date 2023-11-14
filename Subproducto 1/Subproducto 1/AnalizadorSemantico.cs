using analizador;

namespace Subproducto_1
{
    internal class AnalizadorSemantico
    {
        private List<Simbolo> tablaSimbolos;
        private Stack<string> pilaErrores;

        public AnalizadorSemantico()
        {
            tablaSimbolos = new List<Simbolo>();
            pilaErrores = new Stack<string>();
        }
        #region Métodos publicos

        #region AgregarSimbolo
        public bool AgregarSimbolo(string id, string tipo, string valor, int linea)
        {
            #region Verificar si el símbolo existe y retornar
            if (EstaDefinido(id))
            {
                AgregarError(linea, "El símbolo \"" + id + "\" ya esta definido");
                return false;
            }
            #endregion

            #region Agregar símbolo a la tabla
            Simbolo simbolo = new Simbolo(id, tipo, valor);
            tablaSimbolos.Add(simbolo);
            #endregion

            return true;
        }
        #endregion

        #region ValorDeSimboloEsNulo
        public bool ValorDeSimboloEsNulo(string id, int linea)
        {
            string valor = GetSimbolo(id)?.Valor ?? null; 
            if (valor == null)
            {
                AgregarError(linea, "El valor de " + id + " es nulo");
                return true;
            }
            return true;
        }
        #endregion

        #region VerificarID
        public bool VerificarID(string id, int linea, string[] tiposValidos)
        {

            if (!EstaDefinido(id))
            {
                AgregarError(linea, "El símbolo \"" + id + "\" no está definido");
                return false;
            }
            foreach(string t in tiposValidos)
            {
                if (EsTipo(id, t))
                {
                    return true;
                }

            }
            AgregarError(linea, "El símbolo \"" + id + "\" no es de tipo [" + string.Join(", ", tiposValidos) +"]");
            return false;
           
        }
        #endregion

        #region ActualizarValorSimboloSuma
        public void ActualizarValorSimbolo(Token lexicoID,  Token lexico1,string operador, Token lexico2)
        {
            Simbolo s = GetSimbolo(lexicoID.Lexema);
            s.Valor = RealizarOperacion(int.Parse(GetValor(lexico1)), 
                     int.Parse(GetValor(lexico2)), operador).ToString();
          
        }
        #endregion

        #region ActualizarValorSimbolo
        public void ActualizarValorSimbolo(Token lexico1, Token lexico2)
        {
            Simbolo s = GetSimbolo(lexico1.Lexema);
            s.Valor = GetValor(lexico2);

        }
        #endregion

        #region VerificarTiposIguales
        public bool VerificarTiposIguales(Token lexico1, Token lexico2, int linea)
        {
            string[] tiposValidos = { "float", "int" };
            if(lexico1.Valor == (int)TokenType.IDENTIFICADOR)
            {
                if(!VerificarID(lexico1.Lexema, linea, tiposValidos)) return false;
            }
            if (lexico2.Valor == (int)TokenType.IDENTIFICADOR)
            {
                if (!VerificarID(lexico2.Lexema, linea, tiposValidos)) return false;
            }

            string tipo1 = GetTipo(lexico1);
            string tipo2 = GetTipo(lexico2);

            if (tipo1 == tipo2) return true;
            
            AgregarError(linea, "Tipo de dato inválido " + tipo1 + " diferente a " + tipo2);
            return false;
        }
        #endregion

        #endregion

        #region Setters y getters
        public Stack<string> PilaErrores
        {
            get { return pilaErrores; }
        }
        #endregion

        #region Métodos privados

        #region AgregarError
        private void AgregarError(int linea, string error)
        {
            pilaErrores.Push(linea.ToString());
            pilaErrores.Push(error);
        }
        #endregion

        #region GetSimbolo
        private Simbolo GetSimbolo(string id)
        {
            foreach(Simbolo s in tablaSimbolos)
            {
                if(s.ID == id)
                {
                    return s;
                }
            }
            return null;
        }
        #endregion

        #region EstaDefinido
        private bool EstaDefinido(string id)
        {

            foreach (Simbolo s in tablaSimbolos)
            {
                if (s.ID.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region VerificarTipo
        private bool EsTipo(string id, string tipo)
        {
            Simbolo simbolo = GetSimbolo(id);
            if (simbolo.Tipo == tipo)
            {
                return true;
            }
            return false;

        }
        #endregion

        #region RealizarOperacion;
        private int RealizarOperacion(int operand1, int operand2, string operadorAritmetico)
        {
            switch (operadorAritmetico)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    return operand1 / operand2;
                // Add more cases for other operators as needed
                default:
                    throw new ArgumentException("Invalid arithmetic operator");
            }
        }
    
        #endregion

        #region  GetTipo
        private string GetTipo(Token lexico)
            {
                string tipo;
                if (lexico.Valor == (int)TokenType.IDENTIFICADOR)
                {
                    tipo = GetSimbolo(lexico.Lexema).Tipo;
                }
                else if(lexico.Valor == (int)TokenType.ENTERO)
                {
                    tipo = "int";
                }
                else
                {
                    tipo = "float";
                }

                return tipo;
            }
        #endregion

        #region  GetValor
        private string GetValor(Token lexico)
        {
            string valor;
            if (lexico.Valor == (int)TokenType.IDENTIFICADOR)
            {
                valor = GetSimbolo(lexico.Lexema).Valor;
            }
            else
            {
                valor = lexico.Lexema;
            }

            return valor;
        }
        #endregion

        #endregion

    }
}
