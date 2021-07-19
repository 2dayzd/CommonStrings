using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonSubstrings.Test.UnitTestSuite
{
    [TestClass]
    public class HasCommonSubstringTests
    {
        private SubstringChecks sc;

        [TestInitialize]
        public void TestSetup()
        {
            sc = new SubstringChecks();
        }
        
        [TestMethod]
        public void FirstAndSecondWithCommonSubstringsReturnsTrue()
        {
            Assert.IsTrue(sc.HasCommonSubstring("ABBAAB", "BBSAA"));
        }
        
        [TestMethod]
        public void FirstAndSecondNoCommonSubstringsReturnsFalse()
        {
            Assert.IsFalse(sc.HasCommonSubstring("ZZZXZZ", "BBSAA"));
        }
        
        [TestMethod]
        public void NullFirstArgReturnsFalse()
        {
            Assert.IsFalse(sc.HasCommonSubstring(null, "NotNull"));
        }
        
        [TestMethod]
        public void NullFirstSecondArgReturnsFalse()
        {
            Assert.IsFalse(sc.HasCommonSubstring("NotNull", null));
        }

        [TestMethod]
        public void EmptyFirstArgReturnsFalse()
        {
            Assert.IsFalse(sc.HasCommonSubstring("", "not3.{ty"));
        }

        [TestMethod]
        public void EmptySecondArgReturnsFalse()
        {
            Assert.IsFalse(sc.HasCommonSubstring("....sdf", ""));
        }
        
        [TestMethod]
        public void FirstArgMixedCaseReturnsTrue()
        {
            Assert.IsFalse(sc.HasCommonSubstring("Abner", "abner"));
        }
        
        [TestMethod]
        public void SecondArgMixedCaseReturnsTrue()
        {
            Assert.IsFalse(sc.HasCommonSubstring("abner", "AbnEr"));
        }
        
        [TestMethod]
        public void TrailingSpacesFirstArgMixedCaseReturnsTrue()
        {
            Assert.IsFalse(sc.HasCommonSubstring("trailing ", "trailing"));
        }
        
        [TestMethod]
        public void TrailingSpacesSecondArgMixedCaseReturnsTrue()
        {
            Assert.IsFalse(sc.HasCommonSubstring("trailing", "trailing "));
        }
    }
}