using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CSharpInterpreter.Library.Language;

namespace CSharpInterpreter.Test
{
    [TestFixture]
    public class ExpressionsTests
    {
        [Test]
        public void NotDefinedVariableSholdReturnNull()
        {
            BindingEnvironment environment = new BindingEnvironment();
            VariableExpression variable = new VariableExpression("foo");

            Assert.IsNull(variable.Evaluate(environment));
        }

        [Test]
        public void ConstantExpressionShouldReturnValue()
        {
            Assert.AreEqual("foo",(new ConstantExpression("foo")).Evaluate(null));
            Assert.AreEqual(1, (new ConstantExpression(1)).Evaluate(null));
            Assert.AreEqual(null, (new ConstantExpression(null)).Evaluate(null));
        }
    }
}
