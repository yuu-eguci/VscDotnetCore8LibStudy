VSCode Dotnet Core 8 Library Study!
===

VscDotnetCore8Study の続きで、 .NET クラス ライブラリを作成するチュートリアルを見つけたのでやってみようぜ。

```bash
# バージョン
dotnet --version
# --> 8.0.101

# 🙈 .gitignore 作ってくれるの嬉しすぎ
dotnet new gitignore

# 🎉 new sln でソリューションファイル作成
dotnet new sln

# 🎉 新しい .NET クラス ライブラリ プロジェクトをソリューションに追加
dotnet new classlib -o StringLibrary

# 🎉 ライブラリ プロジェクトをソリューションに追加
dotnet sln add StringLibrary/StringLibrary.csproj

# ✨ Class1.cs に クラス ライブラリ UtilityLibraries.StringLibrary を実装

# 🚀 ソリューションをビルドし、エラーなしでプロジェクトがコンパイルされることを確認
dotnet build

# 🎉 new console でクラスライブラリを利用するプロジェクト作成
# チュートリアルには --use-program-main がないけど、追加している。
# だって、このあとのステップで、どうせクラスベースに変更してるんだもん。
# -o: ディレクトリ名のこと
dotnet new console -o ShowCase --use-program-main

# 🎉 コンソール アプリ プロジェクトをソリューションに追加
dotnet sln add ShowCase/ShowCase.csproj

# ✨ ShowCase/Program.cs Main を実装

# 🎉 新しいコンソール アプリ プロジェクトにクラス ライブラリへのアクセス権を付与
dotnet add ShowCase/ShowCase.csproj reference StringLibrary/StringLibrary.csproj

# ✨ アプリを実行する
dotnet run --project ShowCase/ShowCase.csproj

# ✅ 「StringLibraryTest」という名前の単体テスト プロジェクトを作成
dotnet new mstest -o StringLibraryTest

# 🎉 テスト プロジェクトをソリューションに追加
dotnet sln add StringLibraryTest/StringLibraryTest.csproj

# 🎉 StringLibraryTest プロジェクトに StringLibrary プロジェクトへの参照 (アクセス権) を追加
dotnet add StringLibraryTest/StringLibraryTest.csproj reference StringLibrary/StringLibrary.csproj

# ✅ StringLibraryTest/UnitTest1.cs を実装

```
