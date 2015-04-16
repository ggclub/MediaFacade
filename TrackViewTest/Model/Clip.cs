using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackViewTest.Model
{
    class Clip
    {
        public int StartTick { get; set; }
        public int LengthTick { get; set; }
        public Color BackColor = Color.CornflowerBlue;

        public string Name { get; private set; }
        public object EndTick { get { return StartTick + LengthTick; } }

        public Clip(string name)
        {
            this.Name = name;
        }

        public Clip(string name, int lengthTick)
        {
            this.Name = name;
            this.LengthTick = lengthTick;
        }

        public Clip(string name, int startTick, int lengthTick)
        {
            this.Name = name;
            this.StartTick = startTick;
            this.LengthTick = lengthTick;
        }


        
    }
}
