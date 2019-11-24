using MSILGenerator.MSILLanguage.Constructions;
using MSILGenerator.MSILLanguage.Constructions.Functions;
using MSILGenerator.MSILLanguage.Constructions.Operators;
using MSILGenerator.MSILLanguage.Constructions.Utils;
using System.Collections.Generic;

namespace MSILGenerator
{
    public class ASTConverter
    {
        public List<IMSILConstruction> GetTestProgram()
        {
            var msilConstructions = new List<IMSILConstruction>();
            msilConstructions.Add( new Initializator() );
            var firstVariable = new Variable( "firstValue", VariableType.Integer );
            var secondVariable = new Variable( "secondValue", VariableType.Integer );
            var resultVariable = new Variable( "resultValue", VariableType.Integer );
            var variableNames = new List<string>
            {
                firstVariable.Name,
                secondVariable.Name,
                resultVariable.Name,
                "result"
            };
            var mainBody = new List<IMSILConstruction>
            {
                new StackCapacityFunction( 10 ),
                new WriteLineFunction( "Ого" ),
                new WriteLineFunction( "это" ),
                new WriteLineFunction( "работает" ),
                new VariableDeclarationOperator( variableNames, VariableType.Integer ),
                new AssignmentOperator(VariableType.Integer, firstVariable, 100),
                new AssignmentOperator(VariableType.Integer, secondVariable, 200),
                new AddingOperator( 10, 15, "result" ),
                new AddingOperator( firstVariable, secondVariable, resultVariable ),
                new WriteLineFunction( new Variable( "result", VariableType.Integer ) ),
                new WriteLineFunction( resultVariable )
            };
            msilConstructions.Add( new MainFunction( mainBody ) );
            return msilConstructions;
        }
    }
}
