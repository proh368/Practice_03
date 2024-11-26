namespace ScienceProgram
{
    partial class MainForm
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
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.listScientistBtn = new System.Windows.Forms.Button();
            this.listConferenceBtn = new System.Windows.Forms.Button();
            this.listParticipationBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLbl.Location = new System.Drawing.Point(163, 9);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(481, 55);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Добро пожаловать!";
            // 
            // listScientistBtn
            // 
            this.listScientistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listScientistBtn.Location = new System.Drawing.Point(16, 191);
            this.listScientistBtn.Name = "listScientistBtn";
            this.listScientistBtn.Size = new System.Drawing.Size(105, 44);
            this.listScientistBtn.TabIndex = 1;
            this.listScientistBtn.Text = "Список ученых";
            this.listScientistBtn.UseVisualStyleBackColor = true;
            this.listScientistBtn.Click += new System.EventHandler(this.listScientistBtn_Click);
            // 
            // listConferenceBtn
            // 
            this.listConferenceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listConferenceBtn.Location = new System.Drawing.Point(127, 191);
            this.listConferenceBtn.Name = "listConferenceBtn";
            this.listConferenceBtn.Size = new System.Drawing.Size(132, 44);
            this.listConferenceBtn.TabIndex = 2;
            this.listConferenceBtn.Text = "Список конференций";
            this.listConferenceBtn.UseVisualStyleBackColor = true;
            this.listConferenceBtn.Click += new System.EventHandler(this.listConferenceBtn_Click);
            // 
            // listParticipationBtn
            // 
            this.listParticipationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listParticipationBtn.Location = new System.Drawing.Point(265, 191);
            this.listParticipationBtn.Name = "listParticipationBtn";
            this.listParticipationBtn.Size = new System.Drawing.Size(105, 44);
            this.listParticipationBtn.TabIndex = 3;
            this.listParticipationBtn.Text = "Список участий";
            this.listParticipationBtn.UseVisualStyleBackColor = true;
            this.listParticipationBtn.Click += new System.EventHandler(this.listParticipationBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите какую таблицу просмотреть:";
            // 
            // listDataGridView
            // 
            this.listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDataGridView.Location = new System.Drawing.Point(16, 241);
            this.listDataGridView.Name = "listDataGridView";
            this.listDataGridView.Size = new System.Drawing.Size(756, 308);
            this.listDataGridView.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.listDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listParticipationBtn);
            this.Controls.Add(this.listConferenceBtn);
            this.Controls.Add(this.listScientistBtn);
            this.Controls.Add(this.welcomeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScienceProgram";
            ((System.ComponentModel.ISupportInitialize)(this.listDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button listScientistBtn;
        private System.Windows.Forms.Button listConferenceBtn;
        private System.Windows.Forms.Button listParticipationBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listDataGridView;
    }
}