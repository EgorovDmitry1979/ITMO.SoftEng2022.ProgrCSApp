
namespace CSharp
{ 
    using System;

    //public class HTMLTokenVisitor //9.1.3
    public sealed class HTMLTokenVisitor : ITokenVisitor //9.1.11 // 9.1.2 добавлено sealed
    //public class HTMLTokenVisitor : NullTokenVisitor //9.1.3 //9.1.11
    {
        //public void Visit(ILineStartToken line) //9.1.3 раньше
        //public override void Visit(ILineStartToken line) //9.1.3 позднее. //9.1.11
        public void Visit(ILineStartToken line) //9.1.11
        {
            //Console.Write(line.Number()); //9.1.3 //9.1.6 закрыто
            Console.Write("<span class=\"line_number\">"); //9.1.6
            Console.Write("{0,3}", line.Number()); //9.1.6
            Console.Write("</span>"); //9.1.6
        }

        //public override void Visit(ILineEndToken t) //9.1.3 //9.1.11
        public void Visit(ILineEndToken t) //9.1.11
        {
            Console.WriteLine(); //9.1.3
        }
        //public override void Visit(IIdentifierToken token) //9.1.4 //9.1.11
        public void Visit(IIdentifierToken token) //9.1.11
        {
            //Console.Write(token.ToString()); //9.1.4 //9.1.10
            SpannedFilteredWrite("identifier", token); //9.1.10
        }
        //public override void Visit(ICommentToken token) //9.1.4 //9.1.11
        public void Visit(ICommentToken token) //9.1.11
        {
            ////Console.Write(token.ToString()); // 9.1.7 //9.1.10
            ////FilteredWrite(token); // 9.1.7 // 9.1.8 //9.1.10
            //Console.Write("<span class=\"comment\">"); // 9.1.8 //9.1.10
            //FilteredWrite(token); // 9.1.8 //9.1.10
            //Console.Write("</span>"); // 9.1.8 //9.1.10

            SpannedFilteredWrite("comment", token); //9.1.10
        }

        //public override void Visit(IKeywordToken token) //9.1.4 //9.1.11
        public void Visit(IKeywordToken token) //9.1.11
        {
            ////Console.Write(token.ToString()); //9.1.9 //9.1.10
            //Console.Write("<span class=\"keyword\">"); //9.1.9 //9.1.10
            //FilteredWrite(token); //9.1.9 //9.1.10
            //Console.Write("</span>"); //9.1.9 //9.1.10

            SpannedFilteredWrite("keyword", token); //9.1.10
        }

        //public override void Visit(IWhiteSpaceToken token) //9.1.4 //9.1.11
        public void Visit(IWhiteSpaceToken token) //9.1.11
        {
            Console.Write(token.ToString());
        }

        //public override void Visit(IOtherToken token) //9.1.4 //9.1.11
        public void Visit(IOtherToken token) //9.1.11
        {
            //Console.Write(token.ToString()); // 9.1.7
            FilteredWrite(token); // 9.1.7
        }

        private void FilteredWrite(IToken token) //9.1.7
        {
            string src = token.ToString(); //9.1.7
            for (int i = 0; i != src.Length; i++) //9.1.7
            {
                string dst; //9.1.7
                switch (src[i]) //9.1.7
                {
                    case '<': //9.1.7
                        dst = "&lt;"; break; //9.1.7
                    case '>': //9.1.7
                        dst = "&gt;"; break; //9.1.7
                    case '&': //9.1.7
                        dst = "&amp;"; break; //9.1.7
                    default: //9.1.7
                        dst = new string(src[i], 1); break; //9.1.7
                }
                Console.Write(dst); //9.1.7
            }
        }

        private void SpannedFilteredWrite(string spanName, IToken token) //9.1.10
        {
            Console.Write("<span class=\"{0}\">", spanName); //9.1.10//9.1.10
            FilteredWrite(token); //9.1.10
            Console.Write("</span>"); //9.1.10
        }

        public void Visit(IDirectiveToken token) //9.1.11
        {
            SpannedFilteredWrite("directive", token); //9.1.11
        }
    }
}
