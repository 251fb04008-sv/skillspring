using NUnit.Framework;
[TestFixture] class P{[TestCase(2,3,5)] public void Add(int a,int b,int c){Assert.That(a+b,Is.EqualTo(c));}}