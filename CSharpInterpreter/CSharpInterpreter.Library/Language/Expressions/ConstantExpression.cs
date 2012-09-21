using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpInterpreter.Library.Language
{
    public class ConstantExpression:IExpression
    {     
        public object Evaluate(BindingEnvironment environment)
        {
            throw new NotImplementedException();
        }        
    }
}
