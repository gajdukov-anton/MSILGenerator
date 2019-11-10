using MSILGenerator.Resources;
using MSILGenerator.Utils;

namespace MSILGenerator.MSILLanguage.Constructions.Functions
{
    public class WriteLineFunction : IMSILConstruction
    {
        private string _value;
        
        public WriteLineFunction(string value)
        {
            _value = value;
        }

        public string ToMSILCode()
        {
            var commandCode = ResourceManager.GetWriteLineFunctionResource();
            return commandCode.Replace( Constants.RESOURCE_PARAMETER, _value );
        }

    }
}
