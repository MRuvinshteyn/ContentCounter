using ScriptPortal.Vegas;
using System.Windows.Forms;

namespace ContentCounter
{
    public class EntryPoint
    {
        public void FromVegas(Vegas vegas)
        {
            foreach (Track track in vegas.Project.Tracks)
            {
                Timecode totalLength = new Timecode();
                foreach (TrackEvent trackEvent in track.Events)
                {
                    if (trackEvent.Start >= vegas.SelectionStart + vegas.SelectionLength)
                    {
                        break;
                    }
                    totalLength += trackEvent.Length;
                }
                MessageBox.Show(totalLength.ToString());
            }
        }
    }
}
