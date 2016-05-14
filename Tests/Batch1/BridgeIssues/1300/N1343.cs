using Bridge.Test;

namespace Bridge.ClientTest.BridgeIssues
{
    [Category(Constants.MODULE_ISSUES)]
    [TestFixture(TestNameFormat = "#1343 - {0}")]
    public class Bridge1343
    {
        [Test]
        public static void TestDoubleTemplate()
        {
            var s1 = string.Format("{0} {1}", 1, 2);
            var s2 = string.Format("{0} {1}", 1, 2).GetHashCode();

            Assert.AreEqual(s1.GetHashCode(), s2);
        }
    }
}
