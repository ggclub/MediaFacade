using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackViewTest.Model
{
    class DataService
    {
        public List<Track> TrackList { get; set; }

        public List<Track> GetDummyTrackList()
        {
            var list = new List<Track>();

            list.Add(new Track(0, "Track 1"));
            list.Last().Clips.Add(new Clip("Clip 1", 0, 100) { BackColor = Color.Brown });
            list.Last().Clips.Add(new Clip("Clip 2", 200, 130) { BackColor = Color.Brown });

            list.Add(new Track(1, "Track 2"));
            list.Last().Clips.Add(new Clip("Clip 3", 100, 100) { BackColor = Color.OliveDrab });
            list.Last().Clips.Add(new Clip("Clip 4", 370, 150) { BackColor = Color.OliveDrab });

            list.Add(new Track(2, "Track 3"));
            list.Last().Clips.Add(new Clip("Clip 5", 10, 80) { BackColor = Color.Goldenrod });
            list.Last().Clips.Add(new Clip("Clip 6", 230, 100) { BackColor = Color.Goldenrod });
            list.Last().Clips.Add(new Clip("Clip 7", 400, 100) { BackColor = Color.Goldenrod });

            return list;
        }

        public void AddTrack(Track track)
        {
            TrackList.Add(track);
        }
    }
}
