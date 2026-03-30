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
using NMeCab;

namespace GKSearch
{
    public partial class frmQASerach : Form
    {

        string[] astrData = new string[1];
        int intCount = 0;
        int mintStopFlag = 0;


        public frmQASerach()
        {


            InitializeComponent();

            // ListViewコントロールのプロパティを設定
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Sorting = SortOrder.Ascending;
            listView1.View = View.Details;


            ColumnHeader columnName, columnType, columnData;

            // 列（コラム）ヘッダの作成
            columnName = new ColumnHeader();
            columnType = new ColumnHeader();
            columnData = new ColumnHeader();
            columnName.Text = "名前";
            columnName.Width = 100;
            columnType.Text = "種類";
            columnType.Width = 60;
            columnData.Text = "データ";
            columnData.Width = 150;
            ColumnHeader[] colHeaderRegValue =
              { columnName, columnType, columnData };
            listView1.Columns.AddRange(colHeaderRegValue);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


         

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {


            if (txtSerachKW.Text.Length == 0)
            {
                MessageBox.Show("キーワードを入力して下さい。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtSerachKW.Focus();

            }
            else
            {
                // ListViewコントロールのデータをすべて消去します。
                listView1.Items.Clear();

                

                var config = Configuration.Default.WithDefaultLoader().WithDefaultCookies();
                var context = BrowsingContext.New(config);






                if (chkYahoo.Checked == true)
                {
                    astrData = new string[1];
                    intCount = 0;
                }


                mintStopFlag = 0;

                //int i;

                string[] astrSerach;
                string[] astrNextSerach;
                int intSerachCnt = 1;
                int intNextSerachCnt = 0;
                int intKaisou = 0;
                int intChk = 0;




                // Stopwatchクラス生成
                var sw = new System.Diagnostics.Stopwatch();

                var mecab = MeCabTagger.Create();
                var strData = new HashSet<string>();
                var pstrURL = new HashSet<string>();


                // 計測開始
                sw.Start();


                astrSerach = new string[1];
                astrNextSerach = new string[1];


                astrSerach[0] = txtSerachKW.Text;
                intKaisou = 1;

                /*
                intKaisou = Int32.Parse(cmdKaisou.Text);
                lblKensu.Text = "";
                lblTime.Text = "";



                txtList.Clear();

                lblKWCount.Text = "";
                txtKW.Clear();
                */


                //この値を見て関連キーワードを探している。
                //const string CstrSelectClass = "div.BNeawe.s3v9rd.AP7Wnd.lRVwie";

                const string CstrSelectClass = ".ListSearchResults_listSearchResults__listItem__F0427";
                



                for (int ikai = 0; ikai < intKaisou; ikai++)
                {

                    intNextSerachCnt = 0;
                    astrNextSerach = new string[1];

                    //lblKensu.Text = (ikai + 1) + "階層目を検索中";

                    string strKensu = "";

                    //中止処理
                    if (mintStopFlag == 1)
                    {
                        return;
                    }


                    for (int iSer = 0; iSer < intSerachCnt; iSer++)
                    {

                        var document = await context.OpenAsync(@"https://chiebukuro.yahoo.co.jp/search?p=" + astrSerach[0] + "&fr=common-navi&sort=0");



                        //Google検索で制限がかかっている場合の処理
                        if (document.BaseUri.IndexOf("/sorry/") > 0)
                        {

                            MessageBox.Show("Google検索で制限がかかりました。OKボタンをクリック後、暫く時間を置いてから行ってください。。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            System.Diagnostics.Process.Start(document.BaseUri);

                            return;


                        }


                        //中止処理
                        if (mintStopFlag == 1)
                        {
                            //lblKensu.Text = "中止しました。";
                            //lblKensu.Refresh();
                            return;
                        }



                        var seltem = document.QuerySelectorAll(CstrSelectClass);


                        int iItemCnt = 1;

                        foreach (var item in seltem)
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

                            //if (chkJufukuChk.Checked == true)
                            //{
                            //for (i = 0; i < intCount; i++)
                            //{
                            //if (astrData[i] == item.InnerHtml.Trim())
                            //{
                            //intChk = 1;
                            //break;
                            //}
                            //}
                            //}


                            

                            if (intChk == 0)
                            {
                                //if (txtList.Text.Length == 0)
                                //{
                                //txtList.Text = item.InnerHtml.Trim();
                                //}
                                //else
                                //{
                                //txtList.Text = txtList.Text + Environment.NewLine + item.InnerHtml.Trim();
                                //}

                                astrData[intCount] = item.InnerHtml.Trim();
                                intCount = intCount + 1;
                                Array.Resize(ref astrData, intCount + 1);




                                //タイトル
                                var e1 = item.GetElementsByClassName("ListSearchResults_listSearchResults__heading__1T_RX");


                                //URL取得
                                var aURL = item.QuerySelectorAll("a");


                                //質問
                                var e2 = item.GetElementsByClassName("ListSearchResults_listSearchResults__summary__3VWzs");



                                //解決済
                                //var e3 = item.GetElementsByClassName("ListSearchResults_listSearchResults__informationStatus--resolved__1p9NY");



                                //質問日時
                                //var e4 = item.GetElementsByClassName("ListSearchResults_listSearchResults__informationDate__10t00");


                                //質問回数
                                //var e5 = item.GetElementsByClassName("ListSearchResults_listSearchResults__informationAnswers__2Uv5W");


                                //閲覧数
                                //var e6 = item.GetElementsByClassName("ListSearchResults_listSearchResults__informationViews__7Ovr2");



                                var node = mecab.ParseToNode(e1[0].TextContent);



                                //全ての形態素を取り出すループ
                                while (node != null)
                                {
                                    //形態素1つ分の解析結果を取り出し
                                    string surface = node.Surface; //表層形（形態素）
                                    string feature = node.Feature; //解析結果（品詞、読み仮名等）

                                    string[] arr = feature.Split(',');

                                    if (arr[0] == "名詞" || arr[0] == "動詞"){

                                        strData.Add(arr[6]);

                                    }

                                    //次の形態素を取り出す
                                    node = node.Next;
                                }



                                


                                var node2 = mecab.ParseToNode(e2[0].TextContent);

                                //全ての形態素を取り出すループ
                                while (node2 != null)
                                {
                                    //形態素1つ分の解析結果を取り出し
                                    string surface = node2.Surface; //表層形（形態素）
                                    string feature = node2.Feature; //解析結果（品詞、読み仮名等）  



                                    string[] arr = feature.Split(',');

                                    if (arr[0] == "名詞" || arr[0] == "動詞")
                                    {

                                        strData.Add(arr[6]);

                                    }


                                    //次の形態素を取り出す

                                    node2 = node2.Next;
                                }




                                // ListViewコントロールにデータを追加します。

                                grdList.Rows.Add(e1[0].TextContent,"Yahoo知恵袋", e2[0].TextContent, aURL[0].GetAttribute("href"));

                                pstrURL.Add(aURL[0].GetAttribute("href"));



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



                //単語を表示する。
                foreach (var dt in strData)
                {
                    listView1.Items.Add(dt);

                }



                //Yahoo知恵袋の詳細をGET



                //const string CstrClassQuestion = "yjSlinkHighlightSearch Detail_chie-Pages__Section__1IX0V";

                const string CstrClassQuestion = ".mdQuestion .mdTitle span";




                foreach (var url in pstrURL)
                {



                    //var yahoo = new YahooQAScraper.Program();

                    //yahoo.seturl = url;

                    //await yahoo.Start();




                    var document1 = await context.OpenAsync(@"" + url);

                    var seltemQ = document1.QuerySelectorAll(CstrClassQuestion);

                    var q = document1.QuerySelector(".mdQuestion .mdTitle span");



                    foreach (var itemQ in seltemQ)
                    {



                        //質問
                        var e1 = itemQ.GetElementsByClassName("yjSlinkDirectlink ClapLv1TextBlock_Chie-TextBlock__Text__BdN5f ClapLv1TextBlock_Chie-TextBlock__Text--mediumRelative__5lB0y ClapLv1TextBlock_Chie-TextBlock__Text--SpaceOut__1b5gb ClapLv1TextBlock_Chie-TextBlock__Text--preLine__1-WZ0");



                        var node = mecab.ParseToNode(e1[0].TextContent);



                        //全ての形態素を取り出すループ
                        while (node != null)
                        {
                            //形態素1つ分の解析結果を取り出し
                            string surface = node.Surface; //表層形（形態素）
                            string feature = node.Feature; //解析結果（品詞、読み仮名等）

                            string[] arr = feature.Split(',');

                            if (arr[0] == "名詞" || arr[0] == "動詞")
                            {

                                strData.Add(arr[6]);

                            }

                            //次の形態素を取り出す
                            node = node.Next;
                        }



                    }











                }







                    //lblKensu.Text = "【" + txtSerachKW.Text + "】 " + intCount + "件、見つかりました。" + $" 処理時間 {ts}";
                    //lblKensu.Text = "【" + txtSerachKW.Text + "】の関連キーワード： " + intCount + "件" ;

                    //昇順へ並び変え
                    //KWSort(0);

                    //KWsplit(0);

                    // 計測停止
                    sw.Stop();

                TimeSpan ts = sw.Elapsed;
                var span = new TimeSpan(0, 0, ts.Seconds);
                var hhmmss = span.ToString(@"hh\:mm\:ss");

                lblKensu.Text = "【" + txtSerachKW.Text + "】の関連キーワード： " + intCount + "件";
                lblTime.Text = "処理時間：" + span.ToString(@"hh\:mm\:ss");



                MessageBox.Show("終了しました！", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }



        }

        private void grdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender; //クリックした列が対象列かチェックする。			
            if (dgv.Columns[e.ColumnIndex].Name != "ButtonCol")
            {
                return;
            }
            MessageBox.Show("ボタン列をクリックしました。");
        }

        private void btnKeyWordGet_Click(object sender, EventArgs e)
        {

            String strURL = "";



                // DataGridViewの行を1行ずつループ処理する
            foreach (DataGridViewRow row in grdList.Rows)
            {


                // 各行のセルの値を参照する
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // セルの値を取得する
                    string value = cell.Value.ToString();
                    // ここでセルの値を使って何らかの処理を行う
                }
            }




        }
    }
}
