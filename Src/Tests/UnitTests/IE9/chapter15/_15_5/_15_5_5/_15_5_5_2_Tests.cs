// <auto-generated />
namespace IronJS.Tests.UnitTests.IE9.chapter15._15_5._15_5_5
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _15_5_5_2_Tests : IE9TestFixture
    {
        public _15_5_5_2_Tests() : base(@"chapter15\15.5\15.5.5\15.5.5.2") { }

        [Test(Description = "String object supports bracket notation to lookup of data properties")] public void _15_5_5_5_2__1__1() { RunFile(@"15.5.5.5.2-1-1.js"); }
        [Test(Description = "String value supports bracket notation to lookup data properties")] public void _15_5_5_5_2__1__2() { RunFile(@"15.5.5.5.2-1-2.js"); }
        [Test(Description = "String object indexing returns undefined for missing data properties")] public void _15_5_5_5_2__3__1() { RunFile(@"15.5.5.5.2-3-1.js"); }
        [Test(Description = "String value indexing returns undefined for missing data properties")] public void _15_5_5_5_2__3__2() { RunFile(@"15.5.5.5.2-3-2.js"); }
        [Test(Description = "String object indexing returns undefined if the numeric index (NaN) is not an array index")] public void _15_5_5_5_2__3__3() { RunFile(@"15.5.5.5.2-3-3.js"); }
        [Test(Description = "String object indexing returns undefined if the numeric index (Infinity) is not an array index")] public void _15_5_5_5_2__3__4() { RunFile(@"15.5.5.5.2-3-4.js"); }
        [Test(Description = "String object indexing returns undefined if the numeric index ( 2^32-1) is not an array index")] public void _15_5_5_5_2__3__5() { RunFile(@"15.5.5.5.2-3-5.js"); }
        [Test(Description = "String value indexing returns undefined if the numeric index (NaN) is not an array index")] public void _15_5_5_5_2__3__6() { RunFile(@"15.5.5.5.2-3-6.js"); }
        [Test(Description = "String value indexing returns undefined if the numeric index (Infinity) is not an array index")] public void _15_5_5_5_2__3__7() { RunFile(@"15.5.5.5.2-3-7.js"); }
        [Test(Description = "String value indexing returns undefined if the numeric index ( >= 2^32-1) is not an array index")] public void _15_5_5_5_2__3__8() { RunFile(@"15.5.5.5.2-3-8.js"); }
        [Test(Description = "String object indexing returns undefined if the numeric index is less than 0")] public void _15_5_5_5_2__7__1() { RunFile(@"15.5.5.5.2-7-1.js"); }
        [Test(Description = "String value indexing returns undefined if the numeric index is less than 0")] public void _15_5_5_5_2__7__2() { RunFile(@"15.5.5.5.2-7-2.js"); }
        [Test(Description = "String object indexing returns undefined if the numeric index is greater than the string length")] public void _15_5_5_5_2__7__3() { RunFile(@"15.5.5.5.2-7-3.js"); }
        [Test(Description = "String value indexing returns undefined if the numeric index is greater than the string length")] public void _15_5_5_5_2__7__4() { RunFile(@"15.5.5.5.2-7-4.js"); }
    }
}