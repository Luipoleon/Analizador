using analizador;

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
                    if (lexico[i].Valor == (int)TokenType.IDENTIFICADOR)
                    {
                        #region Variable semántico id 
                        string id = lexico[i].Lexema;
                        #endregion
                        i++;
                        if (lexico[i].Lexema == ";")
                        {
                            #region Agregar a tabla de símbolos
                            analizadorSemantico.AgregarSimbolo(id, "int", null, linea);
                            #endregion
                            linea++;
                        }
                        else if (lexico[i].Lexema == "=")
                        {
                            i++;
                            if (lexico[i].Valor == (int)TokenType.ENTERO ||
                                lexico[i].Valor == (int)TokenType.IDENTIFICADOR)
                            {
                                #region Variables semántico valor asignado y tipo ID o INT
                                int tipoValorAsignado = lexico[i].Valor;
                                string valorAsignado = lexico[i].Lexema;
                                #endregion
                                i++;
                                if (lexico[i].Valor == 21)
                                {
                                    #region Verificación semántica
                                    if (tipoValorAsignado == (int)TokenType.IDENTIFICADOR)
                                    {
                                        string[] tiposValidos = { "int" };
                                        if (analizadorSemantico.VerificarID(valorAsignado, linea, tiposValidos)){
                                            analizadorSemantico.AgregarSimbolo(id,"int",valorAsignado,linea);
                                        }
                                    }
                                    else
                                    {
                                        analizadorSemantico.AgregarSimbolo(id, "int", valorAsignado, linea);
                                    }
                                    #endregion
                                    linea++;
                                }
                                else
                                {
                                    pila.Push(linea.ToString());
                                    pila.Push("Se esperaba el lexema: ;\n En su lugar se obtuvo: " + lexico[i].Lexema);
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
                            pila.Push("Se esperaba el lexema: ;\n En su lugar se obtuvo: " + lexico[i].Lexema);
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
                    if (lexico[i].Valor == (int)TokenType.IDENTIFICADOR)
                    {
                        #region Variable semántico id 
                        string id = lexico[i].Lexema;
                        #endregion
                        i++;
                        if (lexico[i].Lexema == ";")
                        {
                            #region Agregar a tabla de símbolos
                            analizadorSemantico.AgregarSimbolo(id, "float", null, linea);
                            #endregion
                            linea++;
                        }
                        else if (lexico[i].Lexema == "=")
                        {
                            i++;
                            if (lexico[i].Valor == (int)TokenType.DECIMAL ||
                                lexico[i].Valor ==  (int)TokenType.IDENTIFICADOR)
                            {
                                #region Variables semántico valor asignado y tipo ID o FLOAT
                                int tipoValorAsignado = lexico[i].Valor;
                                string valorAsignado = lexico[i].Lexema;
                                #endregion
                                i++;
                                if (lexico[i].Valor == (int)TokenType.FIN_DE_CADENA)
                                {
                                    #region Verificación semántica
                                    if (tipoValorAsignado == (int)TokenType.IDENTIFICADOR)
                                    {
                                        string[] tiposValidos = { "float" };
                                        if (analizadorSemantico.VerificarID(valorAsignado, linea, tiposValidos))
                                        {
                                            analizadorSemantico.AgregarSimbolo(id, "float", valorAsignado, linea);
                                        }
                                    }
                                    else
                                    {
                                        analizadorSemantico.AgregarSimbolo(id, "float", valorAsignado, linea);
                                    }
                                    #endregion
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
                            #region Variable lexico 1 Semántico
                            Token lexico1 = lexico[i];
                            #endregion
                            i++;
                            if (lexico[i].Valor == 6 | lexico[i].Valor == 8)
                            {
                                i++;
                                if (lexico[i].Valor == 17 | lexico[i].Valor == 18 | lexico[i].Valor == 19)
                                {
                                    #region Variable lexico 2 Semántico
                                    Token lexico2 = lexico[i];
                                    #endregion
                                    #region Comparar tipos de Valores Semántico
                                    analizadorSemantico.VerificarTiposIguales(lexico1, lexico2, linea);
                                    #endregion

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

                    if(pila.Count > 0)
                    {
                        pila.Pop();
                    }
                    else
                    {
                        pila.Push(linea.ToString());
                        pila.Push("Epresión inválida: " + lexico[i].Lexema );
                        return errores;
                    }
                  
                }
                #endregion
                #region Logicos, Aritmeticos, Asignacion, relacionales
                else if (lexico[i].Valor == (int)TokenType.IDENTIFICADOR)
                {
                    #region Variable  ID Semántico
                    Token lexicoID  = lexico[i];
                    #endregion
                    i++;
                    if (lexico[i].Valor == (int)TokenType.OPERADOR_ASIGNACION)
                    {
                        i++;
                        #region Variable léxico 1 Semántico
                        Token lexico1 = lexico[i];
                        #endregion
                        if (
                           lexico[i].Valor == (int)TokenType.ENTERO ||
                           lexico[i].Valor == (int)TokenType.IDENTIFICADOR ||
                           lexico[i].Valor == (int)TokenType.DECIMAL
                           )
                        {
                            i++;
                            if (lexico[i].Valor == (int)TokenType.FIN_DE_CADENA)
                            {
                                #region Verificar tipos de datos iguales
                                if (analizadorSemantico.VerificarTiposIguales(lexicoID, lexico1, linea) )
                                {
                                    analizadorSemantico.ActualizarValorSimbolo(lexicoID, lexico1);
                                }
                                #endregion
                                linea++;
                            }
                            else if (lexico[i].Valor == (int)TokenType.OPERADOR_ARITMETICO)
                            {
                                #region Variable Operador Semántico
                                string operador = lexico[i].Lexema;
                                #endregion
                                i++;
                                if (
                                     lexico[i].Valor == (int)TokenType.ENTERO ||
                                     lexico[i].Valor == (int)TokenType.IDENTIFICADOR ||
                                     lexico[i].Valor == (int)TokenType.DECIMAL
                                   )
                                {
                                    #region Variable léxico 2 Semántico
                                    Token lexico2 = lexico[i];
                                    #endregion
                                    i++;
                                    if (lexico[i].Valor == (int)TokenType.FIN_DE_CADENA)
                                    {
                                        #region Verificar tipos de datos iguales e id

                                        if (analizadorSemantico.VerificarTiposIguales(lexicoID, lexico1, linea) &&
                                            analizadorSemantico.VerificarTiposIguales(lexicoID, lexico2, linea)
                                           )
                                        {
                                            if(!analizadorSemantico.ValorDeSimboloEsNulo(lexico1.Lexema, linea) &&
                                               !analizadorSemantico.ValorDeSimboloEsNulo(lexico2.Lexema, linea)
                                              )
                                            analizadorSemantico.ActualizarValorSimbolo(lexicoID, lexico1, operador, lexico2);
                                        }
                                        #endregion
                                        linea++;
                                    }
                                    else
                                    {
                                        pila.Push(linea.ToString());
                                        pila.Push("Se esperaba el lexema: ;\n En su lugar se obtuvo: " + lexico[i].Lexema);
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
                                pila.Push("Se esperaba un operador " + lexico[i].Lexema);
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
                        pila.Push("Se esperaba un operador  de asignación. \n En su lugar se obtuvo: " + lexico[i].Lexema);
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
