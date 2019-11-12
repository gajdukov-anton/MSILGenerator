using MSILGenerator.MSILLanguage.Constructions;
using MSILGenerator.MSILLanguage.Constructions.Functions;
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
            var mainBody = new List<IMSILConstruction>
            {
                new StackCapacityFunction( 10 ),
                new WriteLineFunction( "Ого" ),
                new WriteLineFunction( "это" ),
                new WriteLineFunction( "работает" )
            };
            msilConstructions.Add( new MainFunction( mainBody ) );
            return msilConstructions;
        }
    }
}
