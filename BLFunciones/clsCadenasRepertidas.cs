using System;
using System.Linq;

namespace BLFunciones
{
   public  class clsCadenasRepertidas
    {
        #region Funciones
        public string build(string str)
        {
            string evalua = string.Empty;
            var withoutSpecial = new string(str.Where(c => Char.IsLetterOrDigit(c)
                                                        || Char.IsWhiteSpace(c)).ToArray());
            if (str != withoutSpecial)
            {
                evalua = "La cadena debe de contener solo letras y números";
                return evalua;
            }

            try
            {
                bool valcaracter;
                foreach (char c in str)
                {
                    if (!evalua.Contains(c.ToString()))
                    {
                        valcaracter = ValidaNumerico(c.ToString());
                        if (valcaracter == false)
                        {
                            int result = str.Length - str.Replace(c.ToString(), "").Length;
                            evalua = evalua + result.ToString() + c.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                evalua = ex.ToString();
            }
            return evalua;
        }
        public bool ValidaNumerico(string letra)
        {
            bool textIsNumeric = true;
            try
            {
                int.Parse(letra);
            }
            catch
            {
                textIsNumeric = false;
            }
            return textIsNumeric;
        }
        #endregion
    }
}
