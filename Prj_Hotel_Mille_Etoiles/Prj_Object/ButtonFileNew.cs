﻿using System;
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
    public partial class ButtonFileNew : Button
    {
        public ButtonFileNew()
        {
            InitializeComponent();

            BackgroundImage = global::Prj_Object.Properties.Resources.NewFileIcon2;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Size = new System.Drawing.Size(75, 75);
            UseVisualStyleBackColor = true;
            Text = "";
        }
    }
}
