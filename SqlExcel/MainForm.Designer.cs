namespace SqlExcel
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtInFile = new System.Windows.Forms.TextBox();
            this.btnInFile = new System.Windows.Forms.Button();
            this.lbSql = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.tabResult = new System.Windows.Forms.TabControl();
            this.tPageResultInfo = new System.Windows.Forms.TabPage();
            this.txtResultInfo = new System.Windows.Forms.TextBox();
            this.tPageResult = new System.Windows.Forms.TabPage();
            this.gvResult = new System.Windows.Forms.DataGridView();
            this.tabResult.SuspendLayout();
            this.tPageResultInfo.SuspendLayout();
            this.tPageResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInFile
            // 
            this.txtInFile.Location = new System.Drawing.Point(108, 9);
            this.txtInFile.Name = "txtInFile";
            this.txtInFile.ReadOnly = true;
            this.txtInFile.Size = new System.Drawing.Size(464, 21);
            this.txtInFile.TabIndex = 1;
            // 
            // btnInFile
            // 
            this.btnInFile.Location = new System.Drawing.Point(12, 7);
            this.btnInFile.Name = "btnInFile";
            this.btnInFile.Size = new System.Drawing.Size(90, 23);
            this.btnInFile.TabIndex = 2;
            this.btnInFile.Text = "输入文件...";
            this.btnInFile.UseVisualStyleBackColor = true;
            this.btnInFile.Click += new System.EventHandler(this.btnInFile_Click);
            // 
            // lbSql
            // 
            this.lbSql.AutoSize = true;
            this.lbSql.Location = new System.Drawing.Point(43, 36);
            this.lbSql.Name = "lbSql";
            this.lbSql.Size = new System.Drawing.Size(59, 12);
            this.lbSql.TabIndex = 4;
            this.lbSql.Text = "Sql语句：";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(27, 116);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "执行Sql...";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtSql
            // 
            this.txtSql.Location = new System.Drawing.Point(108, 36);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(464, 103);
            this.txtSql.TabIndex = 6;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(61, 145);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(41, 12);
            this.lbResult.TabIndex = 7;
            this.lbResult.Text = "结果：";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(27, 357);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "导出...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.tPageResultInfo);
            this.tabResult.Controls.Add(this.tPageResult);
            this.tabResult.Font = new System.Drawing.Font("宋体", 9F);
            this.tabResult.Location = new System.Drawing.Point(108, 145);
            this.tabResult.Name = "tabResult";
            this.tabResult.Padding = new System.Drawing.Point(6, 4);
            this.tabResult.SelectedIndex = 0;
            this.tabResult.Size = new System.Drawing.Size(464, 235);
            this.tabResult.TabIndex = 10;
            // 
            // tPageResultInfo
            // 
            this.tPageResultInfo.Controls.Add(this.txtResultInfo);
            this.tPageResultInfo.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tPageResultInfo.Location = new System.Drawing.Point(4, 24);
            this.tPageResultInfo.Name = "tPageResultInfo";
            this.tPageResultInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tPageResultInfo.Size = new System.Drawing.Size(456, 207);
            this.tPageResultInfo.TabIndex = 0;
            this.tPageResultInfo.Text = "信息";
            this.tPageResultInfo.UseVisualStyleBackColor = true;
            // 
            // txtResultInfo
            // 
            this.txtResultInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtResultInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultInfo.Location = new System.Drawing.Point(0, 0);
            this.txtResultInfo.Multiline = true;
            this.txtResultInfo.Name = "txtResultInfo";
            this.txtResultInfo.ReadOnly = true;
            this.txtResultInfo.Size = new System.Drawing.Size(456, 207);
            this.txtResultInfo.TabIndex = 0;
            // 
            // tPageResult
            // 
            this.tPageResult.Controls.Add(this.gvResult);
            this.tPageResult.Location = new System.Drawing.Point(4, 24);
            this.tPageResult.Name = "tPageResult";
            this.tPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tPageResult.Size = new System.Drawing.Size(456, 207);
            this.tPageResult.TabIndex = 1;
            this.tPageResult.Text = "结果";
            this.tPageResult.UseVisualStyleBackColor = true;
            // 
            // gvResult
            // 
            this.gvResult.AllowUserToAddRows = false;
            this.gvResult.AllowUserToDeleteRows = false;
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResult.Location = new System.Drawing.Point(0, 0);
            this.gvResult.Name = "gvResult";
            this.gvResult.ReadOnly = true;
            this.gvResult.RowTemplate.Height = 23;
            this.gvResult.Size = new System.Drawing.Size(456, 209);
            this.gvResult.TabIndex = 9;
            this.gvResult.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gvResult_RowPostPaint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 392);
            this.Controls.Add(this.tabResult);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lbSql);
            this.Controls.Add(this.btnInFile);
            this.Controls.Add(this.txtInFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SqlExcel  (网址：http://hanzhaoxin.cnblogs.com)";
            this.tabResult.ResumeLayout(false);
            this.tPageResultInfo.ResumeLayout(false);
            this.tPageResultInfo.PerformLayout();
            this.tPageResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInFile;
        private System.Windows.Forms.Button btnInFile;
        private System.Windows.Forms.Label lbSql;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TabPage tPageResultInfo;
        private System.Windows.Forms.TabPage tPageResult;
        private System.Windows.Forms.DataGridView gvResult;
        private System.Windows.Forms.TabControl tabResult;
        private System.Windows.Forms.TextBox txtResultInfo;
    }
}

