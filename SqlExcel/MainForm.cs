using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace SqlExcel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 输入文件选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "Excel 2003文件|*.xls|Excel 2007文件|*.xlsx";
            if (DialogResult.OK.Equals(openFileDlg.ShowDialog()))
            {
                txtInFile.Text = openFileDlg.FileName;
            }

        }
        /// <summary>
        /// 执行Sql...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInFile.Text.Trim()))
            {
                MessageBox.Show("请选择输入文件！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtSql.Text.Trim()))
            {
                MessageBox.Show("请输入Sql语句！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int linesNum = 0;
            double executionTime = 0.0;
            string resultInfo = string.Empty;
            DataTable dtResult = null;
            tabResult.SelectedTab = tPageResultInfo;
            try
            {
                if (txtSql.Text.ToLower().StartsWith("select"))
                {
                    executionTime = CodeTimer.ExecuteCode(delegate()
                    {
                        dtResult = SqlHelper.ExecuteDataTable(txtInFile.Text, txtSql.Text);
                    });
                    tabResult.SelectedTab = tPageResult;
                }
                else
                {
                    executionTime = CodeTimer.ExecuteCode(delegate()
                    {
                        linesNum = SqlHelper.ExecuteNonQuery(txtInFile.Text, txtSql.Text);
                    });
                }
                resultInfo = FormatResultInfo(txtSql.Text, linesNum, executionTime);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("未在本地计算机上注册“Microsoft.Ace.OLEDB.12.0”提供程序。"))
                {
                    MessageBox.Show("本程序运行需安装：AccessDatabaseEngine，\r\n请安装后重试！", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ex is DbException)
                {
                    MessageBox.Show(string.Format("Sql语句错误：“{0}”", ex.Message), "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Format("发生未处理错误，请联系作者！\r\n错误信息：“{0}”", ex.Message), "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                resultInfo = FormatResultInfo(txtSql.Text, ex.Message);
            }
            finally
            {
                gvResult.DataSource = dtResult;
                txtResultInfo.Text = resultInfo;
            }
        }
        /// <summary>
        /// 到处结果数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = gvResult.DataSource as DataTable;
            if (null == dt)
            {
                MessageBox.Show("无操作结果！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.Filter = "Excel 2003文件|*.xls|Excel 2007文件|*.xlsx";
            if (DialogResult.OK.Equals(saveFileDlg.ShowDialog()))
            {
                try
                {
                    ExcelHelper.DataTableToExcel(dt, "result", saveFileDlg.FileName);
                    MessageBox.Show("导出成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("导出失败，原因：“{0}”", ex.Message), "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //显示行号
        private void gvResult_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                gvResult.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                gvResult.RowHeadersDefaultCellStyle.Font,
                rectangle,
                gvResult.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        #region 格式化Sql执行结果信息
        private string FormatResultInfo(string sql, int linesNum, double executionTime)
        {
            return string.Format("[SQL]{0}\r\n受影响的行: {1}\r\n时间: {2}ms\r\n", sql, linesNum, executionTime);
        }
        private string FormatResultInfo(string sql, string errorInfo)
        {
            return string.Format("[SQL]{0}\r\n[Err]{1}", sql, errorInfo);
        }
        #endregion
    }
}
