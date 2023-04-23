using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// モードレスフォームとして開く
        /// フォームを開いたままでも他のフォームを操作することができるフォーム
        /// 
        /// 親フォームの中心に表示したい場合は、Form2の「StartPotion」プロパティをManualに変更する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Modeless_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Left = this.Left + (this.Width - form2.Width) / 2;
            form2.Top = this.Top + (this.Height - form2.Height) / 2;

            //モードレスフォーム
            form2.Show();
        }

        /// <summary>
        /// モーダルフォームとして開く
        /// 開いたフォームを閉じるまでは、他のフォームを操作することができないフォーム
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Modal_button_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            //親フォームの中心に表示
            form3.StartPosition = FormStartPosition.CenterParent;

            //モーダルフォーム
            form3.ShowDialog(this);
            form3.Dispose();
        }
    }
}
