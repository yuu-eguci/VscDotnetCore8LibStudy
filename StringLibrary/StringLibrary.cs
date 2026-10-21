namespace UtilityLibraries;

public static class StringLibrary
{
    public static bool StartsWithUpper(this string? str)
    {
        // 現在の文字列のインスタンスが大文字で始まるかどうかを示す Boolean 値を返します。

        if (string.IsNullOrWhiteSpace(str))
            return false;

        // char.IsUpper(string, int) はサロゲートペアも 1 文字として判定する。
        return char.IsUpper(str, 0);
    }
}
