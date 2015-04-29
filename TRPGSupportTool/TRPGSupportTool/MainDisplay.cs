using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPGSupportTool{
    public partial class MainDisplay : Form{
        public MainDisplay(){
            InitializeComponent();
            int displayHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            int displayWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.StartPosition = FormStartPosition.Manual;
            this.DesktopLocation = new Point(displayHeight/2,displayWidth/6);//なぜ縦の成分が6じゃないといけんのじゃ？
            
        }

        private void Form1_Load(object sender, EventArgs e){
            SubDisplay f2 = new SubDisplay();
            f2.Show();
        }

        // メッセージボックスで [いいえ] を選択した場合は、フォームが閉じられるのをキャンセル
        private void MainDisplay_FormClosing(object sender, FormClosingEventArgs e){
            if (MessageBox.Show("閉じますか?", "確認", MessageBoxButtons.YesNo) == DialogResult.No){
                e.Cancel = true;
            }
        }
    }
}
