using System.Linq.Expressions;

namespace UniversityDataWarehouse.Services.Expressions
{
    public class ReplaceExpressionVisitor : ExpressionVisitor
    {
        public ReplaceExpressionVisitor(Expression oldValue, Expression newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
        
        private Expression OldValue { get; }
        private Expression NewValue { get; }

        public override Expression Visit(Expression node)
        {
            return node == OldValue ? NewValue : base.Visit(node);
        }
    }
}