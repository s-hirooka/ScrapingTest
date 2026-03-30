# GK-Search

Google の検索結果から関連キーワードを収集する Windows Forms アプリです。  
現在の実装では、WebView2 をスマホ相当の設定で動かし、スマホ版 Google 検索結果から関連キーワードを取得します。

## 構成

- `ScrapingTest/ScrapingTest.sln`
  - ソリューションファイル
- `ScrapingTest/ScrapingTest/`
  - WinForms アプリ本体
- `ScrapingTest/仕様書_GK-Search.md`
  - 実装ベースで作成した仕様書

## 主な機能

- Google 関連キーワードの収集
- 収集したキーワードの昇順・降順表示
- 関連キーワードからの単体キーワード抽出
- トライアル版 / 製品版の簡易ライセンス制御
- Yahoo!知恵袋向けの Q&A リサーチ画面
  - 画面実装あり
  - 現状は補助機能・開発途中扱い

## 開発環境

- C#
- .NET Framework 4.7.2
- Windows Forms
- WebView2

## 実行前提

- Windows
- WebView2 Runtime が利用可能であること
- インターネット接続があること

## 使い方

1. アプリを起動します。
2. キーワードを入力します。
3. 階層を選択します。
4. `検索` を押します。
5. 左側に関連キーワード、右側に単体キーワードが表示されます。

## 補足

- Google 検索結果の DOM 構造に依存しています。
- Google 側の仕様変更により、取得件数が変動したり取得できなくなる可能性があります。
- リポジトリには NuGet パッケージも含めています。

