using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Text = "Simple WinForms App";
            this.Width = 400;
            this.Height = 200;

            var label = new Label
            {
                Text = "Hello, World!",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };

            this.Controls.Add(label);
        }
    }
}
