using exemplosCSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace exemplosCSharp
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        // usa static para que o método possa ser chamado sem instanciar a classe
        public static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
