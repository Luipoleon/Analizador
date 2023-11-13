using analizador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subproducto_1
{
    internal static class AnalizadorSintactico
    {
        #region Analizador Sintactico
        public static Stack<string>[] Sintactico(List<Token> lexico)
        {
            Stack<string> pila = new Stack<string>();
            AnalizadorSemantico analizadorSemantico = new AnalizadorSemantico();
            Stack<string>[] errores = new Stack<string>[2];
            errores[0] = pila;
            errores[1] = analizadorSemantico.PilaErrores;

            int linea = 1;
            for (int i = 0; i < lexico.Count; i++)
            {

                #region Entero
                if (lexico[i].Lexema == "int")
                {
                    i++;
                    if (lexico[i].Valor == 17)
                    {
                        string id = lexico[i].Lexema;
                        i++;
                        if (lexico[i].Lexema == "=")
                        {
                            i++;
                            if (lexico[i].Valor == 18 | lexico[i].Valor == 17)
                            {
                                int tipoValorAsignado = lexico[i].Valor;
                                string valorAsignado = lexico[i].Lexema;
                                i++;
                                if (lexico[i].Valor == 21)
                                {

                                    if(tipoValorAsignado == (int)TokenType.IDENTIFICADOR)
                                    {
                                        if (analizadorSemantico.VerificarAsignacion(valorAsignado, linea)){
                                            analizadorSemantico.AgregarSimbolo(id,"INT",valorAsignado,linea);
                                        }
                                    }
                                    else
                                    {
                                        analizadorSemantico.AgregarSimbolo(id, "INT", valorAsignado, linea);
                                    }
                                    linea++;
                                }
                                else
                                {
                                    pila.Push(linea.ToString());
                                    pila.Push("Se esperaba el lexema: $\n En su lugar se obtuvo: " + lexico[i].Lexema);
                                    return errores;
                                }
                            }
                            else
                            {
                                pila.Push(linea.ToString());
                                pila.Push("Se esperaba un número entero\n En su lugar se obtuvo: " + lexico[i].Lexema);
                                return errores;
                            }
                        }
                        else
                        {
                            pila.Push(linea.ToString());
                            pila.Push("Se esperaba el lexema: $\n En su lugar se obtuvo: " + lexico[i].Lexema);
                            return errores;
                        }
                    }
                    else
                    {
                        pila.Push(linea.ToString());
                        pila.Push("Se esperaba un identificador\n En su lugar se obtuvo: " + lexico[i].Lexema);
                        return errores;
                    }
                }
                #endregion
                #region Flotantes
                else if (lexico[i].Lexema == "float")
                {
                    i++;
                    if (lexico[i].Valor == 17)
                    {
                        i++;
                        if (lexico[i].Lexema == "=")
                        {
                            i++;
                            if (lexico[i].Valor == 19 | lexico[i].Valor == 17)
                            {
                                i++;
                                if (lexico[i].Valor == 21)
                                {
                                    linea++;
                                }
                                else
                                {
                                    pila.Push(linea.ToString());
                                    pila.Push("Se esperaba el lexema: {\n En su lugar se obtuvo: " + lexico[i].Lexema);
                                    return errores;
                                }
                            }
                            else
                            {
                                pila.Push(linea.ToString());
                                pila.Push("Se esperaba un decimal\n En su lugar se obtuvo: " + lexico[i].Lexema);
                                return errores;
                            }
                        }
                        else
                        {
                            pila.Push(linea.ToString());
                            pila.Push("Se esperaba el lexema: =\n En su lugar se obtuvo: " + lexico[i].Lexema);
                            return errores;
                        }
                    }
                    else
                    {
                        pila.Push(linea.ToString());
                        pila.Push("Se esperaba un identificador\n En su lugar se obtuvo: " + lexico[i].Lexema);
                        return errores;
                    }
                    #endregion
                    #region If
                }
                else if (lexico[i].Valor == 1)
                {
                    i++;
                    if (lexico[i].Valor == 9)
                    {
                        i++;
                        if (lexico[i].Valor == 17 | lexico[i].Valor == 18 | lexico[i].Valor == 19)
                        {
                            i++;
                            if (lexico[i].Valor == 6 | lexico[i].Valor == 8)
                            {
                                i++;
                                if (lexico[i].Valor == 17 | lexico[i].Valor == 18 | lexico[i].Valor == 19)
                                {
                                    i++;
                                    if (lexico[i].Valor == 10)
                                    {
                                        i++;
                                        if (lexico[i].Valor == 13)
                                        {
                                            pila.Push(lexico[i].Lexema);
                                        }
                                        else
                                        {
                                            pila.Push(linea.ToString());
                                            pila.Push("Se esperaba el lexema: {\n En su lugar se obtuvo: " + lexico[i].Lexema);
                                            return errores;
                                        }
                                    }
                                    else
                                    {
                                        pila.Push(linea.ToString());
                                        pila.Push("Se esperaba el lexema: )\n En su lugar se obtuvo: " + lexico[i].Lexema);
                                        return errores;
                                    }
                                }
                                else
                                {
                                    pila.Push(linea.ToString());
                                    pila.Push("Se esperaba un identificador, entero o decimal\n En su lugar se obtuvo: " + lexico[i].Lexema);
                                    return errores;
                                }
                            }
                            else
                            {
                                pila.Push(linea.ToString());
                                pila.Push("Se esperaba un operador logico o relacional\n En su lugar se obtuvo: " + lexico[i].Lexema);
                                return errores;
                            }
                        }
                        else
                        {
                            pila.Push(linea.ToString());
                            pila.Push("Se esperaba un tipo de dato\n En su lugar se obtuvo: " + lexico[i].Lexema);
                            return errores;
                        }
                    }
                    else
                    {
                        pila.Push(linea.ToString());
                        pila.Push("Se esperaba el lexema: (\n En su lugar se obtuvo: " + lexico[i].Lexema);
                        return errores;
                    }
                }
                #endregion
                #region Cierre de llave
                else if (lexico[i].Valor == 14)
                {
                    pila.Pop();
                }
                #endregion
                #region Logicos, Aritmeticos, Asignacion, relacionales
                else if (lexico[i].Valor == 17 | lexico[i].Valor == 18 | lexico[i].Valor == 19)
                {
                    i++;
                    if (lexico[i].Valor == 5 | lexico[i].Valor == 6 | lexico[i].Valor == 7 | lexico[i].Valor == 8)
                    {
                        i++;
                        if (lexico[i].Valor == 17 | lexico[i].Valor == 18 | lexico[i].Valor == 19)
                        {
                            i++;
                            if (lexico[i].Valor == 21)
                            {
                                i++;
                                linea++;
                            }
                            else
                            {
                                pila.Push(linea.ToString());
                                pila.Push("Se esperaba el lexema: $\n En su lugar se obtuvo: " + lexico[i].Lexema);
                                return errores;
                            }
                        }
                        else
                        {
                            pila.Push(linea.ToString());
                            pila.Push("Se esperaba un numero entero, decimal o un identificador\n En su lugar se obtuvo: " + lexico[i].Lexema);
                            return errores;
                        }
                    }
                    else
                    {
                        pila.Push(linea.ToString());
                        pila.Push("Se esperaba un operador logico, aritmetico, de asignacion o relacional\n En su lugar se obtuvo: " + lexico[i].Lexema);
                        return errores;
                    }
                }
                #endregion

            }

          
            return errores;
            #endregion

        }
    }
}
