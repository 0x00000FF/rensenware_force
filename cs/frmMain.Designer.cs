namespace rensenWare_forcer
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnForce = new System.Windows.Forms.Button();
            this.btnSee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.apology = new System.Windows.Forms.LinkLabel();
            this.LabelScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "THIS APPLICATION IS USED FOR FORCING RENSENWARE DECRYTPTION. IT IS VALID JUST FOR" +
    " NON-MODIFIED RENSENWARE BINARY, TRY THIS IF YOU AFFECTED BY THIS FILE :";
            // 
            // btnForce
            // 
            this.btnForce.Location = new System.Drawing.Point(12, 267);
            this.btnForce.Name = "btnForce";
            this.btnForce.Size = new System.Drawing.Size(294, 53);
            this.btnForce.TabIndex = 1;
            this.btnForce.Text = "FORCE IT";
            this.btnForce.UseVisualStyleBackColor = true;
            this.btnForce.Click += new System.EventHandler(this.btnForce_Click);
            // 
            // btnSee
            // 
            this.btnSee.Location = new System.Drawing.Point(15, 71);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(294, 53);
            this.btnSee.TabIndex = 1;
            this.btnSee.Text = "SEE VIRUSTOTAL";
            this.btnSee.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "TH12 Status : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "TH12 Score : ";
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.ForeColor = System.Drawing.Color.Red;
            this.LabelStatus.Location = new System.Drawing.Point(104, 202);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(75, 12);
            this.LabelStatus.TabIndex = 3;
            this.LabelStatus.Text = "NOT READY";
            // 
            // apology
            // 
            this.apology.AutoSize = true;
            this.apology.LinkColor = System.Drawing.Color.White;
            this.apology.Location = new System.Drawing.Point(13, 380);
            this.apology.Name = "apology";
            this.apology.Size = new System.Drawing.Size(229, 12);
            this.apology.TabIndex = 4;
            this.apology.TabStop = true;
            this.apology.Text = "Apology from the creator of rensenWare";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.ForeColor = System.Drawing.Color.Red;
            this.LabelScore.Location = new System.Drawing.Point(104, 237);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(75, 12);
            this.LabelScore.TabIndex = 3;
            this.LabelScore.Text = "NOT READY";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 54);
            this.label3.TabIndex = 0;
            this.label3.Text = "ACTUALLY, THERE\'S NO CHEAT PREVENTION LOGIC IN RENSENWARE. YOU CAN MODIFY MEMORY " +
    "VIA CHEAT ENGINE. THIS APPLICA- TION JUST AUTOMATES SUCH OPERATIONS.";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(13, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 54);
            this.label5.TabIndex = 0;
            this.label5.Text = "ONCE YOU GET THE KEY AND IV, DO NOT MOVE OR DELETE THEM IF THERE\'RE ENCRYPTED FIL" +
    "ES YET.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(321, 406);
            this.Controls.Add(this.apology);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSee);
            this.Controls.Add(this.btnForce);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "rensenWare_forcer";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KillAllThread);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnForce;
        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.LinkLabel apology;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

