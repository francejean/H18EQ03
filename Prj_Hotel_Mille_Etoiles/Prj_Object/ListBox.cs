using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_Object
{
    public partial class ListBox : System.Windows.Forms.ListBox
    {
        public ListBox()
        {
            InitializeComponent();

            Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            FormattingEnabled = true;
            MultiColumn = true;
            Size = new System.Drawing.Size(120, 94);
        }
    }
}
