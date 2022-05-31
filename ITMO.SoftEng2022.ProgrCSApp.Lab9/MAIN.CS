
namespace CSharp
{
    using System;

    public class Application
    {
        public static void Main(string[] args)
        {
            try
            {
                InnerMain(args);
            }
            catch (System.Exception caught)
            {
                Console.WriteLine(caught);
            }
        }

        public static void InnerMain(string[] args)
        {
            SourceFile source = new SourceFile(args[0]);

            // Add code here...
            HTMLTokenVisitor visitor = new HTMLTokenVisitor(); //9.1.3
            source.Accept(visitor);  //9.1.3 - !!!
        }
    }
}

