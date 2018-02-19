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
    public partial class LabelInfo : Label
    {
        public LabelInfo()
        {
            InitializeComponent();

            AutoSize = true;
            Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Location = new System.Drawing.Point(12, 107);
            Size = new System.Drawing.Size(44, 18);
        }
    }
}
