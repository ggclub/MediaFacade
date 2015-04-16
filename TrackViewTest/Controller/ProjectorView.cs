using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using TrackViewTest.Model;

namespace TrackViewTest.Controller
{
    class ProjectorView
    {
        public List<Track> trackList;
        private Pen layoutPen = new Pen(Color.ForestGreen, 2f);
        private Color[] eColor = new Color[] { Color.LightGreen, Color.LightSeaGreen, Color.Green, Color.DarkSeaGreen };
        private int count = 0;
        
        
        public void DrawLayout(PictureBox pb, List<Projector> projectorList, Graphics g)
        {
            Rectangle newRect;
            var netCount = projectorList.Count; 
            var prjSize = new Size(200, 200);
            var prjLoca = new Point();
            int startX=50, startY=50;
            int prjMargin = -30;
            int colCount = (pb.Width - (startX + prjSize.Width)) / (prjSize.Width + prjMargin) + 1;
            int rowCount = (netCount - 1) % colCount + 1;
            int x=0, y=0;

            for (int i = 0; i < netCount; i++)  
            {
                x = i % rowCount;
                y = i / colCount;
                        prjLoca.X = startX + x * (prjSize.Width + prjMargin);
                        prjLoca.Y = startY + y * (prjSize.Height + prjMargin);
                        newRect = new Rectangle(prjLoca, prjSize);
                        layoutPen.Color = eColor[i % 4]; 
                        g.DrawRectangle(layoutPen, newRect);
            
            }
        }
    }
}
