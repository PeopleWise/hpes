using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HPES.DBClass;
using System.Data.SqlClient;
namespace HPES.Formview.Userview
{
    public partial class FrmUserManage : Form
    {
        public FrmUserManage()
        {
            InitializeComponent();
        }
        
        DBOperate operate = new DBOperate();//创建数据库操作对象
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void FrmUserManage_Load(object sender, EventArgs e)
        {
            string getUser =//创建SQL字符串
                "select name as 用户名,password as 密码,userauth as 权限 from  HPES_user";
            operate.BindDataGridView(dataGridView1,getUser);//绑定到DataGridView控件
            dataGridView1.Columns[0].Width = 88;//设置列宽度
            dataGridView1.Columns[1].Width = 85;//设置列宽度
            dataGridView1.Columns[2].Width = 88;//设置列宽度
            comboBox1.SelectedIndex = 0;//设置默认选择项
        }
	
        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                txtOUser.Enabled = true;//启用文本框控件
                txtOPwd.Enabled = true;//启用文本框控件
                comboBox1.Enabled = true;//启用ComboBox控件

                SqlConnection conn = DBClass.DBConnection.MyConnection();

                conn.Open();//连接到SQL数据库

                string str = "select * from HPES_user where name='" + txtOUser.Text.Trim() + "'"; ;//创建SQL字符串

                SqlCommand cmd = new SqlCommand(str,conn);

                SqlDataReader sdr = cmd.ExecuteReader();//得到数据读取器对象

                sdr.Read();//读取一条记录       

                if (sdr.HasRows)//判断是否包含数据
                
                {
                    MessageBox.Show("操作员存在！", "提示",//弹出消息对话框
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//退出事件
                }
                else
                {
                    if (txtOUser.Text.Trim() == "" || txtOPwd.Text.Trim() == "")
                    {
                        MessageBox.Show("信息不完整！", "提示",//弹出消息对话框
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;//退出事件
                    }
                    else
                    {
                        string InsertSql =//创建SQL字符串
                            "insert into HPES_user(id,name,password,userauth) values(HPES_user_sequence.nextval,'" + txtOUser.Text.Trim() + "','" + txtOPwd.Text.Trim() + "','" + comboBox1.Text + "')";
                        operate.OperateData(InsertSql);//向数据库中插入数据
                        txtOPwd.Text = "";//清空文本内容
                        txtOUser.Text = "";//清空文本内容
                        MessageBox.Show("增加用户成功！", "提示",//弹出消息对话框
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch
            {
                MessageBox.Show("增加操作员失败！","提示",//弹出消息对话框
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name=dataGridView1.SelectedCells[0].Value.ToString();//得到用户名
            string str =//创建SQL字符串
                "select * from HPES_user where name='"+name+"'";
            DataSet ds = operate.GetTable(str);//得到数据集
            ds.Dispose();//释放资源
            txtOUser.Text = ds.Tables[0].Rows[0][1].ToString();//得到用户名
            txtOPwd.Text = ds.Tables[0].Rows[0][2].ToString();//得到密码
            comboBox1.SelectedItem = ds.Tables[0].Rows[0][3].ToString();//设置选择项
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("请选择要删除的管理员", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                string username = dataGridView1.SelectedCells[0].Value.ToString();//得到用户名
                string strsql =//创建SQL字符串
                    "delete from HPES_user where name='"+username+"'";
                operate.OperateData(strsql);//删除数据库中指定记录
                MessageBox.Show("删除成功！", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmUserManage_Activated(object sender, EventArgs e)
        {
            FrmUserManage_Load(sender, e);//执行窗体Load事件
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtOUser.Text.Trim() == "" || txtOPwd.Text.Trim() == "")
            {
                MessageBox.Show("信息不完整！", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                string str =//创建SQL字符串对象
                    "select count(*) from HPES_user where name='" + txtOUser.Text.Trim() + "'";
                int i = operate.HumanNum(str);//创建记录数量
                if (i > 0)
                {
                    string updatestr =//创建SQL字符串
                        "update HPES_user set password='" + txtOPwd.Text.Trim() + "',userauth='" + comboBox1.Text + "' where name='" + txtOUser.Text.Trim() + "'";
                    operate.OperateData(updatestr);//更新数据库信息
                    MessageBox.Show("信息修改成功！", "提示",//弹出消息对话框
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOPwd.Text = "";//清除文本内容
                    txtOUser.Text = "";//清除文本内容
                }
                else
                {
                    MessageBox.Show("指定用户不存在！", "提示",//弹出消息对话框
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


       
    }
}