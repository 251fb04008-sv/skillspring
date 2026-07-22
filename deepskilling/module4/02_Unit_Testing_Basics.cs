using NUnit.Framework;
[TestFixture]
public class CalculatorTests{
 [Test]
 public void Add_ReturnsSum(){
   Assert.That(2+3, Is.EqualTo(5));
 }
}