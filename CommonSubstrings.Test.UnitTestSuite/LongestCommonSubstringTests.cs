using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonSubstrings.Test.UnitTestSuite
{
    [TestClass]
    public class LongestCommonSubstringTests
    {
        private SubstringChecks sc;

        [TestInitialize]
        public void TestSetup()
        {
            sc = new SubstringChecks();
        }
        
        [TestMethod]
        public void FirstAndSecondArgNoCommonSubstringsReturns0()
        {
            Assert.AreEqual(sc.LongestCommonSubstring("XXCXXXZ", "ABBABAB"), 0);
        }
        
        [TestMethod]
        public void FirstAndSecondArgSingleCommonSubstringReturns1()
        {
            Assert.AreEqual(sc.LongestCommonSubstring("XXCXAXXZ", "ABBABAB"), 1);
        }
        
        [TestMethod]
        public void FirstAndSecondManyMatchingSubstringReturns4()
        {
            Assert.AreEqual(sc.LongestCommonSubstring("AACBBBTDJJEEEEL", "EEEEBBTLLALE"), 4);
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