using EBK_EXAM_C_26.Models;

namespace EBK_EXAM_C_26
{
    public partial class LoginForm : Form
    {
        public static LoginForm Instanse;
        public static User User { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            Instanse = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (KbkExamC26Context db = new KbkExamC26Context())
            {
                User user = db.Users.FirstOrDefault(p => p.Login == textBoxLogin.Text && p.Password == textBoxPassword.Text)!;

                if (user != null)
                {
                    User = user;
                    Main mainForm = new Main();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль :(");
                }
            }
        }
    }
}
