using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_Topicos
{
    public class SCmb: ComboBox
    {
        public string PlaceHolder = "USER";
        public Color AlterColor = Color.DimGray;
        public Color NormalColor = Color.LightGray;
        public SCmb()
        {
            ForeColor = AlterColor;
            Text = PlaceHolder;
            ForeColor = AlterColor;
            Font = new Font("Century Gothic", 12, FontStyle.Regular);
            MouseEnter += new EventHandler(EventMouseEnter);
            MouseLeave += new EventHandler(EventMouseLeave);
        }

        private void EventMouseEnter(object sender, EventArgs e)
        {
            if (Text == PlaceHolder)
            {
                Text = "";
                ForeColor = AlterColor;
            }
        }

        private void EventMouseLeave(object sender, EventArgs e)
        {
            if (Text == "")
            {
                Text = PlaceHolder;
                ForeColor = AlterColor;
            }
        }

    }
}
