using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "new text";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Label l = new Label();
            l.Text = "btn2 pressed";
            i++;
            l.Name = "lbl"+i;
            l.Location = new Point(r.Next(Form1.ActiveForm.Width - 50), r.Next(Form1.ActiveForm.Height - 20));
            Controls.Add(l);
            this.Refresh();
        }
    }
}
