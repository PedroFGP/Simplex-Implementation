using System.Collections.Generic;

namespace SimplexGUI.Classes
{
    //Classe que respresenta as equações
    public class SimplexEquation
    {
        public SimplexEquation()
        {
            Variables = new Dictionary<string, double>();
            Operator = null;
            LimitValue = null;
        }

        public int RowIndex { get; set; }
        public string Name { get; set; }
        public string Operator { get; set; }
        public double? LimitValue { get; set; }
        public Dictionary<string, double> Variables { get; set; }

        public string GetFullEquation()
        {
            string fullEquation = "";

            foreach(var item in Globals.SimplexVars)
            {
                if (Variables.ContainsKey(item.Name))
                {
                    fullEquation += Variables[item.Name].ToString() + ";" + item.Name + " ";
                }
            }

            if(Operator != null && LimitValue.HasValue)
            {
                fullEquation += Operator + " " + LimitValue.ToString();
            }

            return fullEquation;
        }

        public string GetFullEquationAlternative()
        {
            string fullEquation = "";

            foreach (var item in Globals.SimplexVars)
            {
                if (Variables.ContainsKey(item.Name))
                {
                    if(Name == "FO(Z)")
                    {
                        if (fullEquation == "")
                        {
                            fullEquation += Variables[item.Name].ToString().Replace(",", ".") + item.Name + " ";
                        }
                        else
                        {
                            fullEquation += ((Variables[item.Name] > 0) ? "+" : "-") + " " + Variables[item.Name].ToString().Replace(",", ".") + item.Name + " ";
                        }
                    }
                    else
                    {
                        if (fullEquation == "")
                        {
                            fullEquation += Variables[item.Name].ToString().Replace(",", ".") + " ";
                        }
                        else
                        {
                            fullEquation += ((Variables[item.Name] > 0) ? "+" : "-") + " " + Variables[item.Name].ToString().Replace(",", ".") + " ";
                        }
                    }
                }
            }

            if (Operator != null && LimitValue.HasValue)
            {
                fullEquation += Operator + " " + LimitValue.ToString();
            }

            return fullEquation.Trim();
        }
    }
}
