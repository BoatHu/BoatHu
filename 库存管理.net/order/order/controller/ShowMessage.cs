using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace order.controller
{
    class ShowMessage
    {
        //根据信息类型弹出对应的对话框
        public static void showMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
