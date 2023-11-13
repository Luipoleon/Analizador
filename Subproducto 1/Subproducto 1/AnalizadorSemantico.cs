using analizador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Subproducto_1
{
    internal class AnalizadorSemantico
    {
        private List<Simbolo> tablaSimbolos;
        private Stack<string> pilaErrores = new Stack<string>();

        public AnalizadorSemantico()
        {
            tablaSimbolos = new List<Simbolo>();
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

        #region VerificarAsignacion
        public bool VerificarAsignacion(string id, int linea)
        {
            if (!EstaDefinido(id))
            {
                AgregarError(linea, "El símbolo \"" + id + "\" no está definido");
                return false;
            }
            return true;
           
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
        private void AgregarError(int linea, string error)
        {
            pilaErrores.Push(linea.ToString());
            pilaErrores.Push(error);
        }

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

        #endregion

    }
}
