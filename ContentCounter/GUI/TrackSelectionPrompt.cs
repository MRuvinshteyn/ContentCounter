using ScriptPortal.Vegas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ContentCounter.GUI
{
    public partial class TrackSelectionPrompt : Form
    {
        private Vegas vegas;
        public TrackSelectionPrompt(Vegas vegas)
        {
            InitializeComponent();

            this.vegas = vegas;

            trackList.Items.AddRange(
                vegas.Project.Tracks.Select((track, index) => $"Track {index + 1}: {track.Name}").ToArray());
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            List<int> indices = new List<int>();
            foreach (object track in trackList.CheckedItems)
            {
                indices.Add(trackList.Items.IndexOf(track));
            }
            var prompt = new TrackStatsPrompt(vegas, indices);
            prompt.Show();
        }
    }
}
