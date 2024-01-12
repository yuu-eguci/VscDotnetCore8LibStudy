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



# これ↓は VscDotnetCore8Study をコピーしたものだから気にしないで。




# 🎉 new console でプロジェクト作成
dotnet new console --framework net8.0 --use-program-main

# 実行できる!
dotnet run

# ✨ Console.ReadLine を使うと入力を受け付けることができる

# ✨ VSCode でもブレークポイントを使ってデバッグできる (integratedTerminal が必要っぽい)
# ✨ デバッグ中に変数の値を変更する方法を記載

# ✨ リリース バージョンをビルドしてテストする (TODO: でも Release 用の設定はどう書くんだ?)
dotnet run --configuration Release

# 🚀 アプリを発行する
# 既定のビルド構成は "デバッグ" であるため、このコマンドでは "リリース" ビルド構成を指定する
dotnet publish --configuration Release

# 📝 アプリを実行する
# 実行方法は、以下の2通り
# 1. 実行可能ファイルを使用する、
(cd bin/Release/net8.0/publish; ./VscDotnetCore8Study)
# 2. コマンド プロンプトから dotnet VscDotnetCore8Study.dll コマンドを実行
(cd bin/Release/net8.0/publish; dotnet VscDotnetCore8Study.dll)

```
