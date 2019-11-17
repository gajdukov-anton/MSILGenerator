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

                System.Diagnostics.Process.Start( @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Visual Studio 2017\Visual Studio Tools\Командная строка разработчика для VS 2017" );
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
