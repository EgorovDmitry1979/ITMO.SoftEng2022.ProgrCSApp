
namespace CSharp
{
    //public class NullTokenVisitor : ITokenVisitor //9.1.2
        public abstract class NullTokenVisitor : ITokenVisitor //9.1.2
    {
        public virtual void Visit(ILineStartToken t) { } //9.1.2

        public virtual void Visit(ILineEndToken t) { } //9.1.2

        public virtual void Visit(ICommentToken t) { } //9.1.2
        public virtual void Visit(IDirectiveToken t) { } //9.1.2
        public virtual void Visit(IIdentifierToken t) { } //9.1.2
        public virtual void Visit(IKeywordToken t) { } //9.1.2
        public virtual void Visit(IWhiteSpaceToken t) { } //9.1.2

        public virtual void Visit(IOtherToken t) { } //9.1.2 

        //static void Test() //9.1.2 (добавлен - проверен - удален)
        //{
        //    new NullTokenVisitor(); //9.1.2 (добавлен - проверен - удален)
        //}

    }
}
