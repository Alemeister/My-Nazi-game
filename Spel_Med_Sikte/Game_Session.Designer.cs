namespace Spel_Med_Sikte
{
    partial class Game_Session
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
            this.components = new System.ComponentModel.Container();
            this.timer_Creating_Enemies = new System.Windows.Forms.Timer(this.components);
            this.lbl_Nazi_Death_Count = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer_Creating_Enemies
            // 
            this.timer_Creating_Enemies.Tick += new System.EventHandler(this.timer_Creating_Enemies_Tick);
            // 
            // lbl_Nazi_Death_Count
            // 
            this.lbl_Nazi_Death_Count.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nazi_Death_Count.Location = new System.Drawing.Point(782, 15);
            this.lbl_Nazi_Death_Count.Name = "lbl_Nazi_Death_Count";
            this.lbl_Nazi_Death_Count.Size = new System.Drawing.Size(190, 40);
            this.lbl_Nazi_Death_Count.TabIndex = 0;
            this.lbl_Nazi_Death_Count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnQuit
            // 
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(12, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnQuit.Size = new System.Drawing.Size(143, 46);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblCountDown
            // 
            this.lblCountDown.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCountDown.Location = new System.Drawing.Point(724, 12);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(69, 42);
            this.lblCountDown.TabIndex = 2;
            this.lblCountDown.Text = "60";
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(516, 12);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(202, 42);
            this.lblTimeLeft.TabIndex = 3;
            this.lblTimeLeft.Text = "Time left:";
            this.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Game_Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lbl_Nazi_Death_Count);
            this.DoubleBuffered = true;
            this.Name = "Game_Session";
            this.Text = "Die Nazi, Die";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_Creating_Enemies;
        private System.Windows.Forms.Label lbl_Nazi_Death_Count;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label lblTimeLeft;
    }
}