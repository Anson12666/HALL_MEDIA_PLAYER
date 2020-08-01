namespace HALL_MEDIA_PLAYER
{
    partial class IntroPage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroPage));
            this.label1 = new System.Windows.Forms.Label();
            this.Start_Program_Btn = new System.Windows.Forms.Button();
            this.Check_Update_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Start_Program_Btn
            // 
            resources.ApplyResources(this.Start_Program_Btn, "Start_Program_Btn");
            this.Start_Program_Btn.Name = "Start_Program_Btn";
            this.Start_Program_Btn.UseVisualStyleBackColor = true;
            this.Start_Program_Btn.Click += new System.EventHandler(this.Start_Program_Btn_Click);
            // 
            // Check_Update_Btn
            // 
            resources.ApplyResources(this.Check_Update_Btn, "Check_Update_Btn");
            this.Check_Update_Btn.Name = "Check_Update_Btn";
            this.Check_Update_Btn.UseVisualStyleBackColor = true;
            this.Check_Update_Btn.Click += new System.EventHandler(this.Check_Update_Btn_Click);
            // 
            // IntroPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Check_Update_Btn);
            this.Controls.Add(this.Start_Program_Btn);
            this.Controls.Add(this.label1);
            this.Name = "IntroPage";
            this.Load += new System.EventHandler(this.IntroPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start_Program_Btn;
        private System.Windows.Forms.Button Check_Update_Btn;
    }
}

