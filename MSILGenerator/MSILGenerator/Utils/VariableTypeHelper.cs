﻿using MSILGenerator.MSILLanguage.Constructions.Utils;

namespace MSILGenerator.Utils
{
    public static class VariableTypeHelper
    {
        public static string GetMSILRepresentation(VariableType type)
        {
            switch (type)
            {
                case VariableType.Bool:
                    return "bool";
                case VariableType.String:
                    return "string";
                case VariableType.Integer:
                    return "int32";
                default:
                    return "";
            }
        }
    }
}
