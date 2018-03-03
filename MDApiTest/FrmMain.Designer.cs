namespace MDApiTest
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboMethod = new System.Windows.Forms.ComboBox();
            this.pnlGetReqListData = new System.Windows.Forms.Panel();
            this.txtFormId = new System.Windows.Forms.TextBox();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGetReqDetailData = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbPara = new System.Windows.Forms.GroupBox();
            this.gbRespons = new System.Windows.Forms.GroupBox();
            this.rtxtRespons = new System.Windows.Forms.RichTextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.txtAppKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSecreKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApiAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtrequestUrl = new System.Windows.Forms.TextBox();
            this.pnlGetReqListData.SuspendLayout();
            this.pnlGetReqDetailData.SuspendLayout();
            this.gbPara.SuspendLayout();
            this.gbRespons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "接口列表：";
            // 
            // cboMethod
            // 
            this.cboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMethod.FormattingEnabled = true;
            this.cboMethod.Items.AddRange(new object[] {
            "getFormListData",
            "getReqListData",
            "getReqDetailData"});
            this.cboMethod.Location = new System.Drawing.Point(123, 22);
            this.cboMethod.Name = "cboMethod";
            this.cboMethod.Size = new System.Drawing.Size(145, 20);
            this.cboMethod.TabIndex = 1;
            this.cboMethod.SelectedIndexChanged += new System.EventHandler(this.cboMethod_SelectedIndexChanged);
            // 
            // pnlGetReqListData
            // 
            this.pnlGetReqListData.Controls.Add(this.txtFormId);
            this.pnlGetReqListData.Controls.Add(this.dtpEndTime);
            this.pnlGetReqListData.Controls.Add(this.dtpStartTime);
            this.pnlGetReqListData.Controls.Add(this.label4);
            this.pnlGetReqListData.Controls.Add(this.label3);
            this.pnlGetReqListData.Controls.Add(this.label2);
            this.pnlGetReqListData.Location = new System.Drawing.Point(171, 10);
            this.pnlGetReqListData.Name = "pnlGetReqListData";
            this.pnlGetReqListData.Size = new System.Drawing.Size(652, 90);
            this.pnlGetReqListData.TabIndex = 2;
            this.pnlGetReqListData.Visible = false;
            // 
            // txtFormId
            // 
            this.txtFormId.Location = new System.Drawing.Point(96, 15);
            this.txtFormId.Name = "txtFormId";
            this.txtFormId.Size = new System.Drawing.Size(271, 21);
            this.txtFormId.TabIndex = 2;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(367, 48);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(145, 21);
            this.dtpEndTime.TabIndex = 1;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(96, 48);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(145, 21);
            this.dtpStartTime.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "endTime：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "startTime：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "formId：";
            // 
            // pnlGetReqDetailData
            // 
            this.pnlGetReqDetailData.Controls.Add(this.txtId);
            this.pnlGetReqDetailData.Controls.Add(this.label7);
            this.pnlGetReqDetailData.Location = new System.Drawing.Point(21, 25);
            this.pnlGetReqDetailData.Name = "pnlGetReqDetailData";
            this.pnlGetReqDetailData.Size = new System.Drawing.Size(652, 90);
            this.pnlGetReqDetailData.TabIndex = 3;
            this.pnlGetReqDetailData.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(96, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(271, 21);
            this.txtId.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Id：";
            // 
            // gbPara
            // 
            this.gbPara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPara.Controls.Add(this.pnlGetReqListData);
            this.gbPara.Controls.Add(this.pnlGetReqDetailData);
            this.gbPara.Location = new System.Drawing.Point(27, 182);
            this.gbPara.Name = "gbPara";
            this.gbPara.Size = new System.Drawing.Size(652, 100);
            this.gbPara.TabIndex = 4;
            this.gbPara.TabStop = false;
            this.gbPara.Text = "参数";
            // 
            // gbRespons
            // 
            this.gbRespons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRespons.Controls.Add(this.rtxtRespons);
            this.gbRespons.Location = new System.Drawing.Point(27, 337);
            this.gbRespons.Name = "gbRespons";
            this.gbRespons.Size = new System.Drawing.Size(655, 295);
            this.gbRespons.TabIndex = 5;
            this.gbRespons.TabStop = false;
            this.gbRespons.Text = "响应";
            // 
            // rtxtRespons
            // 
            this.rtxtRespons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtRespons.Location = new System.Drawing.Point(3, 17);
            this.rtxtRespons.Name = "rtxtRespons";
            this.rtxtRespons.Size = new System.Drawing.Size(649, 275);
            this.rtxtRespons.TabIndex = 0;
            this.rtxtRespons.Text = "";
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(295, 20);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(99, 23);
            this.btnRequest.TabIndex = 6;
            this.btnRequest.Text = "发送请求";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // txtAppKey
            // 
            this.txtAppKey.Location = new System.Drawing.Point(123, 62);
            this.txtAppKey.Name = "txtAppKey";
            this.txtAppKey.Size = new System.Drawing.Size(271, 21);
            this.txtAppKey.TabIndex = 7;
            this.txtAppKey.Text = "0e7ae249-141f-4ab1-b2a9-2d21fc320cd5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "AppKey：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "SecretKey：";
            // 
            // txtSecreKey
            // 
            this.txtSecreKey.Location = new System.Drawing.Point(123, 102);
            this.txtSecreKey.Name = "txtSecreKey";
            this.txtSecreKey.Size = new System.Drawing.Size(271, 21);
            this.txtSecreKey.TabIndex = 7;
            this.txtSecreKey.Text = "f08d1c3aebe771fe58a758bc8815f";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "接口地址：";
            // 
            // txtApiAddress
            // 
            this.txtApiAddress.Location = new System.Drawing.Point(123, 143);
            this.txtApiAddress.Name = "txtApiAddress";
            this.txtApiAddress.Size = new System.Drawing.Size(271, 21);
            this.txtApiAddress.TabIndex = 7;
            this.txtApiAddress.Text = "https://approval.mingdao.com/api/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "请求地址：";
            // 
            // txtrequestUrl
            // 
            this.txtrequestUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrequestUrl.Location = new System.Drawing.Point(123, 299);
            this.txtrequestUrl.Name = "txtrequestUrl";
            this.txtrequestUrl.ReadOnly = true;
            this.txtrequestUrl.Size = new System.Drawing.Size(556, 21);
            this.txtrequestUrl.TabIndex = 7;
            this.txtrequestUrl.Text = "https://approval.mingdao.com/api/";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 655);
            this.Controls.Add(this.txtrequestUrl);
            this.Controls.Add(this.txtApiAddress);
            this.Controls.Add(this.txtSecreKey);
            this.Controls.Add(this.txtAppKey);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.gbRespons);
            this.Controls.Add(this.gbPara);
            this.Controls.Add(this.cboMethod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "审批数据接口";
            this.pnlGetReqListData.ResumeLayout(false);
            this.pnlGetReqListData.PerformLayout();
            this.pnlGetReqDetailData.ResumeLayout(false);
            this.pnlGetReqDetailData.PerformLayout();
            this.gbPara.ResumeLayout(false);
            this.gbRespons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMethod;
        private System.Windows.Forms.Panel pnlGetReqListData;
        private System.Windows.Forms.TextBox txtFormId;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlGetReqDetailData;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbPara;
        private System.Windows.Forms.GroupBox gbRespons;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.RichTextBox rtxtRespons;
        private System.Windows.Forms.TextBox txtAppKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSecreKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApiAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtrequestUrl;
    }
}

