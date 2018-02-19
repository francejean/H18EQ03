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
    public partial class ButtonText : System.Windows.Forms.Button
    {
        public ButtonText()
        {
            InitializeComponent();

            Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Location = new System.Drawing.Point(12, 12);
            Size = new System.Drawing.Size(96, 30);
            UseVisualStyleBackColor = true;
        }
    }
}
