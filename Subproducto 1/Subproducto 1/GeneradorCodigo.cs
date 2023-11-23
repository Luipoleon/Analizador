using analizador;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Subproducto_1
{
    internal static class GeneradorCodigo
    {
        public static string Inicio()
        {
            string cadena = ".CODE\n";
            return cadena;
        }
        public static string Fin() {
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
            cadena += "MOV "+a+", AX\n";
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
            cadena += "MOV "+a+", AX\n";
            return cadena;
        }
        public static string Asignar(string a, string b)
        {
            string cadena = "";
            cadena += a + " db 4\n";
            cadena += "MOV AX, "+b+"\n";
            cadena += "MOV " + a + ",AX\n";
            return cadena;
        }
        public static void GenerarCodigo(List<Token> tokens)
        {
            

        }
     
    }
}
