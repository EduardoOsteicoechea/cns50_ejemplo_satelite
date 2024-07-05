using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSatelite.Sage50.AvantLeap.Styles
{
    internal class EOStyles
    {
        public static Rectangle ScreenRectangle = System.Windows.Forms.Screen.GetBounds(new Point());
        public static int ScreenWidth = ScreenRectangle.Width;
        public static int ScreenHeight = ScreenRectangle.Height;
        public static int FormWidth = Convert.ToInt32(Math.Round((double)(ScreenRectangle.Width * .27)));
        public static int FormHeight = Convert.ToInt32(Math.Round((double)(ScreenRectangle.Height * .8)));
        public static int ControlFullWidth = Convert.ToInt32(Math.Round((double)(EOStyles.FormWidth * .65)));
        public static int ControlLineHeight = 20;
        public static int VerticalGap5 = 20;
        public static int VerticalGap6 = 25;
        public static int VerticalGap7 = 30;
        public static int VerticalGap8 = 35;
        public static int VerticalGap9 = 40;
        public static int NextControlGap = 45;
        public static int SiblingControlGapFromLabel = 20;
        public static int VerticalGap10 = 45;
        public static int Column1Left = Convert.ToInt32(Math.Round((double)(ScreenRectangle.Width * .01)));
        public static int Row1Top = Convert.ToInt32(Math.Round((double)(ScreenRectangle.Height * .01)));
        public static int Row2Top = Convert.ToInt32(Math.Round((double)(ScreenRectangle.Height * .09)));
        public static Font GlobalFont = new Font("Helvetica", 10, FontStyle.Regular);
        public static Font GlobalFont2 = new Font("Helvetica", 11, FontStyle.Regular);
        public static Font GlobalFont3 = new Font("Helvetica", 12, FontStyle.Regular);
        public static Font GlobalFont4 = new Font("Helvetica", 13, FontStyle.Regular);
        public static Font GlobalFont5 = new Font("Helvetica", 14, FontStyle.Regular);
        public static Color c_transparent = Color.FromArgb(0, 255,255,255);
        public static Color c_white = Color.FromArgb(255, 255,255,255);
        public static Color c_gray_253 = Color.FromArgb(255, 253,253,253);
        public static Color c_gray_252 = Color.FromArgb(255, 252,252,252);
        public static Color c_gray_250 = Color.FromArgb(255, 250,250,250);
        public static Color c_gray_242 = Color.FromArgb(255, 244,244,244);
        public static Color c_gray_240 = Color.FromArgb(255, 240,240,240);
        public static Color c_gray_230 = Color.FromArgb(255, 230,230,230);
        public static Color c_gray_200 = Color.FromArgb(255, 200,200,200);
        public static Color c_gray_100 = Color.FromArgb(255, 150,150,150);
        public static Color c_gray_75 = Color.FromArgb(255, 75,75,75);
        public static Color c_blue_1 = Color.FromArgb(255, 6, 124, 252);

    }
}
