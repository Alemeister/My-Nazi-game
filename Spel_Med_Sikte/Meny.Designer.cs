namespace Spel_Med_Sikte
{
    partial class Meny
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
            this.btn_Start_Game_Session = new System.Windows.Forms.Button();
            this.lbl_Game_Title = new System.Windows.Forms.Label();
            this.lblScoreboard = new System.Windows.Forms.Label();
            this.lbxScoreboard = new System.Windows.Forms.ListBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnBossTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Start_Game_Session
            // 
            this.btn_Start_Game_Session.Location = new System.Drawing.Point(150, 125);
            this.btn_Start_Game_Session.Name = "btn_Start_Game_Session";
            this.btn_Start_Game_Session.Size = new System.Drawing.Size(100, 50);
            this.btn_Start_Game_Session.TabIndex = 0;
            this.btn_Start_Game_Session.Text = "Start Game";
            this.btn_Start_Game_Session.UseVisualStyleBackColor = true;
            this.btn_Start_Game_Session.Click += new System.EventHandler(this.btn_Start_Game_Session_Click);
            // 
            // lbl_Game_Title
            // 
            this.lbl_Game_Title.Font = new System.Drawing.Font("Wide Latin", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Game_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Game_Title.Name = "lbl_Game_Title";
            this.lbl_Game_Title.Size = new System.Drawing.Size(360, 112);
            this.lbl_Game_Title.TabIndex = 1;
            this.lbl_Game_Title.Text = "Die Nazi, Die";
            this.lbl_Game_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreboard
            // 
            this.lblScoreboard.AutoSize = true;
            this.lblScoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreboard.Location = new System.Drawing.Point(6, 237);
            this.lblScoreboard.Name = "lblScoreboard";
            this.lblScoreboard.Size = new System.Drawing.Size(164, 31);
            this.lblScoreboard.TabIndex = 2;
            this.lblScoreboard.Text = "Scoreboard";
            // 
            // lbxScoreboard
            // 
            this.lbxScoreboard.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxScoreboard.FormattingEnabled = true;
            this.lbxScoreboard.ItemHeight = 19;
            this.lbxScoreboard.Location = new System.Drawing.Point(12, 268);
            this.lbxScoreboard.Name = "lbxScoreboard";
            this.lbxScoreboard.Size = new System.Drawing.Size(360, 80);
            this.lbxScoreboard.TabIndex = 4;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(287, 215);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(85, 47);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnBossTest
            // 
            this.btnBossTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBossTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBossTest.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBossTest.Location = new System.Drawing.Point(12, 195);
            this.btnBossTest.Name = "btnBossTest";
            this.btnBossTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBossTest.Size = new System.Drawing.Size(195, 39);
            this.btnBossTest.TabIndex = 6;
            this.btnBossTest.Text = "Boss (Test)";
            this.btnBossTest.UseVisualStyleBackColor = true;
            this.btnBossTest.Click += new System.EventHandler(this.btnBossTest_Click);
            // 
            // Meny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.btnBossTest);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lbxScoreboard);
            this.Controls.Add(this.lblScoreboard);
            this.Controls.Add(this.lbl_Game_Title);
            this.Controls.Add(this.btn_Start_Game_Session);
            this.Name = "Meny";
            this.Text = "Meny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start_Game_Session;
        private System.Windows.Forms.Label lbl_Game_Title;
        private System.Windows.Forms.Label lblScoreboard;
        private System.Windows.Forms.ListBox lbxScoreboard;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnBossTest;
    }
}