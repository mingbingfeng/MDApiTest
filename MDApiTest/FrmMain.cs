using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MDApiTest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            pnlGetReqListData.Dock = DockStyle.Fill;
            pnlGetReqDetailData.Dock = DockStyle.Fill;
            cboMethod.SelectedIndex = 0;
            //long l = Tool.ConvertDateTimeToInt(DateTime.Now);
            //long l1 = Tool.GetTimeTick(DateTime.Now);
            ////string s = Tool.LongDateTimeToDateTimeString((l* 10000000).ToString());
            //Console.WriteLine();
        }

        private void cboMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlGetReqDetailData.Visible = cboMethod.SelectedIndex == 2;
            pnlGetReqListData.Visible = cboMethod.SelectedIndex == 1;
        }


        string responsStr = string.Empty;//接受响应内容
        private void btnRequest_Click(object sender, EventArgs e)
        {
            responsStr = string.Empty;
            btnRequest.Enabled = false;
            string method = cboMethod.Text;
            if (method.Trim().Length > 0)
            {
                SetResponsText("正在请求接口："+ method);
                string url = txtApiAddress.Text.Trim() + method;
                long timestamp = Tool.GetTimeTick(DateTime.Now);
                string sign = Signature.GetSignature(txtAppKey.Text.Trim(), txtSecreKey.Text.Trim(), timestamp);
                string postDataStr = string.Empty;
                postDataStr += "appKey=" + txtAppKey.Text.Trim();
                postDataStr += "&sign=" + sign;
                postDataStr += "&timestamp=" + timestamp;
                switch (cboMethod.SelectedIndex)
                {
                    case 1:
                        postDataStr += "&formId=" + txtFormId.Text.Trim();
                        postDataStr += "&startTime=" + Tool.GetTimeTick(dtpStartTime.Value);
                        postDataStr += "&endTime=" + Tool.GetTimeTick(dtpEndTime.Value);
                        break;
                    case 2:
                        url += "/" + txtId.Text.Trim();
                        //postDataStr += "&id=" + txtId.Text.Trim();
                        break;
                }
                txtrequestUrl.Text = url + (postDataStr == "" ? "" : "?") + postDataStr;
                SetResponsText("请求地址为：" + txtrequestUrl.Text);
                //在线程中处理请求
                Thread th = new Thread(new ParameterizedThreadStart(DoRequest));
                th.IsBackground = true;
                th.Start(txtrequestUrl.Text);
                bool flag = false;
                //等待响应结果
                while (responsStr.Length==0)
                {
                    Thread.Sleep(300);
                    if(!flag)
                        SetResponsText("请等待响应");
                    rtxtRespons.Text += ".";
                    Application.DoEvents();
                    flag=true;
                }
                rtxtRespons.Text += "\r\n";
                SetResponsText( responsStr);
                rtxtRespons.Text += "\r\n";
            }
            btnRequest.Enabled = true;
            
        }

        //添加文本框文本
        private void SetResponsText(string msg) {
            rtxtRespons.Text+=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss：")+msg+"\r\n";
            rtxtRespons.SelectionStart = rtxtRespons.Text.Length; //Set the current caret position at the end
            rtxtRespons.ScrollToCaret(); //Now scroll it automatically
            Application.DoEvents();
        }

        //发送请求
        private void DoRequest(object url)
        {
            responsStr = Tool.HttpGet(url.ToString());
            if (responsStr == string.Empty)
                responsStr = "返回结果为空";
        }
    }
}
