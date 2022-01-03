using DienMayXanh_Store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DienMayXanh_Store.Views.Dialogs
{
    public partial class resetPassword : Form
    {
        private ContextDB context = Program.context;
        public resetPassword()
        {
            InitializeComponent();
        }

        private void resetPassword_Load(object sender, EventArgs e)
        {
            var list = context.STAFFS.AsEnumerable().Select(staff => new
            {
                StaffID = staff.StaffID,
                StaffName = staff.Name,
                StaffPosition = staff.Position,
                StaffPhone = staff.Phone,
            }).ToList();
            dgv_Staff.DataSource = list;
        }
    }
}
