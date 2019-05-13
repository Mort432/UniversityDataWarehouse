using System.Linq.Expressions;

namespace UniversityDataWarehouse.Services.Expressions
{
    //Urgh, I hate this class.
    //It's literally just a wrapper for ExpressionVisitor that overrides Visit.
    //The override just checks if the node has changed and visits it if it hasn't.
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