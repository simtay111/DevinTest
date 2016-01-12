using System;
using NUnit.Framework;

namespace DevinTest
{
    public class FieldsAndLocals
    {
        private int _fieldLevelVariable = 0;

        public void IncrementAndWriteLineLocalVariable()
        {
            var theLocalVariable = 1;
            theLocalVariable++;
            Console.WriteLine(theLocalVariable);

        }

        public void IncrementAndWriteLineFieldVariable()
        {
            _fieldLevelVariable++;
            Console.WriteLine(_fieldLevelVariable);
        }
    }

    [TestFixture]
    public class FieldsAndLocalsTests
    {
        private FieldsAndLocals _itemUnderTest;

        [SetUp]
        public void SetUp()
        {
            _itemUnderTest = new FieldsAndLocals();
        }

        [Test]
        public void LocalVariables()
        {
            _itemUnderTest.IncrementAndWriteLineLocalVariable();
            _itemUnderTest.IncrementAndWriteLineLocalVariable();
            _itemUnderTest.IncrementAndWriteLineLocalVariable();
            _itemUnderTest.IncrementAndWriteLineLocalVariable();
            _itemUnderTest.IncrementAndWriteLineLocalVariable();
        }

        [Test]
        public void FieldVariablesOneClass()
        {
            _itemUnderTest.IncrementAndWriteLineFieldVariable();
            _itemUnderTest.IncrementAndWriteLineFieldVariable();
            _itemUnderTest.IncrementAndWriteLineFieldVariable();

            var itemUnderTest2 = new FieldsAndLocals();

            itemUnderTest2.IncrementAndWriteLineFieldVariable();
            itemUnderTest2.IncrementAndWriteLineFieldVariable();
            itemUnderTest2.IncrementAndWriteLineFieldVariable();

            _itemUnderTest.IncrementAndWriteLineFieldVariable();
        }
    }
}