using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpInterpreter.Library.Language
{
    public class ConstantExpression:IExpression
    {
        public object value;

        public ConstantExpression(object value)
        {
            this.value = value;
        }

        public object Evaluate(BindingEnvironment environment)
        {
            return this.value;
        }        
    }
}
