using System.Collections.Generic;
using System.Net.Http;

namespace SimplexGUI.Classes
{
    //Classe com as variáveis globais
    public static class Globals
    {
        public static List<SimplexEquation> SimplexProblem = new List<SimplexEquation>();
        public static List<SimplexVariables> SimplexVars = new List<Classes.SimplexVariables>();
        public static readonly HttpClient WebClient = new HttpClient();
    }
}
