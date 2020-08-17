﻿using Lecture_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestTools;
using TestTools.Structure;
using TestTools.Structure.Generic;

namespace Lecture_2_Tests
{
    [TestClass]
    public class Exercise_3_Tests
    {
#pragma warning disable IDE1006 // Naming Styles
        private ClassElement<ImmutableNumber> immutableNumber => new ClassElement<ImmutableNumber>();
        private PropertyElement<ImmutableNumber, int> immutableNumberValue => immutableNumber.Property<int>("Value", new AccessorOptions() { AccessLevel = AccessLevel.Public });
        private FuncMethodElement<ImmutableNumber, ImmutableNumber, ImmutableNumber> immutableNumberAdd => immutableNumber.FuncMethod<ImmutableNumber, ImmutableNumber>("Add");
        private FuncMethodElement<ImmutableNumber, ImmutableNumber, ImmutableNumber> immutableNumberSubtract => immutableNumber.FuncMethod<ImmutableNumber, ImmutableNumber>("Subtract");
        private FuncMethodElement<ImmutableNumber, ImmutableNumber, ImmutableNumber> immutableNumberMultiply => immutableNumber.FuncMethod<ImmutableNumber, ImmutableNumber>("Multiply");
        private ImmutableNumber CreateImmutableNumber(int value) => immutableNumber.Constructor<int>().Invoke(value);

        private void DoNothing(object par) { }
        private void TestImmutableNumberOperation(Func<ImmutableNumber, ImmutableNumber, ImmutableNumber> operation, int op1, int op2, int expectedResult, string symbol = "?")
        {
            ImmutableNumber n1 = CreateImmutableNumber(op1);
            ImmutableNumber n2 = CreateImmutableNumber(op2);

            int actualResult = immutableNumberValue.Get(operation(n1, n2));

            if (actualResult != expectedResult)
                Assert.Fail($"Produces unexpected result, {op1} {symbol} {op2} = {actualResult}");
        }
#pragma warning restore IDE1006 // Naming Styles

        public Exercise_3_Tests()
        {
            bool ImmutableNumberEquals(object obj1, object obj2) => immutableNumberValue.Get(obj1).Equals(immutableNumberValue.Get(obj2));
            string ImmutableNumberToString(object obj) => $"immutable number {immutableNumberValue.Get(obj)}";

            ObjectMethodRegistry.RegisterEquals(immutableNumber.Type, ImmutableNumberEquals);
            ObjectMethodRegistry.RegisterToString(immutableNumber.Type, ImmutableNumberToString);
        }

        /* Exercise 3A */
        [TestMethod("a. ImmutableNumber.Value is public readonly int property"), TestCategory("Exercise 3A")]
        public void ValueIsPublicReadonlyProperty() => DoNothing(immutableNumberValue);

        /* Exercise 3B */
        [TestMethod("a. ImmutableNumber.Number constructor takes int as argument"), TestCategory("Exercise 3B")]
        public void ImmutableNumberConstructorTakesIntAsArgument() => DoNothing(CreateImmutableNumber(0));

        [TestMethod("b. ImmutableNumber constructor with int as argument sets value property"), TestCategory("Exercise 3B")]
        public void ImmutableNumberConstructorWithIntAsArgumentSetsValueProperty()
        {
            ImmutableNumber n = CreateImmutableNumber(2);

            if (immutableNumberValue.Get(n) != 2)
                Assert.Fail("ImmutableNumber constructor ImmutableNumber(int par) does not set value");
        }

        /* Exercise 2C*/
        [TestMethod("a. ImmutableNumber.Add takes ImmutableNumber as argument and returns ImmutableNumber"), TestCategory("Exercise 3C")]
        public void AddTakesImmutableAsArgumentAndReturnsNothing() => DoNothing(immutableNumberAdd);

        [TestMethod("b. ImmutableNumber.Add performs 1 + 2 = 3"), TestCategory("Exercise 3C")]
        public void AddProducesExpectedResult() => TestImmutableNumberOperation((n1, n2) => immutableNumberAdd.Invoke(n1, n2), 1, 2, 3, symbol: "+");

        [TestMethod("c. ImmutableNumber.Subtract takes ImmutableNumber as argument and returns ImmutableNumber"), TestCategory("Exercise 3C")]
        public void SubtractTakesImmutableAsArgumentAndReturnsNothing() => DoNothing(immutableNumberSubtract);

        [TestMethod("d. ImmutableNumber.Subtract performs 8 - 3 = 5"), TestCategory("Exercise 3C")]
        public void SubstractProducesExpectedResult() => TestImmutableNumberOperation((n1, n2) => immutableNumberSubtract.Invoke(n1, n2), 8, 3, 5, symbol: "-");

        [TestMethod("e. ImmutableNumber.Multiply takes ImmutableNumber as argument and returns ImmutableNumber"), TestCategory("Exercise 3C")]
        public void MultiplyTakesImmutableAsArgumentAndReturnsNothing() => DoNothing(immutableNumberMultiply);

        [TestMethod("f. ImmutableNumber.Multiply performs 2 * 3 = 6"), TestCategory("Exercise 3C")]
        public void MultiplyProducesExpectedResult() => TestImmutableNumberOperation((n1, n2) => immutableNumberMultiply.Invoke(n1, n2), 2, 3, 6, symbol: "*");
    }
}
