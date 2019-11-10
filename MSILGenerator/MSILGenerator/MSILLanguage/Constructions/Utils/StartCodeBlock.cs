using System;

namespace MSILGenerator.MSILLanguage.Constructions.Utils
{
    public class StartCodeBlock : IMSILConstruction
    {
        public string ToMSILCode()
        {
            return "{";
        }
    }
}
