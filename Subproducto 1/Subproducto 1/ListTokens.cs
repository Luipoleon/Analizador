namespace analizador
{
    #region Enum Tokens
    public enum TokenType
    {
        ERROR = 0,

        // Palabras clave
        IF = 1,
        ELSE, //2
        WHILE, //3
        FOR, //4

        // Operadores
        OPERADOR_ARITMETICO,//5
        OPERADOR_LOGICO,//6
        OPERADOR_ASIGNACION,//7
        OPERADOR_RELACIONAL,//8

        // Símbolos
        PARENTESIS_IZQUIERDO,//9
        PARENTESIS_DERECHO,//10
        PUNTO_Y_COMA,//11
        COMA,//12
        LLAVE_IZQUIERDA,//13
        LLAVE_DERECHA,//14
        CORCHETE_IZQUIERDO,//15
        CORCHETE_DERECHO,//16


        // Identificadores y literales
        IDENTIFICADOR,//17
        ENTERO,//18
        DECIMAL,//19

        // Fin de archivo
        FIN_DE_ARCHIVO,//20,

        // Fin de cadena
        FIN_DE_CADENA,//21

        // Tipo de dato
        TIPO_DATO //22
    }

    #endregion

    #region Struct Token
    public struct Token
    {
        public string Nombre;
        public int Valor;
        public string Lexema;
    }

    #endregion

}