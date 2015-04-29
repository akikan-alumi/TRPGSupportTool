using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPGSupportTool {
    public partial class SubDisplay : Form {
        public SubDisplay() {
            InitializeComponent();
            int displayHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            int displayWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.StartPosition = FormStartPosition.Manual;
            this.DesktopLocation = new Point(displayHeight / 2, displayWidth / 6);
            this.TopMost = false;//
            this.ShowInTaskbar = false;// このフォームをタスクバーに表示しない
        }

        private void Form2_Load(object sender, EventArgs e) {
            
        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
