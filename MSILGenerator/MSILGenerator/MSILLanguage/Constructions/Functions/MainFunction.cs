
using MSILGenerator.Resources;

namespace MSILGenerator.MSILLanguage.Constructions.Functions
{
    public class MainFunction : IMSILConstruction
    {
        public string ToMSILCode()
        {
            return ResourceManager.GetMainFunctionResource();
        }
    }
}
