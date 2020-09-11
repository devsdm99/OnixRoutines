using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnixLibrary.CustomControls
{
    public partial class ItemsCombo : ComboBox
    {
        public ItemsCombo()
        {
            InitializeComponent();
        }
        public int Id { get; set; }
        public string Texto { get; set; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

    }
}
