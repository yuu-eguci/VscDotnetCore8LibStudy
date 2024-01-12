namespace StringLibraryTest;

// TestClassAttribute 属性が UnitTest1 クラスに適用
[TestClass]
public class UnitTest1
{
    // TestMethodAttribute 属性を適用して TestMethod1 を定義
    // テスト クラスの [TestMethod] でタグ付けされた各テスト メソッドが、単体テスト実行時に自動実行
    [TestMethod]
    public void TestMethod1()
    {
    }
}