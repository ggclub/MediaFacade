using System.Collections.Generic;

namespace TrackViewTest.Model
{
    class Track
    {
        public int id { get; private set; }
        public string Name { get; private set; }
        public List<Projector> projectorList { get; private set; }
        public List<Clip> Clips { get; private set; }

        public Track(int id, string name)
        {
            this.id = id;
            this.Name = name;
            this.projectorList = new List<Projector>();
            this.Clips = new List<Clip>();
        }
    }
}
