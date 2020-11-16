using MoneyExample;
using System;
using Xunit;

namespace MoneyExampleTests
{
    /// <summary>
    /// TODO
    /// 
    /// 1. $5 + 10 CHF = $10 if rate is 2:1
    /// 2. $5 * 2 = $10 => ***DONE***
    /// 3. Make "amount" private => ***DONE***
    /// 4. Dollar side-effects? => ***DONE***
    /// 5. Money rounding?
    /// 6. equals() => ***DONE***
    /// 7. hashCode()
    /// 8. Equal null
    /// 9. Equal object
    /// 
    /// </summary>
    public class MoneyTests
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Assert.Equal(new Dollar(10), five.Times(2));
            Assert.Equal(new Dollar(15), five.Times(3));
        }

        [Fact]
        public void TestEquality_Returns_False()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}


