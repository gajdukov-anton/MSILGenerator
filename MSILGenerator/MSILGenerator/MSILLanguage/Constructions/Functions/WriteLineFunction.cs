﻿using MSILGenerator.MSILLanguage.Constructions.Utils;
using MSILGenerator.Resources;
using MSILGenerator.Utils;

namespace MSILGenerator.MSILLanguage.Constructions.Functions
{
    public class WriteLineFunction : IMSILConstruction
    {
        private string _value;
        private Variable _variable;

        public WriteLineFunction( string value )
        {
            _value = value;
        }

        public WriteLineFunction( Variable variable )
        {
            _variable = variable;
        }

        public string ToMSILCode()
        {
            var commandCode = ResourceManager.GetWriteLineFunctionResource();

            commandCode = !string.IsNullOrEmpty( _value )
                ? commandCode.Replace( Constants.RESOURCE_COMMAND, "ldstr" )
                : commandCode.Replace( Constants.RESOURCE_COMMAND, "ldloc" );

            commandCode = !string.IsNullOrEmpty( _value ) 
                ? commandCode.Replace( Constants.RESOURCE_TYPE, VariableTypeHelper.GetMSILRepresentation( VariableType.String ) )
                : commandCode.Replace( Constants.RESOURCE_TYPE, VariableTypeHelper.GetMSILRepresentation( _variable.Type ) );
            
            return !string.IsNullOrEmpty( _value )
                ? commandCode.Replace( Constants.RESOURCE_VALUE_PARAMETER, $"\"{_value}\"" )
                : commandCode.Replace( Constants.RESOURCE_VALUE_PARAMETER, _variable.Name );
        }
    }
}
