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
        public static Stack<string> Sintactico(List<Token> lexico)
        {
            Stack<string> pila = new Stack<string>();
            int linea = 1;
            for (int i = 0; i < lexico.Count - 1; i++)
            {
                #region Entero
                if (lexico[i].Lexema == "int")
                {
                    i++;
                    if (lexico[i].Valor == 17 && (lexico[i].Lexema != "int" | lexico[i].Lexema != "float" | lexico[i].Lexema != "string"))
                    {
                        i++;
                        if (lexico[i].Lexema == "=")
                        {
                            i++;
                            if (lexico[i].Valor == 18)
                            {
                                i++;
                                if (lexico[i].Valor == 21)
                                {
                                    i++;
                                    linea++;
                                }
                            }
                            else
                            {
                                pila.Push(linea.ToString());
                                pila.Push(lexico[i].Lexema);
                                return pila;
                            }
                        }
                        else
                        {
                            pila.Push(linea.ToString());
                            pila.Push(lexico[i].Lexema);
                            return pila;
                        }
                    }

                }
                #endregion
                #region Flotantes
                else if (lexico[i].Lexema == "float")
                {
                    i++;
                    if (lexico[i].Valor == 17 && (lexico[i].Lexema != "int" | lexico[i].Lexema != "float" | lexico[i].Lexema != "string"))
                    {
                        i++;
                        if (lexico[i].Lexema == "=")
                        {
                            i++;
                            if (lexico[i].Valor == 19)
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
                                    pila.Push(lexico[i].Lexema);
                                    return pila;
                                }
                            }
                            else
                            {
                                pila.Push(linea.ToString());
                                pila.Push(lexico[i].Lexema);
                                return pila;
                            }
                        }
                        else
                        {
                            pila.Push(linea.ToString());
                            pila.Push(lexico[i].Lexema);
                            return pila;
                        }
                    }
                    else
                    {
                        pila.Push(linea.ToString());
                        pila.Push(lexico[i].Lexema);
                        return pila;
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
                        if ((lexico[i].Valor == 17 | lexico[i].Valor == 18 | lexico[i].Valor == 19) && (lexico[i].Lexema != "int" | lexico[i].Lexema != "float" | lexico[i].Lexema != "string"))
                        {
                            i++;
                            if (lexico[i].Valor == 6 | lexico[i].Valor == 8)
                            {
                                i++;
                                if ((lexico[i].Valor == 17 | lexico[i].Valor == 18 | lexico[i].Valor == 19) && (lexico[i].Lexema != "int" | lexico[i].Lexema != "float" | lexico[i].Lexema != "string"))
                                {
                                    i++;
                                    if (lexico[i].Valor == 10)
                                    {
                                        i++;
                                        if (lexico[i].Valor == 13)
                                        {
                                            pila.Push(lexico[i].Lexema);
                                        }
                                    }
                                    else
                                    {
                                        pila.Push(linea.ToString());
                                        pila.Push(lexico[i].Lexema);
                                        return pila;
                                    }
                                }
                                else
                                {
                                    pila.Push(linea.ToString());
                                    pila.Push(lexico[i].Lexema);
                                    return pila;
                                }
                            }
                            else
                            {   
                                pila.Push(linea.ToString());
                                pila.Push(lexico[i].Lexema);
                                return pila;
                            }
                        }
                        else
                        {   
                            pila.Push(linea.ToString());
                            pila.Push(lexico[i].Lexema);
                            return pila;
                        }
                    }
                    else
                    {   
                        pila.Push(linea.ToString());
                        pila.Push(lexico[i].Lexema);
                        return pila;
                    }
                }
                #endregion
                #region Cierre de llave
                else if (lexico[i].Valor == 14)
                {
                    pila.Pop();
                }
                #endregion
            }
            return pila;
            #endregion

        }
    }
}
