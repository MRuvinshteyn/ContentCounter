using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentCounter.GUI
{
    public partial class TrackSelectionPrompt : Form
    {
        public TrackSelectionPrompt(IEnumerable<string> tracks)
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;

            trackList.Items.AddRange(tracks.ToArray());
            trackList.Height = trackList.ItemHeight * (trackList.Items.Count + 1);
        }
    }
}
