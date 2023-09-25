using ScriptPortal.Vegas;
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
    public partial class TrackStatsPrompt : Form
    {
        public TrackStatsPrompt(Vegas vegas, IEnumerable<int> selectedTracks)
        {
            InitializeComponent();

            foreach (Track track in selectedTracks.Select(index => vegas.Project.Tracks[index]))
            {
                statsTable.Height += 50;
                statsTable.RowCount++;
                statsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50f));

                Label trackNameLabel = new Label()
                {
                    Text = track.Name,
                    Anchor = AnchorStyles.None
                };
                statsTable.Controls.Add(trackNameLabel, 0, statsTable.RowCount - 1);
                while (trackNameLabel.Width < TextRenderer.MeasureText(trackNameLabel.Text,
                    new Font(trackNameLabel.Font.FontFamily, trackNameLabel.Font.Size, trackNameLabel.Font.Style)).Width)
                {
                    trackNameLabel.Font = new Font(trackNameLabel.Font.FontFamily, trackNameLabel.Font.Size - 0.5f, trackNameLabel.Font.Style);
                }

                Timecode totalLength = new Timecode(),
                         cursorLength = new Timecode(),
                         selectionLength = new Timecode();
                foreach (TrackEvent trackEvent in track.Events)
                {
                    totalLength += trackEvent.Length;

                    if (trackEvent.Start + trackEvent.Length <= vegas.Transport.CursorPosition)
                    {
                        cursorLength += trackEvent.Length;
                    }

                    if (trackEvent.Start >= vegas.SelectionStart &&
                        trackEvent.Start + trackEvent.Length <= vegas.SelectionStart + vegas.SelectionLength)
                    {
                        selectionLength += trackEvent.Length;
                    }
                }

                statsTable.Controls.Add(
                    new Label() {
                        Text = totalLength.ToString(), 
                        Anchor = AnchorStyles.None 
                    }, 1, statsTable.RowCount - 1);

                statsTable.Controls.Add(
                    new Label() {
                        Text = cursorLength.ToString(), 
                        Anchor = AnchorStyles.None 
                    }, 2, statsTable.RowCount - 1);

                statsTable.Controls.Add(
                    new Label() {
                        Text = selectionLength.ToString(), 
                        Anchor = AnchorStyles.None 
                    }, 3, statsTable.RowCount - 1);
            }
        }
    }
}
