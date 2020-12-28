using System.Drawing;

namespace Saver
{
    public struct Theme
    {
        public Color ForeColor;
        public Color BackColorFirst;
        public Color BackColorSecond;
        public Color BackColorThree;

        public Theme(Themes themes)
        {
            if (themes == Themes.Dark)
            {
                ForeColor = Color.FromArgb(0, 0, 0);
                BackColorFirst = Color.FromArgb(192, 192, 192);
                BackColorSecond = Color.FromArgb(100, 100, 100);
                BackColorThree = Color.FromArgb(255, 255, 255);
            }
            else
            {
                ForeColor = Color.FromArgb(240, 240, 240);
                BackColorFirst =  Color.FromArgb(51, 51, 76);
                BackColorSecond = Color.FromArgb(153, 180, 209);
                BackColorThree = Color.FromArgb(51, 51, 60);
            }
        }
    }
}
