using DienMayXanh_Store.Models;
using DienMayXanh_Store.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DienMayXanh_Store.Views
{
    public partial class formStaff : Form
    {
        private ContextDB context = Program.context;
        public static formStaff instance;
        public formStaff()
        {
            InitializeComponent();
            instance = this;
        }
        private void reloadForm()
        {
            STAFF me = FormLogin.instance.info;
            if (me.Position.Equals("Quản Lý"))
            {
                ManagerGroup.Visible = true;
                dgv_listStaff.Columns["btn_Del"].Visible = true;
            }
            else
            {
                ManagerGroup.Visible = false;
                dgv_listStaff.Columns["btn_Del"].Visible = false;
            }

            tb_StaffID.Text = me.StaffID;
            tb_StaffName.Text = me.Name;
            tb_StaffPhone.Text = me.Phone;
            tb_StaffAddress.Text = me.Address;
            cb_StaffGender.SelectedIndex = me.Gender ? 1 : 0;
            btn_Confirm.Visible = false;
            var staffs = context.STAFFS.AsEnumerable().Select(staff => new
            {
                StaffAvatar = staff.Avatar,
                StaffName = staff.Name,
                StaffID = staff.StaffID,
                StaffPosition = staff.Position,
                StaffGender = staff.Gender ? "Nam" : "Nữ",
                StaffPhone = staff.Phone,
                StaffAddress = staff.Address,
            }).ToList();
            dgv_listStaff.DataSource = staffs;
        }
        private void formStaff_Load(object sender, EventArgs e)
        {
            reloadForm();
        }
        private void tb_switchStatus()
        {
            cb_StaffGender.Enabled = !cb_StaffGender.Enabled;
            tb_StaffName.Enabled = !tb_StaffName.Enabled;
            tb_StaffPhone.Enabled = !tb_StaffPhone.Enabled;
            tb_StaffAddress.Enabled = !tb_StaffAddress.Enabled;
        }
        private void btn_printListStaff_Click(object sender, EventArgs e)
        {
            Report.PrintReports report = new Report.PrintReports();
            report.printListStaff();
            report.Show();
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            Dialogs.addNewStaff frm = new Dialogs.addNewStaff();
            frm.ShowDialog();
        }

        private void btn_EditInfo_Click(object sender, EventArgs e)
        {
            tb_switchStatus();
            btn_EditInfo.Enabled = false;
            btn_Confirm.Visible = true;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            var staff = context.STAFFS.Find(tb_StaffID.Text);
            staff.Name = tb_StaffName.Text;
            staff.Phone = tb_StaffPhone.Text;
            staff.Address = tb_StaffAddress.Text;
            staff.Gender = cb_StaffGender.SelectedIndex == 1 ? true : false;
            try
            {
                context.SaveChanges();
                MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadForm();
                btn_EditInfo.Enabled = true;
                tb_switchStatus();
            }catch(Exception exp)
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(exp.Message);
            }
            
        }

        private void btn_EditPassword_Click(object sender, EventArgs e)
        {
            Dialogs.EditPassword frm = new Dialogs.EditPassword();
            frm.ShowDialog();
        }

        private void btn_delStaff_click(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            string staffID = dgv_listStaff.Rows[e.RowIndex].Cells["StaffID"].Value.ToString();

            if (dataGridView.Columns[e.ColumnIndex].Name.Equals("btnStatistical")
                && dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                new FormStatistical(staffID).ShowDialog();
                return;
            }    

            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if(staffID == FormLogin.instance.info.StaffID)
                {
                    MessageBox.Show("Mày Bị Điên Hay Sao Mà Đi Đuổi Việc Chính Mình?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    var staff = context.STAFFS.Find(staffID);
                    var account = context.ACCOUNTS.Find(staffID);
                    if (MessageBox.Show("Bạn Có Chắc Là Muốn Đuổi Việc Thằng: " + staff.Name + " Không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.STAFFS.Remove(staff);
                        context.ACCOUNTS.Remove(account);
                        context.SaveChanges();
                        MessageBox.Show("Bạn Đã Đuổi Việc Nhân Viên: " + staff.Name, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        reloadForm();
                    }

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_resetPassword_Click(object sender, EventArgs e)
        {
            Dialogs.resetPassword frm = new Dialogs.resetPassword();
            frm.ShowDialog();
        }
    }
}
