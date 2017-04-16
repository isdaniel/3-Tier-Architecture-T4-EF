using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using IBLL;
using Model;

namespace UnitTest
{
    // Assumptions:
    public class Bar : IFoo
    {
        public bool DoSomething(string msg)
        {
            return msg == "Hello";
        }

        public string DoSomethingStringy(string msg)
        {
            return msg + "World";
        }

        public int GetCount()
        {
            return 1;
        }

        public int GetCountThing()
        {
            return 10;
        }

        public bool Submit(ref Bar bar)
        {
            return true;
        }

    }

    public interface IFoo
    {
        bool DoSomething(string msg);
        string DoSomethingStringy(string msg);
        bool Submit(ref Bar bar);
        int GetCount();
        int GetCountThing();
    }
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var mock = new Mock<IFoo>();
            //mock.Setup(foo => foo.DoSomething("Hello")).Returns(true);


            // ref arguments
           // var instance = new Bar();
            // Only matches if the ref argument to the invocation is the same instance
           //mock.Setup(foo => foo.Submit(ref instance)).Returns(true);


            // access invocation arguments when returning a value
            //mock.Setup(x => x.DoSomethingStringy(It.IsAny<string>()))
            //        .Returns((string s) => s.ToLower());
            // Multiple parameters overloads available


            // throwing when invoked with specific parameters
            //mock.Setup(foo => foo.DoSomething("reset")).Throws<InvalidOperationException>();
            //mock.Setup(foo => foo.DoSomething("")).Throws(new ArgumentException("command"));


            // lazy evaluating return value
            //mock.Setup(foo => foo.GetCount()).Returns(() => count);


            // returning different values on each invocation
            var mock = new Mock<IFoo>();
            var calls = 0;
            mock.Setup(foo => foo.GetCountThing())
                .Returns(() => calls)
                .Callback(() => calls++);
            // returns 0 on first invocation, 1 on the next, and so on
            Console.WriteLine(mock.Object.GetCountThing());
        }
    }
}
