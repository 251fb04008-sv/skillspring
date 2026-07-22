using NUnit.Framework;
[Test] public void Throws(){Assert.Throws<System.DivideByZeroException>(()=>{var x=1/int.Parse("0");});}