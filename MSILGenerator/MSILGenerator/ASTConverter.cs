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
            msilConstructions.Add( new MainFunction() );
            msilConstructions.Add( new StartCodeBlock() );
            msilConstructions.Add( new WriteLineFunction( "Test program" ) );
            msilConstructions.Add( new EndCodeBlock() );
            return msilConstructions;
        }
    }
}
