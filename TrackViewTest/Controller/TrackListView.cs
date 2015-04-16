using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackViewTest.Model;


namespace TrackViewTest.Controller
{
    class TrackListView
    {
        private readonly DataService dataService;
        public List<Track> trackList;
        public Track selectedTrack;
        public Clip selectedClip;

        private Pen pLine = new Pen(Color.Gray);

        private float trackHeight = 50;
        private float trackPaddingTop = 2;
        private float trackPaddingBottom = 2;
        private float clipPadding = 8;

        public float XOffset = 0;
        public float YOffset = 0;

        private int xPos, yPos;
        
        public TrackListView()
        {
            dataService = new DataService();
            trackList = dataService.GetDummyTrackList();
        }

        public void AddTrack(Track track)
        {
            trackList.Add(track);
        }

        public void Draw(List<Track> trackList, Graphics g, Rectangle displayRect)
        {
            for (var i = 0; i < trackList.Count; i++)
            {
                var track = trackList[i];
                var top = i * trackHeight - YOffset;
                DrawTrackbar(g, track, displayRect, top);

                for (int j = 0; j < track.Clips.Count; j++)
                {
                    var clip = track.Clips[j];
                    DrawClip(g, clip, top);
                }
            }
        }

        private void DrawClip(Graphics g, Clip clip, float top)
        {
            var clipBrush = new SolidBrush(clip.BackColor);
            if (clip == selectedClip)
            {
                clipBrush.Color = Color.LightGray;
            }
            g.FillRectangle(clipBrush, clip.StartTick - XOffset, top + trackPaddingTop,
                clip.LengthTick, trackHeight - (trackPaddingTop + trackPaddingBottom));
            g.DrawString(clip.Name, SystemFonts.DefaultFont, Brushes.White, clip.StartTick + clipPadding - XOffset,
                top + trackPaddingTop + clipPadding);
        }

        private void DrawTrackbar(Graphics g, Track track, Rectangle displayRect, float top)
        {
            var trackBrush = new SolidBrush(Color.DimGray);
            if (track == selectedTrack)
            {
                trackBrush.Color = Color.LightPink;
            }
            g.FillRectangle(trackBrush, 0, top, displayRect.Width, trackHeight);
            g.DrawLine(Pens.Black, 0, top, displayRect.Width, top);
            g.DrawLine(Pens.Gray, 0, top + (trackHeight - 1), displayRect.Width, top + (trackHeight - 1));
        }

        private void FindTrack(Rectangle displayRect, MouseEventArgs e)
        {
            var imgAreas = new List<Rectangle>();
            for (int i = 0; i < trackList.Count; i++)
            {
                var track = trackList[i];
                var top = i * trackHeight - YOffset;

                imgAreas.Add(new Rectangle(0, (int)top, (int)displayRect.Width, (int)trackHeight));
                if (imgAreas[i].Contains(e.Location))
                {
                    selectedTrack = track;
                    return;
                }
            }
            selectedTrack = null;
        }

        public void FindSelectedObject(Rectangle displayRect, MouseEventArgs e)
        {
            var imgAreas = new List<Rectangle>();
            FindTrack(displayRect, e);
            if (selectedTrack == null)
            {
                selectedClip = null;
                return;
            }
            var top = selectedTrack.id  * trackHeight - YOffset;
            for (int i = 0; i < selectedTrack.Clips.Count; i++)
            {
                var clip = selectedTrack.Clips[i];

                imgAreas.Add(new Rectangle((int)(clip.StartTick - XOffset), (int)(top + trackPaddingTop),
                    (int)clip.LengthTick, (int)(trackHeight - (trackPaddingTop + trackPaddingBottom)) ));
                if (imgAreas[i].Contains(e.Location))
                {
                    selectedClip = clip;
                    return;
                }
            }
            selectedClip = null;
        }

        int selectedClipStartXPos;
        public void MouseDown(object sender, MouseEventArgs e)
        {
            var pb = (PictureBox)sender;
            FindSelectedObject(pb.DisplayRectangle, e);
            xPos = e.X; yPos = e.Y;
            if (selectedClip != null)
            {
                selectedClipStartXPos = selectedClip.StartTick;
            }
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            var pb = (PictureBox)sender;
            if (selectedClip != null)
            {
                selectedClip.StartTick = selectedClipStartXPos + (e.X - xPos);
                Console.Write("startTick: " + selectedClip.StartTick + " ");
                Console.Write("xPos: " + xPos + " ");
                Console.WriteLine("Moved: " + (e.X - xPos));
            }
            pb.Refresh();
        }
    }
}
