namespace MSILGenerator.MSILLanguage.Constructions.Utils
{
    public class Variable
    {
        public string Name { private set; get; }
        public VariableType Type { private set; get; }
        public object Value { private set; get; }

        public Variable( string name, VariableType type, object value = null )
        {
            Name = name;
            Type = type;
            Value = value;
        }       

    }
}
