using MSILGenerator.MSILLanguage.Constructions.Utils;
using MSILGenerator.Resources;
using MSILGenerator.Utils;

namespace MSILGenerator.MSILLanguage.Constructions.Operators
{
    public class AddingOperator : IMSILConstruction
    {
        public Variable _resultVariable;

        private int _firstValue;
        private int _secondValue;
        private string _resultVariableName;

        public AddingOperator(int firsValue, int secondValue, Variable resultVariable)
        {
            _firstValue = firsValue;
            _secondValue = secondValue;
            _resultVariable = resultVariable;
        }

        public AddingOperator( int firsValue, int secondValue, string resultVariableName )
        {
            _firstValue = firsValue;
            _secondValue = secondValue;
            _resultVariableName = resultVariableName;
        }

        public string ToMSILCode()
        {
            var commandCode = ResourceManager.GetAddOperationResource();
            commandCode = commandCode.Replace( Constants.RESOURCE_FIRST_PARAMETER, _firstValue.ToString() );
            commandCode = commandCode.Replace( Constants.RESOURCE_SECOND_PARAMETER, _secondValue.ToString() );
            return commandCode.Replace( Constants.RESOURCE_RESULT, GetResultVariableName() );
        }

        private string GetResultVariableName()
        {
            return !string.IsNullOrEmpty( _resultVariableName ) ? _resultVariableName : _resultVariable.Name;
        }
    }
}
