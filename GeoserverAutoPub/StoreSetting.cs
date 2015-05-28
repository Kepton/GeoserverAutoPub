using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeoserverAutoPub
{
    public partial class StoreSetting : Form
    {
        public StoreSetting()
        {
            InitializeComponent();
        }

        private void StoreSetting_Load(object sender, EventArgs e)
        {
            if (SysParam.WordsSpaceSelected != null)
            {
                MessageBox.Show("请先选择工作区");
                return;

            }
        }
    }
}
