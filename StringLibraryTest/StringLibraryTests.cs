using UtilityLibraries;

namespace StringLibraryTest;

[TestClass]
public class StringLibraryTests
{
    [TestMethod]
    [DataRow("Alphabet")]
    [DataRow("Zebra")]
    [DataRow("ABC")]
    [DataRow("Αθήνα")]
    [DataRow("Москва")]
    [DataRow("\u00C9cole")] // É (precomposed)
    [DataRow("E\u0301cole")] // E + combining acute
    [DataRow("\U0001D400bc")] // 𝐀 (surrogate pair)
    [DataRow("\U00010400")] // 𐐀 Deseret capital (surrogate pair)
    public void TestStartsWithUpper(string word)
    {
        Assert.IsTrue(word.StartsWithUpper());
    }

    [TestMethod]
    [DataRow("alphabet")]
    [DataRow("zebra")]
    [DataRow("abc")]
    [DataRow("αυτοκινητοβιομηχανία")]
    [DataRow("государство")]
    [DataRow("1234")]
    [DataRow(".")]
    [DataRow(";")]
    [DataRow(" ")]
    [DataRow(" Abc")] // leading whitespace
    [DataRow("\u01C5x")] // ǅ titlecase is not uppercase
    [DataRow("\U0001D41Abc")] // 𝐚 (surrogate pair, lowercase)
    [DataRow("\U00010428")] // 𐐨 Deseret small (surrogate pair)
    public void TestDoesNotStartWithUpper(string word)
    {
        Assert.IsFalse(word.StartsWithUpper());
    }

    [TestMethod]
    public void TestLoneHighSurrogate()
    {
        // Lone surrogates can't be passed via DataRow (attribute strings are stored as UTF-8).
        Assert.IsFalse("\uD835x".StartsWithUpper());
    }

    [TestMethod]
    [DataRow("")]
    [DataRow(null)]
    public void DirectCallWithNullOrEmpty(string? word)
    {
        Assert.IsFalse(StringLibrary.StartsWithUpper(word));
    }
}
