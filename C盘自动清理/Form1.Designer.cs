
namespace C盘自动清理
{
    partial class F_Main
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
            this.B_Start = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.T_Show = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_Start
            // 
            this.B_Start.Location = new System.Drawing.Point(110, 233);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(271, 69);
            this.B_Start.TabIndex = 0;
            this.B_Start.Text = "启动";
            this.B_Start.UseVisualStyleBackColor = true;
            this.B_Start.Click += new System.EventHandler(this.B_Start_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(110, 190);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(271, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // T_Show
            // 
            this.T_Show.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.T_Show.Location = new System.Drawing.Point(110, 308);
            this.T_Show.Multiline = true;
            this.T_Show.Name = "T_Show";
            this.T_Show.Size = new System.Drawing.Size(271, 118);
            this.T_Show.TabIndex = 2;
            this.T_Show.TextChanged += new System.EventHandler(this.T_Show_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(146, 104);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(197, 33);
            this.label.TabIndex = 3;
            this.label.Text = "C盘清理工具";
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.T_Show);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.B_Start);
            this.Name = "F_Main";
            this.Text = "C盘清理工具";
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox T_Show;
        private System.Windows.Forms.Label label;
    }
}

