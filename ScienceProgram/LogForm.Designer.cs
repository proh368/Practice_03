namespace ScienceProgram
{
    partial class LogForm
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
            this.loginLbl = new System.Windows.Forms.Label();
            this.logTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.logLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.logBtn = new System.Windows.Forms.Button();
            this.transitionBtn = new System.Windows.Forms.Button();
            this.transitionLogBtn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.thinkLogTxt = new System.Windows.Forms.TextBox();
            this.thinkPassTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLbl.Location = new System.Drawing.Point(219, 9);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(139, 55);
            this.loginLbl.TabIndex = 1;
            this.loginLbl.Text = "Вход";
            // 
            // logTxt
            // 
            this.logTxt.Location = new System.Drawing.Point(141, 116);
            this.logTxt.Name = "logTxt";
            this.logTxt.Size = new System.Drawing.Size(284, 20);
            this.logTxt.TabIndex = 2;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(141, 208);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(284, 20);
            this.passTxt.TabIndex = 3;
            // 
            // logLbl
            // 
            this.logLbl.AutoSize = true;
            this.logLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logLbl.Location = new System.Drawing.Point(137, 93);
            this.logLbl.Name = "logLbl";
            this.logLbl.Size = new System.Drawing.Size(55, 20);
            this.logLbl.TabIndex = 4;
            this.logLbl.Text = "Логин";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLbl.Location = new System.Drawing.Point(137, 185);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(67, 20);
            this.passLbl.TabIndex = 5;
            this.passLbl.Text = "Пароль";
            // 
            // logBtn
            // 
            this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBtn.Location = new System.Drawing.Point(217, 301);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(141, 48);
            this.logBtn.TabIndex = 6;
            this.logBtn.Text = "Войти";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // transitionBtn
            // 
            this.transitionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transitionBtn.Location = new System.Drawing.Point(12, 301);
            this.transitionBtn.Name = "transitionBtn";
            this.transitionBtn.Size = new System.Drawing.Size(141, 48);
            this.transitionBtn.TabIndex = 7;
            this.transitionBtn.Text = "Перейти на регистрацию";
            this.transitionBtn.UseVisualStyleBackColor = true;
            this.transitionBtn.Click += new System.EventHandler(this.transitionBtn_Click);
            // 
            // transitionLogBtn
            // 
            this.transitionLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transitionLogBtn.Location = new System.Drawing.Point(12, 301);
            this.transitionLogBtn.Name = "transitionLogBtn";
            this.transitionLogBtn.Size = new System.Drawing.Size(141, 48);
            this.transitionLogBtn.TabIndex = 8;
            this.transitionLogBtn.Text = "Перейти на вход";
            this.transitionLogBtn.UseVisualStyleBackColor = true;
            this.transitionLogBtn.Visible = false;
            this.transitionLogBtn.Click += new System.EventHandler(this.transitionLogBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Location = new System.Drawing.Point(217, 301);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(141, 48);
            this.regBtn.TabIndex = 9;
            this.regBtn.Text = "Зарегистрироваться";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Visible = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // thinkLogTxt
            // 
            this.thinkLogTxt.Location = new System.Drawing.Point(141, 116);
            this.thinkLogTxt.Name = "thinkLogTxt";
            this.thinkLogTxt.Size = new System.Drawing.Size(284, 20);
            this.thinkLogTxt.TabIndex = 10;
            this.thinkLogTxt.Visible = false;
            // 
            // thinkPassTxt
            // 
            this.thinkPassTxt.Location = new System.Drawing.Point(141, 208);
            this.thinkPassTxt.Name = "thinkPassTxt";
            this.thinkPassTxt.Size = new System.Drawing.Size(284, 20);
            this.thinkPassTxt.TabIndex = 11;
            this.thinkPassTxt.Visible = false;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.thinkPassTxt);
            this.Controls.Add(this.thinkLogTxt);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.transitionLogBtn);
            this.Controls.Add(this.transitionBtn);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.logLbl);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.logTxt);
            this.Controls.Add(this.loginLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScienceProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox logTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label logLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button transitionBtn;
        private System.Windows.Forms.Button transitionLogBtn;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.TextBox thinkLogTxt;
        private System.Windows.Forms.TextBox thinkPassTxt;
    }
}