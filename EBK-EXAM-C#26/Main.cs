using EBK_EXAM_C_26.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EBK_EXAM_C_26
{
    public partial class Main : Form
    {
        private List<Product> list;
        public Main()
        {
            InitializeComponent();
            labelUser.Text = LoginForm.User.SurName + " " + LoginForm.User.FirstName.Substring(0, 1) + "." + LoginForm.User.LastName.Substring(0, 1);
            using (KbkExamC26Context db = new KbkExamC26Context())
            {
                list = db.Products.ToList();
                updateForm(list);
            }
        }

        public void updateForm(List<Product> list)
        {
            panel1.Controls.Clear();
            int y = 0;
            foreach (Product product in list)
            {
                TovarControll tc = new TovarControll(product, this);
                tc.Top = y;
                panel1.Controls.Add(tc);
                y += tc.Height;
            }
        }
    }
}
