using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarControl
{
    public partial class CarControlForm
    {
        private void MoveUp()
        {
            tb_Log.AppendText("\r\n" + "^");
            bt_Up.Focus();
            _messenger.SendMessage("Up");
        }

        private void MoveDown()
        {
            tb_Log.AppendText("\r\n" + "\\/");
            bt_Down.Focus();
            _messenger.SendMessage("Down");
        }

        private void MoveLeft()
        {
            tb_Log.AppendText("\r\n" + "<--");
            bt_Left.Focus();
            _messenger.SendMessage("Left");
        }

        private void MoveRight()
        {
            tb_Log.AppendText("\r\n" + "-->");
            bt_Right.Focus();
            _messenger.SendMessage("Right");
        }

        private void Bt_Up_MouseDown(object sender, MouseEventArgs e)
        {
            MoveUp();
        }

        private void Bt_Down_MouseDown(object sender, MouseEventArgs e)
        {
            MoveDown();
        }

        private void Bt_Right_MouseDown(object sender, MouseEventArgs e)
        {
            MoveRight();
        }

        private void Bt_Left_MouseDown(object sender, MouseEventArgs e)
        {
            MoveLeft();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.W || keyData == Keys.Up)
            {
                // Handle key at form level.
                MoveUp();
                // Do not send event to focused control by returning true.
                return true;
            }
            if (keyData == Keys.S || keyData == Keys.Down)
            {
                MoveDown();
                return true;
            }
            if (keyData == Keys.A || keyData == Keys.Left)
            {
                MoveLeft();
                return true;
            }
            if (keyData == Keys.D || keyData == Keys.Right)
            {
                MoveRight();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
