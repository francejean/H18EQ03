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
    public partial class ButtonChangeDiscard : Button
    {
        public ButtonChangeDiscard()
        {
            InitializeComponent();

            BackgroundImage = global::Prj_Object.Properties.Resources.DiscardIcon1;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Size = new System.Drawing.Size(75, 75);
            UseVisualStyleBackColor = true;
            Text = "";
        }
    }
}
