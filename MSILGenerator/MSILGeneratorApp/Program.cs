using MSILGenerator;
using System;

namespace MSILGeneratorApp
{
    class Program
    {
        static void Main( string [] args )
        {
            try
            {
                ASTConverter converter = new ASTConverter();
                var construction = converter.GetTestProgram();
                Generator generator = new Generator();
                generator.Generate( construction );
                Console.WriteLine( "Программа сгенерирована" );
            }
            catch ( Exception e )
            {
                Console.WriteLine( e.Message );
            }
            Console.ReadKey();
        }
    }
}
