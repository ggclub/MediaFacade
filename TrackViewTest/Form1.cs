using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TrackViewTest.Controller;
using TrackViewTest.Model;

namespace TrackViewTest
{
    public partial class Form1 : Form
    {
        private readonly TrackListView trackListView = new TrackListView();
        private readonly ProjectorView projectorView = new ProjectorView();
        private bool Dragging = false;

        private TreeNode selectedNode;

        public Form1()
        {
            InitializeComponent();
            UpdateTreeView(trackListView.trackList);
            UpdatePrjTreeView(trackListView.trackList);
        }

        private void UpdateTreeView(List<Track> trackList)
        {
            var trackTreeNodes = new List<TreeNode>();

            foreach (var track in trackList)
            {
                var node = new TreeNode(track.Name);
                foreach (var clip in track.Clips)
                {
                    node.Nodes.Add(String.Format("{0} ({1} ~ {2})", clip.Name, clip.StartTick, clip.EndTick));
                }

                trackTreeNodes.Add(node);
            }

            treeView1.Nodes.Clear();
            treeView1.Nodes.AddRange(trackTreeNodes.ToArray());
            treeView1.ExpandAll();
        }

        private void UpdatePrjTreeView(List<Track> trackList)
        {
            var prjTreeNodes = new List<TreeNode>();

            foreach (var track in trackList)
            {
                var node = new TreeNode(track.Name);
                foreach (var prj in track.projectorList)
                {
                    TreeNode prjNode = new TreeNode(prj.Name);
                    node.Nodes.Add(prjNode);    
                }
                prjTreeNodes.Add(node);
            }
           

            tv_Projector.Nodes.Clear();
            tv_Projector.Nodes.AddRange(prjTreeNodes.ToArray());
            tv_Projector.ExpandAll();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Console.WriteLine("pb Paint");
            var trackList = trackListView.trackList;

            var pb = (PictureBox) sender;
            var g = e.Graphics;

            trackListView.Draw(trackList, g, pb.DisplayRectangle);
        }

        private void btn_AddTrak_Click(object sender, EventArgs e)
        {
            int id = trackListView.trackList.Count;
            var track = new Track(id, "Track new");
            track.Clips.Add(new Clip("new Clip", 270, 220) {BackColor = Color.Red});

            trackListView.AddTrack(track);

            UpdateTreeView(trackListView.trackList);
            UpdatePrjTreeView(trackListView.trackList);
            pictureBox1.Invalidate();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            var v = e.NewValue;
            trackListView.XOffset = v*2;
            pictureBox1.Invalidate();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            var v = e.NewValue;
            trackListView.YOffset = v * 2;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("pb Click");
            var em = (MouseEventArgs)e;
            var trackList = trackListView.trackList;
            var pb = (PictureBox)sender;
            var ev = (MouseEventArgs)e;
            lbl_ClickResult.Text = em.Location.ToString();

            //trackListView.FindSelectedObject(pb.DisplayRectangle, ev);
            LabelSelectedObject();
            pictureBox1.Invalidate();
        }

        private void LabelSelectedObject()
        {
            if (trackListView.selectedTrack == null)
            {
                if (trackListView.selectedClip != null)
                    lbl_ClickResult.Text = trackListView.selectedClip.Name;
                else
                    lbl_ClickResult.Text = null;
            }
            else
            {
                lbl_ClickResult.Text = trackListView.selectedTrack.Name;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Dragging = true;
                trackListView.MouseDown(sender, e);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                trackListView.MouseMove(sender, e);
                UpdateTreeView(trackListView.trackList);
                lbl_Loca.Text = e.Location.ToString();
            }
        }


        private void pbProjector_Paint(object sender, PaintEventArgs e)
        {
            var pb = (PictureBox)sender;
            var g = e.Graphics;
            string node;
            try{
                node = selectedNode.Text;
            }
            catch(Exception ex){
                node = "Track 1"; 
            }
                
            for(int i = 0; i < trackListView.trackList.Count; i++) {
                if (node.Equals(trackListView.trackList[i].Name)){
                    trackListView.selectedTrack = trackListView.trackList[i];
                }
            }
            var prjList = trackListView.selectedTrack.projectorList;
            projectorView.DrawLayout(pb, prjList, g);
        }

        private void tv_Projector_MouseUp(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            TreeNode node = tv_Projector.GetNodeAt(p);
            if (e.Button == MouseButtons.Right)
            {
                if (node != null)
                {
                    tv_Projector.SelectedNode = selectedNode = node;
                    var lNode = node.Text.ToLower();
                    if(lNode.Contains("track")){
                        cms_tvTrack.Show(tv_Projector, p);
                    }
                    else if (lNode.Contains("projector"))
                    {
                        cms_tvPrj.Show(tv_Projector, p);
                    }
                       
                }
            }
            else
            {
                tv_Projector.SelectedNode = selectedNode = node;
                pbProjector.Invalidate();
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = selectedNode.Text;
            for(int i = 0; i < trackListView.trackList.Count; i++) {
                if (node.Equals(trackListView.trackList[i].Name)){
                    trackListView.selectedTrack = trackListView.trackList[i];
                }
            }
            var prjList = trackListView.selectedTrack.projectorList;
            var id = prjList.Count + 1;
            var newPrj = new Projector(id, "projector"+id);
            Console.WriteLine("id: " + id);
            prjList.Add(newPrj);
            Console.WriteLine("addToolStripMenu: " + newPrj.Name);
            UpdatePrjTreeView(trackListView.trackList);
            pbProjector.Invalidate(); 
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pNode = selectedNode.Parent.Text;
            var node = selectedNode.Text;
            Console.WriteLine(node);
            for (int i = 0; i < trackListView.trackList.Count; i++)
            {
                if (pNode.Equals(trackListView.trackList[i].Name))
                {
                    for (int j = 0; j < trackListView.trackList[i].projectorList.Count; j++)
                    {
                        if (node.Equals(trackListView.trackList[i].projectorList[j].Name))
                        {
                            trackListView.trackList[i].projectorList.Remove(trackListView.trackList[i].projectorList[j]);
                        }
                    }
                }
            }
            UpdatePrjTreeView(trackListView.trackList);
            pbProjector.Invalidate();
        }

      }
}
