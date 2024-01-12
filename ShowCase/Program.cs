using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        // row 変数を使って、コンソール ウィンドウに書き込まれるデータの行数のカウントを維持します。
        // これが 25 以上になると、コードによってコンソール ウィンドウがクリアされ、
        // ユーザーにメッセージが表示されます。
        int row = 0;

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            // プログラムは、ユーザーに文字列の入力を要求し、 文字列が大文字で始まるかどうかを示します。
            // ユーザーが文字列を入力せずに Enter キーを押すと、アプリケーションが終了し、コンソール ウィンドウが閉じます。
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Input: {input}");
            Console.WriteLine("Begins with uppercase? " +
                 $"{(input.StartsWithUpper() ? "Yes" : "No")}");
            Console.WriteLine();
            row += 4;
        } while (true);
        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, enter a string and press <Enter>:{Environment.NewLine}");
            row = 3;
        }
    }
}
