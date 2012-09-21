using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpInterpreter.Library.Language
{
    public interface IExpression
    {
        object Evaluate(BindingEnvironment environment);
    }
}
