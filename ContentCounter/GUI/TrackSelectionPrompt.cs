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
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            List<int> indices = new List<int>();
            foreach (object track in trackList.CheckedItems)
            {
                indices.Add(trackList.Items.IndexOf(track));
            }
            MessageBox.Show(string.Join(", ", indices));
        }
    }
}
