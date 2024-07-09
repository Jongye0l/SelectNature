using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 자연선1택
{
    internal class Space
    {
        public Label Label;
        public int RandX;
        public int RandY;
        public int RandLocX;
        public int RandLocY;

        public Space(Label label)
        {
            Label = label;
        }

        public void SetLocRand()
        {
            Label.Location = new Point(RandX + RandLocX, RandY + RandLocY);
        }

        public void AddLockRand()
        {
            int x = RandLocX + Label.Location.X;
            int y = RandLocY + Label.Location.Y;
            Label.Location = new Point(x, y);
        }

    }
}
