namespace DeliTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDockInfo = new System.Windows.Forms.Button();
            this.btnBranchInfo = new System.Windows.Forms.Button();
            this.btnFindBarcode = new System.Windows.Forms.Button();
            this.btnSendBranch = new System.Windows.Forms.Button();
            this.btnDeliveryArea = new System.Windows.Forms.Button();
            this.btnSendResult = new System.Windows.Forms.Button();
            this.btnTracking = new System.Windows.Forms.Button();
            this.btnLabelPrint = new System.Windows.Forms.Button();
            this.btnLabelPrint2 = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.btnChunilSend = new System.Windows.Forms.Button();
            this.btnChunilSendConfirm = new System.Windows.Forms.Button();
            this.btnChunilSendResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(35, 31);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(108, 66);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "발송 자료 저장";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(186, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 66);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "발송자료 삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDockInfo
            // 
            this.btnDockInfo.Location = new System.Drawing.Point(315, 31);
            this.btnDockInfo.Name = "btnDockInfo";
            this.btnDockInfo.Size = new System.Drawing.Size(130, 66);
            this.btnDockInfo.TabIndex = 2;
            this.btnDockInfo.Text = "영업소 및 도크 정보";
            this.btnDockInfo.UseVisualStyleBackColor = true;
            this.btnDockInfo.Click += new System.EventHandler(this.btnDockInfo_Click);
            // 
            // btnBranchInfo
            // 
            this.btnBranchInfo.Location = new System.Drawing.Point(477, 31);
            this.btnBranchInfo.Name = "btnBranchInfo";
            this.btnBranchInfo.Size = new System.Drawing.Size(129, 66);
            this.btnBranchInfo.TabIndex = 3;
            this.btnBranchInfo.Text = "영업소 정보";
            this.btnBranchInfo.UseVisualStyleBackColor = true;
            this.btnBranchInfo.Click += new System.EventHandler(this.btnBranchInfo_Click);
            // 
            // btnFindBarcode
            // 
            this.btnFindBarcode.Location = new System.Drawing.Point(639, 31);
            this.btnFindBarcode.Name = "btnFindBarcode";
            this.btnFindBarcode.Size = new System.Drawing.Size(124, 66);
            this.btnFindBarcode.TabIndex = 4;
            this.btnFindBarcode.Text = "운송장 번호 검색";
            this.btnFindBarcode.UseVisualStyleBackColor = true;
            this.btnFindBarcode.Click += new System.EventHandler(this.btnFindBarcode_Click);
            // 
            // btnSendBranch
            // 
            this.btnSendBranch.Location = new System.Drawing.Point(35, 168);
            this.btnSendBranch.Name = "btnSendBranch";
            this.btnSendBranch.Size = new System.Drawing.Size(108, 75);
            this.btnSendBranch.TabIndex = 5;
            this.btnSendBranch.Text = "발송 영업소 확인";
            this.btnSendBranch.UseVisualStyleBackColor = true;
            this.btnSendBranch.Click += new System.EventHandler(this.btnSendBranch_Click);
            // 
            // btnDeliveryArea
            // 
            this.btnDeliveryArea.Location = new System.Drawing.Point(186, 168);
            this.btnDeliveryArea.Name = "btnDeliveryArea";
            this.btnDeliveryArea.Size = new System.Drawing.Size(128, 75);
            this.btnDeliveryArea.TabIndex = 6;
            this.btnDeliveryArea.Text = "배달구역 확인";
            this.btnDeliveryArea.UseVisualStyleBackColor = true;
            this.btnDeliveryArea.Click += new System.EventHandler(this.btnDeliveryArea_Click);
            // 
            // btnSendResult
            // 
            this.btnSendResult.Location = new System.Drawing.Point(351, 168);
            this.btnSendResult.Name = "btnSendResult";
            this.btnSendResult.Size = new System.Drawing.Size(134, 75);
            this.btnSendResult.TabIndex = 7;
            this.btnSendResult.Text = "발송결과 확인";
            this.btnSendResult.UseVisualStyleBackColor = true;
            this.btnSendResult.Click += new System.EventHandler(this.btnSendResult_Click);
            // 
            // btnTracking
            // 
            this.btnTracking.Location = new System.Drawing.Point(521, 168);
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.Size = new System.Drawing.Size(152, 75);
            this.btnTracking.TabIndex = 8;
            this.btnTracking.Text = "신규 배송조회 (트래킹)";
            this.btnTracking.UseVisualStyleBackColor = true;
            this.btnTracking.Click += new System.EventHandler(this.btnTracking_Click);
            // 
            // btnLabelPrint
            // 
            this.btnLabelPrint.Location = new System.Drawing.Point(35, 290);
            this.btnLabelPrint.Name = "btnLabelPrint";
            this.btnLabelPrint.Size = new System.Drawing.Size(108, 74);
            this.btnLabelPrint.TabIndex = 9;
            this.btnLabelPrint.Text = "라벨출력";
            this.btnLabelPrint.UseVisualStyleBackColor = true;
            this.btnLabelPrint.Click += new System.EventHandler(this.btnLabelPrint_Click);
            // 
            // btnLabelPrint2
            // 
            this.btnLabelPrint2.Location = new System.Drawing.Point(195, 290);
            this.btnLabelPrint2.Name = "btnLabelPrint2";
            this.btnLabelPrint2.Size = new System.Drawing.Size(128, 74);
            this.btnLabelPrint2.TabIndex = 10;
            this.btnLabelPrint2.Text = "라벨출력2";
            this.btnLabelPrint2.UseVisualStyleBackColor = true;
            this.btnLabelPrint2.Click += new System.EventHandler(this.btnLabelPrint2_Click);
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(374, 290);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(139, 74);
            this.btnString.TabIndex = 11;
            this.btnString.Text = "문자열처리";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnChunilSend
            // 
            this.btnChunilSend.Location = new System.Drawing.Point(35, 488);
            this.btnChunilSend.Name = "btnChunilSend";
            this.btnChunilSend.Size = new System.Drawing.Size(116, 76);
            this.btnChunilSend.TabIndex = 12;
            this.btnChunilSend.Text = "천일택배 전송";
            this.btnChunilSend.UseVisualStyleBackColor = true;
            this.btnChunilSend.Click += new System.EventHandler(this.btnChunilSend_Click);
            // 
            // btnChunilSendConfirm
            // 
            this.btnChunilSendConfirm.Location = new System.Drawing.Point(186, 488);
            this.btnChunilSendConfirm.Name = "btnChunilSendConfirm";
            this.btnChunilSendConfirm.Size = new System.Drawing.Size(128, 76);
            this.btnChunilSendConfirm.TabIndex = 13;
            this.btnChunilSendConfirm.Text = "천일택배 확정";
            this.btnChunilSendConfirm.UseVisualStyleBackColor = true;
            this.btnChunilSendConfirm.Click += new System.EventHandler(this.btnChunilSendConfirm_Click);
            // 
            // btnChunilSendResult
            // 
            this.btnChunilSendResult.Location = new System.Drawing.Point(351, 488);
            this.btnChunilSendResult.Name = "btnChunilSendResult";
            this.btnChunilSendResult.Size = new System.Drawing.Size(143, 76);
            this.btnChunilSendResult.TabIndex = 14;
            this.btnChunilSendResult.Text = "천일택배 확정 조회";
            this.btnChunilSendResult.UseVisualStyleBackColor = true;
            this.btnChunilSendResult.Click += new System.EventHandler(this.btnChunilSendResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 710);
            this.Controls.Add(this.btnChunilSendResult);
            this.Controls.Add(this.btnChunilSendConfirm);
            this.Controls.Add(this.btnChunilSend);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnLabelPrint2);
            this.Controls.Add(this.btnLabelPrint);
            this.Controls.Add(this.btnTracking);
            this.Controls.Add(this.btnSendResult);
            this.Controls.Add(this.btnDeliveryArea);
            this.Controls.Add(this.btnSendBranch);
            this.Controls.Add(this.btnFindBarcode);
            this.Controls.Add(this.btnBranchInfo);
            this.Controls.Add(this.btnDockInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDockInfo;
        private System.Windows.Forms.Button btnBranchInfo;
        private System.Windows.Forms.Button btnFindBarcode;
        private System.Windows.Forms.Button btnSendBranch;
        private System.Windows.Forms.Button btnDeliveryArea;
        private System.Windows.Forms.Button btnSendResult;
        private System.Windows.Forms.Button btnTracking;
        private System.Windows.Forms.Button btnLabelPrint;
        private System.Windows.Forms.Button btnLabelPrint2;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnChunilSend;
        private System.Windows.Forms.Button btnChunilSendConfirm;
        private System.Windows.Forms.Button btnChunilSendResult;
    }
}

