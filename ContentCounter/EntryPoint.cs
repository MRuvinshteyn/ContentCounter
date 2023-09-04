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
                double totalLength = 0;
                foreach (TrackEvent trackEvent in track.Events)
                {
                    totalLength += trackEvent.Length.ToMilliseconds();
                }
                MessageBox.Show(totalLength.ToString());
            }
        }
    }
}
