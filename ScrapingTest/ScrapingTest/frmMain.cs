using AngleSharp;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Diagnostics;
using Newtonsoft.Json;

using Microsoft.Web.WebView2.Core;




namespace ScrapingTest
{
    public partial class frmMain : Form
    {

        string[] astrData = new string[1];
        int intCount = 0;
        int mintStopFlag = 0;
        int mintTrail = 1; // 1:トライアル版  0:製品版
        string mstrPassword = "PxLQa7e"; //製品版のパスワード
        string mstrRegKeyName = "GKSearch\\PassWord";
        const string CstrMobileUserAgent = "Mozilla/5.0 (Linux; Android 14; Pixel 7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Mobile Safari/537.36";





        public frmMain()
        {
            InitializeComponent();
        }

        private void GetPassword()
        {

            lblMsg.Visible = true;
            btnBuy.Visible = true;

            Microsoft.Win32.RegistryKey rkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\" + mstrRegKeyName);
            if (rkey != null)
            {

                string stringValue = (string)rkey.GetValue("string", "default");

                if (stringValue== mstrPassword)
                {
                    //製品版
                    mintTrail = 0;
                    lblMsg.Visible = false;
                    btnBuy.Visible = false;

                }


                


            }



        }

        private async Task InitializeWebView2()
        {
            await webView2.EnsureCoreWebView2Async();


            if (webView2.CoreWebView2 != null)
            {
                webView2.CoreWebView2.Settings.UserAgent = CstrMobileUserAgent;
            }



            // JavaScriptを有効にする設定
            webView2.CoreWebView2.Settings.IsScriptEnabled = true;

            // その他の設定
            webView2.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = true;
            webView2.CoreWebView2.Settings.IsWebMessageEnabled = true;

            await ApplyMobileEmulationAsync();

        }

        private async Task ApplyMobileEmulationAsync()
        {
            if (webView2.CoreWebView2 == null)
            {
                return;
            }

            string deviceMetrics = JsonConvert.SerializeObject(new
            {
                width = 390,
                height = 844,
                deviceScaleFactor = 3,
                mobile = true,
                screenWidth = 390,
                screenHeight = 844,
                positionX = 0,
                positionY = 0,
                scale = 1
            });

            string touchOptions = JsonConvert.SerializeObject(new
            {
                enabled = true,
                maxTouchPoints = 5
            });

            await webView2.CoreWebView2.CallDevToolsProtocolMethodAsync("Emulation.setDeviceMetricsOverride", deviceMetrics);
            await webView2.CoreWebView2.CallDevToolsProtocolMethodAsync("Emulation.setTouchEmulationEnabled", touchOptions);
        }

        private string BuildGoogleSearchUrl(string keyword)
        {
            string searchTerm = Uri.EscapeDataString(keyword);
            return $"https://www.google.com/search?q={searchTerm}&hl=ja&gl=jp";
        }

        private string GetMobileRelatedKeywordsScript()
        {
            return @"
(() => {
  const currentQuery = new URL(location.href).searchParams.get('q') || '';
  const blacklist = new Set([
    'すべて', '画像', '動画', 'ニュース', 'ショッピング', '地図', '書籍',
    'フライト', 'ファイナンス', '検索ツール', 'もっと見る', 'ログイン',
    '設定', 'フィードバック', 'Google アプリ', 'Google'
  ]);

  const normalize = (text) => text.replace(/\s+/g, ' ').trim();
  const isValidKeyword = (text) => {
    if (!text) return false;
    if (text === currentQuery) return false;
    if (blacklist.has(text)) return false;
    if (text.length <= 1) return false;
    return true;
  };

  const keywords = [];
  const seen = new Set();
  const addKeyword = (text) => {
    const normalized = normalize(text);
    if (!isValidKeyword(normalized) || seen.has(normalized)) return;
    seen.add(normalized);
    keywords.push(normalized);
  };

  const containers = [
    'g-scrolling-carousel',
    '[role=""main""]',
    '#rso',
    'body'
  ];

  containers.forEach((selector) => {
    document.querySelectorAll(`${selector} a[href*=""\/search?""]`).forEach((anchor) => {
      const href = anchor.getAttribute('href') || '';
      let queryFromHref = '';

      try {
        const absoluteUrl = new URL(href, location.origin);
        queryFromHref = absoluteUrl.searchParams.get('q') || '';
      } catch (e) {
      }

      const text = normalize(anchor.innerText || anchor.textContent || '');
      const candidate = normalize(queryFromHref || text);

      if (anchor.closest('header, nav')) return;
      if (candidate.includes('http://') || candidate.includes('https://')) return;
      if (candidate.startsWith('cache:') || candidate.startsWith('site:')) return;

      addKeyword(candidate);
    });
  });

  return keywords;
})();";
        }




        private void SetPassWord()
        {



            string s1 = Interaction.InputBox("パスワードを入力してください。","");


            //キャンセルボタン時の処理
            if (s1== "")
            {
                return;
            }


            //パスワードが合ってるかチェック
            if (s1 != mstrPassword)
            {
                MessageBox.Show("パスワードが違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }



            Microsoft.Win32.RegistryKey regkey =
            Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\" + mstrRegKeyName);

            //レジストリに書き込み
            //文字列を書き込む（REG_SZで書き込まれる）
            regkey.SetValue("string", s1);

            //閉じる
            regkey.Close();



            //製品版へ変更する。
            mintTrail = 0;
            lblMsg.Visible = false;
            btnBuy.Visible = false;


        }



        private Process OpenUrl(string url)
        {
            ProcessStartInfo pi = new ProcessStartInfo()
            {
                FileName = url,
                UseShellExecute = true,
            };

            return Process.Start(pi);
        }



        private void KWSort(int pintSort)
        {
            try
            {

                int j = 0;
                String strData = "";


                if (intCount > 0)
                {
                    txtList.Clear();

                    if (pintSort == 0)
                    {
                        //昇順
                        Array.Sort(astrData);
                    }
                    else
                    {
                        //降順
                        Array.Reverse(astrData);
                    }


                    for (int i = 0; i <= intCount; i++)
                    {

                        if (astrData[i] != null)
                        {
                            if (j == 0)
                            {
                                //txtList.Text = astrData[i];
                                strData = astrData[i];

                            }
                            else
                            {
                                //txtList.Text = txtList.Text + Environment.NewLine + astrData[i];
                                strData = strData + Environment.NewLine + astrData[i];
                            }

                            j = j + 1;

                        }

                    }

                    txtList.Text = strData;

                }





                string[] astrKW = new string[1];
                int intKWCount = 0;
                int intChk = 0;



                txtKW.Text = "";

                if (intCount > 0)
                {

                    for (int iSer = 0; iSer < intCount; iSer++)
                    {


                        if (astrData[iSer] != null)
                        {

                            //キーワードを分解

                            var words = astrData[iSer].Split(new char[] { ' ', '　' }, StringSplitOptions.RemoveEmptyEntries);

                            foreach (var word in words)
                            {
                                //既に同じKWがあるかチェックする。
                                intChk = 0;

                                for (int i = 0; i < intKWCount; i++)
                                {
                                    if (astrKW[i] == word)
                                    {
                                        intChk = 1;
                                        break;
                                    }
                                }

                                if (intChk == 0)
                                {


                                    astrKW[intKWCount] = word;
                                    intKWCount = intKWCount + 1;
                                    Array.Resize(ref astrKW, intKWCount + 1);

                                }


                            }



                        }



                    }

                    //昇順
                    Array.Sort(astrKW);


                    for (int iSer = 0; iSer < intKWCount; iSer++)
                    {
                        if (astrKW[iSer] != null)
                        {
                            if (txtKW.Text.Length == 0)
                            {
                                txtKW.Text = astrKW[iSer];
                            }
                            else
                            {
                                txtKW.Text = txtKW.Text + Environment.NewLine + astrKW[iSer];
                            }

                        }
                    }



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"致命的なエラー: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void KWsplit(int pintSort)
        {

            try
            {

                string[] astrKW = new string[1];
                int intKWCount = 0;
                int intChk = 0;



                txtKW.Text = "";
                lblKWCount.Text = "";

                if (intCount > 0)
                {

                    for (int iSer = 0; iSer < intCount; iSer++)
                    {


                        if (astrData[iSer] != null)
                        {

                            //キーワードを分解

                            var words = astrData[iSer].Split(new char[] { ' ', '　' }, StringSplitOptions.RemoveEmptyEntries);

                            foreach (var word in words)
                            {
                                //既に同じKWがあるかチェックする。
                                intChk = 0;

                                for (int i = 0; i < intKWCount; i++)
                                {
                                    if (astrKW[i] == word)
                                    {
                                        intChk = 1;
                                        break;
                                    }
                                }

                                if (intChk == 0)
                                {


                                    astrKW[intKWCount] = word;
                                    intKWCount = intKWCount + 1;
                                    Array.Resize(ref astrKW, intKWCount + 1);

                                }


                            }



                        }



                    }

                    if (pintSort == 0)
                    {
                        //昇順
                        Array.Sort(astrKW);
                    }
                    else
                    {
                        //降順
                        Array.Reverse(astrKW);
                    }



                    for (int iSer = 0; iSer < intKWCount; iSer++)
                    {
                        if (astrKW[iSer] != null)
                        {
                            if (txtKW.Text.Length == 0)
                            {
                                txtKW.Text = astrKW[iSer];
                            }
                            else
                            {
                                txtKW.Text = txtKW.Text + Environment.NewLine + astrKW[iSer];
                            }

                        }
                    }

                    intKWCount = intKWCount-1;
                    lblKWCount.Text = "単体キーワード： " + intKWCount + "件";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"致命的なエラー: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*

        private void button4_Click(object sender, EventArgs e)
        {


            //トライアル版のチェック

            if (mintTrail == 1)
            {
                //検索は1回しかできない。
                if (intCount> 0)
                {

                    MessageBox.Show("トライアル版は、検索回数は1回のみと制限しております。制限を解除する場合は、購入をご検討ください。。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }



            }




            if (txtSerachKW.Text.Length == 0)
            {
                MessageBox.Show("キーワードを入力して下さい。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtSerachKW.Focus();

            }
            else { 


                var config = Configuration.Default.WithDefaultLoader().WithDefaultCookies();
                var context = BrowsingContext.New(config);


                
                await InitializeWebView2();




                if (chkKanrenKWClear.Checked == true)
                {
                    astrData = new string[1];
                    intCount = 0;
                }


                mintStopFlag = 0;

                int i;

                string[] astrSerach;
                string[] astrNextSerach;
                int intSerachCnt = 1;
                int intNextSerachCnt = 0;
                int intKaisou = 0;
                int intChk = 0;


                // Stopwatchクラス生成
                var sw = new System.Diagnostics.Stopwatch();

                // 計測開始
                sw.Start();


                astrSerach = new string[1];
                astrNextSerach = new string[1];


                astrSerach[0] = txtSerachKW.Text;

                intKaisou = Int32.Parse(cmdKaisou.Text);
                lblKensu.Text = "";
                lblTime.Text = "";



                txtList.Clear();

                lblKWCount.Text = "";
                txtKW.Clear();



                //この値を見て関連キーワードを探している。
                //const string CstrSelectClass = "div.BNeawe.s3v9rd.AP7Wnd.lRVwie";

                //const string CstrSelectClass = "span.Xe4YD > div.BNeawe.lRVwie";

                


                for ( int ikai = 0; ikai< intKaisou; ikai++)
                {

                    intNextSerachCnt = 0;
                    astrNextSerach = new string[1];

                    lblKensu.Text = (ikai+1) + "階層目を検索中" ;

                    string strKensu = "";

                    //中止処理
                    if (mintStopFlag == 1)
                    {
                        lblKensu.Text ="中止しました。";
                        lblKensu.Refresh();
                        return;
                    }


                    for (int iSer = 0; iSer < intSerachCnt; iSer++)
                    {


                        string url = "https://www.google.com/search?q=" + astrSerach[iSer];


                        //var document = await context.OpenAsync(url);



                        //webView2.CoreWebView2.Navigate(url);

                        webView2.EnsureCoreWebView2Async();

                        webView2.Source = new Uri(url);




                        webView2.NavigationCompleted += async (sender1, args) =>
                        {
                            if (args.IsSuccess)
                            {
                                string script = @"
                                    (function() {
                                        const keywords = [];
                                        const elements = document.querySelectorAll('div.b2Rnsc span.dg6jd > b');
                                        for (let i = 0; i < elements.length && i < 10; i++) {
                                            keywords.push(elements[i].innerText);
                                        }
                                        return keywords;
                                    })();
                                ";


                                string result = await webView2.ExecuteScriptAsync(script);


                                // JavaScriptの結果はJSON配列として返るため、C#の文字列として扱う
                                result = result.TrimStart('[').TrimEnd(']').Replace("\"", "");
                                var keywords = result.Split(',');



                                int iItemCnt = 1;


                                foreach (var item in keywords)
                                {


                                    //中止処理
                                    if (mintStopFlag == 1)
                                    {
                                        lblKensu.Text = "中止しました。";
                                        lblKensu.Refresh();
                                        return;
                                    }


                                    if (strKensu.Length > 8)
                                    {
                                        strKensu = "・";
                                    }
                                    else
                                    {
                                        strKensu += "・";

                                    }

                                    lblKensu.Text = (ikai + 1) + "階層目を検索中" + strKensu;
                                    lblKensu.Refresh();


                                    //既に同じKWがあるかチェックする。
                                    intChk = 0;

                                    //重複チェック True:重複あれば表示しない、false：重複チェックしない。

                                    if (chkJufukuChk.Checked == true)
                                    {
                                        for (i = 0; i < intCount; i++)
                                        {
                                            if (astrData[i] == item.Trim())
                                            {
                                                intChk = 1;
                                                break;
                                            }
                                        }
                                    }



                                    if (intChk == 0)
                                    {
                                        if (txtList.Text.Length == 0)
                                        {
                                            txtList.Text = item.Trim();
                                        }
                                        else
                                        {
                                            txtList.Text = txtList.Text + Environment.NewLine + item.Trim();
                                        }

                                        astrData[intCount] = item.Trim();
                                        intCount = intCount + 1;
                                        Array.Resize(ref astrData, intCount + 1);


                                        astrNextSerach[intNextSerachCnt] = item.Trim();
                                        intNextSerachCnt = intNextSerachCnt + 1;
                                        Array.Resize(ref astrNextSerach, intNextSerachCnt + 1);



                                    }

                                    iItemCnt = iItemCnt + 1;


                                }




                            }
                            else
                            {
                                //MessageBox.Show("ページの読み込みに失敗しました。");

                                MessageBox.Show("Google検索で制限がかかりました。OKボタンをクリック後、暫く時間を置いてから行ってください。。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                //System.Diagnostics.Process.Start(document.BaseUri);
                                return;
                            }
                        };



                        

                                                //Google検索で制限がかかっている場合の処理
                                                if (document.BaseUri.IndexOf( "/sorry/") > 0)
                                                {

                                                    MessageBox.Show("Google検索で制限がかかりました。OKボタンをクリック後、暫く時間を置いてから行ってください。。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                                    System.Diagnostics.Process.Start(document.BaseUri);

                                                    return;


                                                }
                       


                                                //中止処理
                                                if (mintStopFlag == 1)
                                                {
                                                    lblKensu.Text = "中止しました。";
                                                    lblKensu.Refresh();
                                                    return;
                                                }



                                                //var seltem = document.QuerySelectorAll(CstrSelectClass);


                                                int iItemCnt = 1;


                                                foreach (var item in keywords)
                                                {


                                                    //中止処理
                                                    if (mintStopFlag == 1)
                                                    {
                                                        lblKensu.Text = "中止しました。";
                                                        lblKensu.Refresh();
                                                        return;
                                                    }


                                                    if (strKensu.Length > 8)
                                                    {
                                                        strKensu = "・";
                                                    }
                                                    else
                                                    {
                                                        strKensu += "・";

                                                    }

                                                    lblKensu.Text = (ikai + 1) + "階層目を検索中" + strKensu;
                                                    lblKensu.Refresh();


                                                    //既に同じKWがあるかチェックする。
                                                    intChk = 0;

                                                    //重複チェック True:重複あれば表示しない、false：重複チェックしない。

                                                    if (chkJufukuChk.Checked == true) { 
                                                        for (i = 0; i < intCount; i++)
                                                        {
                                                            if (astrData[i] == item.InnerHtml.Trim())
                                                            {
                                                                intChk = 1;
                                                                break;
                                                            }
                                                        }
                                                    }



                                                    if (intChk == 0)
                                                    {
                                                        if (txtList.Text.Length == 0)
                                                        {
                                                            txtList.Text = item.InnerHtml.Trim();
                                                        }
                                                        else
                                                        {
                                                            txtList.Text = txtList.Text + Environment.NewLine + item.InnerHtml.Trim();
                                                        }

                                                        astrData[intCount] = item.InnerHtml.Trim();
                                                        intCount = intCount + 1;
                                                        Array.Resize(ref astrData, intCount+1);


                                                        astrNextSerach[intNextSerachCnt] = item.InnerHtml.Trim();
                                                        intNextSerachCnt = intNextSerachCnt + 1;
                                                        Array.Resize(ref astrNextSerach, intNextSerachCnt + 1);



                                                    }

                                                    iItemCnt = iItemCnt + 1;


                                                }
                       



                    }


                    intSerachCnt = intNextSerachCnt;
                    astrSerach = astrNextSerach;



                }



                //lblKensu.Text = "【" + txtSerachKW.Text + "】 " + intCount + "件、見つかりました。" + $" 処理時間 {ts}";
                //lblKensu.Text = "【" + txtSerachKW.Text + "】の関連キーワード： " + intCount + "件" ;

                //昇順へ並び変え
                KWSort(0);

                KWsplit(0);

                // 計測停止
                sw.Stop();

                TimeSpan ts = sw.Elapsed;
                var span = new TimeSpan(0, 0, ts.Seconds);
                var hhmmss = span.ToString(@"hh\:mm\:ss");

                lblKensu.Text = "【" + txtSerachKW.Text + "】の関連キーワード： " + intCount + "件";
                lblTime.Text= "処理時間：" + span.ToString(@"hh\:mm\:ss");

                

                MessageBox.Show("終了しました！", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        */



        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await button4_Click(sender, e);
        }


        private async Task button4_Click(object sender, EventArgs e)
        {
            try
            {
                // WebView2の非同期処理を待つ
                //PerformKeywordSearchAsync();

                await PerformKeywordSearchAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"致命的なエラー: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private async Task PerformKeywordSearchAsync()
        {

            int intSerachCnt = 1;
            // Stopwatchクラス生成
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();


            try
            {

                // トライアル版のチェック
                if (mintTrail == 1 && intCount > 0)
                {
                    MessageBox.Show("トライアル版は、検索回数は1回のみと制限しております。制限を解除する場合は、購入をご検討ください。。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtSerachKW.Text))
                {
                    MessageBox.Show("キーワードを入力して下さい。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSerachKW.Focus();
                    return;
                }

                lblTime.Text = "";

                await InitializeWebView2();

                if (chkKanrenKWClear.Checked)
                {
                    astrData = new string[1];
                    intCount = 0;
                    txtList.Clear();

                }

                mintStopFlag = 0;
                //astrData = new string[1];
                lblKWCount.Text = "";

                txtKW.Clear();

                sw.Start();  // 計測開始

                int intNextSerachCnt = 0;
                int intKaisou = int.Parse(cmdKaisou.Text);
                string[] astrSerach = { txtSerachKW.Text };
                string[] astrNextSerach = new string[1];

                string strMove = "";
                int intMoveCnt = 0;


                for (int ikai = 0; ikai < intKaisou; ikai++)
                {
                    for (int iSer = 0; iSer < intSerachCnt; iSer++)
                    {

                        for (int i = 0; i < intMoveCnt; i++)
                        {
                            strMove = strMove + "･";


                            if (intMoveCnt > 5)
                            {
                                intMoveCnt = 0;
                                strMove = "";
                            }

                        }

                        intMoveCnt += 1;

                        if (mintStopFlag == 1) return;

                        await Task.Delay(500);

                        if (mintStopFlag == 1) return;


                        lblKensu.Text = $"{ikai + 1}階層目を検索中" + strMove;


                        await Task.Delay(1000);

                        if (mintStopFlag == 1) return;


                        string url = BuildGoogleSearchUrl(astrSerach[iSer]);

                        if (mintStopFlag == 1) return;

                        await Task.Delay(1000);

                        if (mintStopFlag == 1) return;


                        try
                        {
                            await LoadPageAsync(url);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"ページ読み込みエラー: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        if (mintStopFlag == 1) return;

                        await Task.Delay(1000);

                        if (mintStopFlag == 1) return;


                        try
                        {
                            /*

                            string script = @"
                        (function() {
                            const keywords = [];
                            const elements = document.querySelectorAll('div.b2Rnsc span.dg6jd');
                            for (let i = 0; i < elements.length && i < 10; i++) {
                                keywords.push(elements[i].innerText);
                            }
                            return keywords;
                        })();
                    ";


                            string result = await webView2.CoreWebView2.ExecuteScriptAsync(script);
                            result = result.TrimStart('[').TrimEnd(']').Replace("\"", "");
                            var keywords = result.Split(',');
                           
                             */

                            string jsResult = await webView2.CoreWebView2.ExecuteScriptAsync(GetMobileRelatedKeywordsScript());

                            // jsResult は "[\"リボ払い 上手な使い方 知恵袋\", \"リボ払い 1ヶ月だけ\", ...]" 形式のJSON
                            var keywords = JsonConvert.DeserializeObject<List<string>>(jsResult) ?? new List<string>();






                            foreach (var keyword in keywords)
                            {

                                if (mintStopFlag == 1) return;


                                if (!string.IsNullOrWhiteSpace(keyword) && !astrData.Contains(keyword.Trim()))
                                {
                                    txtList.AppendText(keyword.Trim() + Environment.NewLine);
                                    astrNextSerach[intNextSerachCnt] = keyword.Trim();
                                    intNextSerachCnt++;

                                    Array.Resize(ref astrNextSerach, intNextSerachCnt + 1);
                                    astrData[intCount] = keyword.Trim();
                                    intCount = intCount + 1;
                                    Array.Resize(ref astrData, intCount + 1);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"JavaScriptエラー: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (mintStopFlag == 1) return;


                    }

                    if (mintStopFlag == 1) return;

                    intSerachCnt = intNextSerachCnt;
                    astrSerach = astrNextSerach;
                }


                //単体でのキーワードを表示
                KWSort(0);
                KWsplit(0);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"重大なエラーが発生しました: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                sw.Stop();

                lblKensu.Text = $"検索が完了しました。　{intCount}件のキーワードが見つかりました。";
                lblTime.Text = "処理時間：" + sw.Elapsed.ToString(@"hh\:mm\:ss");
                //MessageBox.Show("キーワード検索が完了しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }


        private async Task PerformKeywordSearchAsync_back()
        {
            
            // Stopwatchクラス生成
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            try
            {



                // トライアル版のチェック
                if (mintTrail == 1 && intCount > 0)
                {
                    MessageBox.Show("トライアル版は、検索回数は1回のみと制限しております。制限を解除する場合は、購入をご検討ください。。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtSerachKW.Text))
                {
                    MessageBox.Show("キーワードを入力して下さい。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSerachKW.Focus();
                    return;
                }

                lblTime.Text = "";

                await InitializeWebView2();

                if (chkKanrenKWClear.Checked)
                {
                    astrData = new string[1];
                    intCount = 0;
                }

                mintStopFlag = 0;
                //astrData = new string[1];
                lblKWCount.Text = "";
                txtKW.Clear();


                // 計測開始
                sw.Start();



                int intSerachCnt = 1;
                int intNextSerachCnt = 0;
                int intKaisou = int.Parse(cmdKaisou.Text);
                string[] astrSerach = { txtSerachKW.Text };
                string[] astrNextSerach = new string[1];




                string strMove = "";
                int intMoveCnt = 0;


                for (int ikai = 0; ikai < intKaisou; ikai++)
                {
                    //string strKensu = "";

                    for (int iSer = 0; iSer < intSerachCnt; iSer++)
                    {

                        

                        for (int i=0; i< intMoveCnt; i++)
                        {
                            strMove = strMove + "．";


                            if (intMoveCnt > 5)
                            {
                                intMoveCnt = 0;
                                strMove = "";
                            }

                        }

                        intMoveCnt += 1;


                        await  Task.Delay(1000);

                        lblKensu.Text = $"{ikai + 1}階層目を検索中" + strMove;


                        await Task.Delay(1000);

                        //string url = "https://www.google.com/search?q=" +  astrSerach[iSer];

                        string url = BuildGoogleSearchUrl(astrSerach[iSer]);


                        if (mintStopFlag == 1)
                        {
                            return;
                        }

                        if (!Uri.TryCreate(url, UriKind.Absolute, out Uri resurl))
                        {
                            MessageBox.Show("URLが不正です: " + url, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                        url = resurl.AbsoluteUri;




                        //await webView2.EnsureCoreWebView2Async();


                        /*

                        TaskCompletionSource<bool> navigationCompletion = new TaskCompletionSource<bool>();
                        EventHandler<CoreWebView2NavigationCompletedEventArgs> handler = null;
                        handler = (sender, args) =>
                        {



                            webView2.NavigationCompleted -= handler;
                            if (args.IsSuccess)
                            {
                                navigationCompletion.TrySetResult(true);

                            }
                            else {
                                //navigationCompletion.TrySetException(new Exception("ナビゲーションに失敗しました。"));
                            }
                        
                        };

                        webView2.NavigationCompleted += handler;
                        */

                        await Task.Delay(1000);

                        webView2.Source = new Uri(url);

                        await Task.Delay(1000);

                        /*
                        try
                        {
                            await navigationCompletion.Task;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"ナビゲーションエラー: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        await Task.Delay(1000); // ページロード待機
                        */

                        try
                        {
                            string script = @"
                    (function() {
                        const keywords = [];
                        const elements = document.querySelectorAll('div.b2Rnsc span.dg6jd');
                        for (let i = 0; i < elements.length && i < 10; i++) {
                            keywords.push(elements[i].innerText);
                        }
                        return keywords;
                    })();
                    ";
                            string result = await webView2.CoreWebView2.ExecuteScriptAsync(script);
                            result = result.TrimStart('[').TrimEnd(']').Replace("\"", "");
                            var keywords = result.Split(',');

                            foreach (var keyword in keywords)
                            {
                                if (!string.IsNullOrWhiteSpace(keyword) && !astrData.Contains(keyword.Trim()))
                                {
                                    txtList.AppendText(keyword.Trim() + Environment.NewLine);
                                    astrNextSerach[intNextSerachCnt] = keyword.Trim();
                                    intNextSerachCnt++;
                                    

                                    Array.Resize(ref astrNextSerach, intNextSerachCnt + 1);


                                    astrData[intCount] = keyword.Trim();
                                    intCount = intCount + 1;
                                    Array.Resize(ref astrData, intCount + 1);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"JavaScriptエラー: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    intSerachCnt = intNextSerachCnt;
                    astrSerach = astrNextSerach;
                }

                KWSort(0);
                KWsplit(0);


                // 計測停止
                sw.Stop();

                TimeSpan ts = sw.Elapsed;

                if (mintStopFlag == 1)
                {
                    //mintStopFlag = 0;
                    lblTime.Text = "中止をしました。";

                }
                else
                {
                    lblTime.Text = "処理時間：" + ts.ToString(@"hh\:mm\:ss");
                }


                //MessageBox.Show("キーワード検索が完了しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             catch (Exception ex)
            {
                MessageBox.Show($"重大なエラーが発生しました: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

        }

        private async Task LoadPageAsync(string url)
        {
            var navigationCompletion = new TaskCompletionSource<bool>();

            EventHandler<CoreWebView2NavigationCompletedEventArgs> handler = null;
            handler = (sender, args) =>
            {
                webView2.NavigationCompleted -= handler;
                if (args.IsSuccess)
                {
                    navigationCompletion.TrySetResult(true);
                }
                else
                {
                    navigationCompletion.TrySetException(new Exception($"ナビゲーションに失敗: {args.WebErrorStatus}"));
                }
            };

            webView2.NavigationCompleted += handler;
            webView2.Source = new Uri(url);

            try
            {
                bool isSuccess = await Task.WhenAny(navigationCompletion.Task, Task.Delay(15000)) == navigationCompletion.Task;

                if (!isSuccess)
                {
                    throw new Exception("ページの読み込みがタイムアウトしました。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ページ読み込みエラー: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
    


            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            WebClient wc = new WebClient();
            System.IO.Stream st = wc.OpenRead("https://www.google.com/search?q=%E3%83%80%E3%82%A4%E3%82%A8%E3%83%83%E3%83%88%E3%81%97%E3%81%9F%E3%81%84&oq=%E3%83%80%E3%82%A4%E3%82%A8%E3%83%83%E3%83%88%E3%81%97%E3%81%9F%E3%81%84&aqs=chrome..69i57j0l9.4070j0j7&sourceid=chrome&ie=UTF-8");

            var parser = new AngleSharp.Html.Parser.HtmlParser();
            var doc = parser.ParseDocument(st);

            

            var h2Nodes = doc.QuerySelectorAll("div.s75CSd.OhScic.AB4Wff > b");                   //ドキュメント内すべての<h2>要素を取得

            var ulNodes = doc.QuerySelectorAll(".s75CSd"); //ドキュメント内すべての<ul>要素の中からid属性が'footer-info'の要素を取得
            //var liNodes = ulNodes[0].QuerySelectorAll("li");            //この要素の直下にある<li>要素を取得
            //var aNodes = ulNodes[0].QuerySelectorAll("a");             //この要素内のすべて<a>要素を取得

            foreach (var item in h2Nodes)
            {
                Console.WriteLine(item.InnerHtml);
            }


        }

        private void btnAscendingOrder_Click(object sender, EventArgs e)
        {

            KWSort(0);
            KWsplit(0);

        }

        private void btnDescendingOrder_Click(object sender, EventArgs e)
        {
            
            KWSort(1);
            KWsplit(1);

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();


        }

        private void btnKW_Click(object sender, EventArgs e)
        {

            KWsplit(0);


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mintStopFlag = 1;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            GetPassword();

        }

        private void パスワードToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPassWord();

        }

        private async void frmMain_Load(object sender, EventArgs e)
        {


            var assembly = Assembly.GetExecutingAssembly();
            var asmTitle = (AssemblyTitleAttribute)Attribute.GetCustomAttribute(assembly,
                                                                    typeof(AssemblyTitleAttribute));
            var asmCopyright = (AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(assembly,
                                                                typeof(AssemblyCopyrightAttribute));

            
            System.Reflection.AssemblyName asmName = assembly.GetName();
            System.Version version = asmName.Version;

            this.Text = asmTitle.Title + " Ver" + version.ToString();


            await InitializeWebView2();


            //webview2を非表示にする
            //panel7.Visible = false;


            GetPassword();



        }

        private void 操作マニュアルToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenUrl("https://ppc-work.biz/pl/ncwp");

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ppc-work.biz/pl/st4g");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GKSearch.frmQASerach f1 = new GKSearch.frmQASerach();

            f1.ShowDialog();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void webView2_Click(object sender, EventArgs e)
        {

        }

        private void webView2_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
