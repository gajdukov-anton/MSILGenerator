using MSILGenerator.MSILLanguage.Constructions.Utils;
using MSILGenerator.Resources;
using MSILGenerator.Utils;

namespace MSILGenerator.MSILLanguage.Constructions.Operators
{
    public class AddingOperator : IMSILConstruction
    {
        private int _firstValue;
        private int _secondValue;
        private bool _isNumberOperation = false;
        private Variable _resultVariable;
        private Variable _firstVariable;
        private Variable _secondVariable;
        private string _firstVariableName;
        private string _secondVariableName;
        private string _resultVariableName;

        public AddingOperator( Variable firstVariable, Variable secondVariable, Variable resultVariable )
        {
            _firstVariable = firstVariable;
            _secondVariable = secondVariable;
            _resultVariable = resultVariable;
        }

        public AddingOperator( string firstVariableName, string secondVariableName, string resultVariableName )
        {
            _firstVariableName = firstVariableName;
            _secondVariableName = secondVariableName;
            _resultVariableName = resultVariableName;
        }

        public AddingOperator( int firsValue, int secondValue, Variable resultVariable )
        {
            _firstValue = firsValue;
            _secondValue = secondValue;
            _resultVariable = resultVariable;
            _isNumberOperation = true;
        }

        public AddingOperator( int firsValue, int secondValue, string resultVariableName )
        {
            _firstValue = firsValue;
            _secondValue = secondValue;
            _resultVariableName = resultVariableName;
            _isNumberOperation = true;
        }

        public string ToMSILCode()
        {
            var commandCode = ResourceManager.GetAddOperationResource();
            /*commandCode = commandCode.Replace( Constants.RESOURCE_FIRST_PARAMETER, GetParameterStrValue( _firstValue, _firstVariableName, _firstVariable ) );
            commandCode = commandCode.Replace( Constants.RESOURCE_SECOND_PARAMETER, GetParameterStrValue( _secondValue, _secondVariableName, _secondVariable ) );*/
            commandCode = GetMethodOfPushToStack( GetParameterStrValue( _firstValue, _firstVariableName, _firstVariable ) ) + commandCode;
            commandCode = GetMethodOfPushToStack( GetParameterStrValue( _secondValue, _secondVariableName, _secondVariable ) ) + commandCode;

            return commandCode.Replace( Constants.RESOURCE_RESULT, GetVariableName( _resultVariableName, _resultVariable ) );
        }

        private string GetParameterStrValue( int numberParameter, string variableName, Variable variableParameter )
        {
            return _isNumberOperation ? numberParameter.ToString() : GetVariableName( variableName, variableParameter );
        }

        private string GetVariableName( string variableName, Variable variable )
        {
            return string.IsNullOrEmpty( variableName ) ? variable.Name : variableName;
        }

        private string GetMethodOfPushToStack( string value )
        {
            return _isNumberOperation
                ? ResourceManager.GetPushToStackIntegerResource().Replace( Constants.RESOURCE_VALUE_PARAMETER, value )
                : ResourceManager.GetPushToStackVariableValue().Replace( Constants.RESOURCE_VALUE_PARAMETER, value );
        }
    }
}
