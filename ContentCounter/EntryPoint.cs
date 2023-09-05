using ContentCounter.GUI;
using ScriptPortal.Vegas;
using System.Linq;
using System.Windows.Forms;

namespace ContentCounter
{
    public class EntryPoint
    {
        public void FromVegas(Vegas vegas)
        {
            MessageBox.Show(vegas.Project.Tracks.Count.ToString());
            TrackSelectionPrompt prompt = new TrackSelectionPrompt(vegas.Project.Tracks.Select(track => track.Name));
            prompt.Show();
            //foreach (Track track in vegas.Project.Tracks)
            //{
            //    Timecode totalLength = new Timecode();
            //    foreach (TrackEvent trackEvent in track.Events)
            //    {
            //        if (trackEvent.Start < vegas.SelectionStart)
            //        {
            //            continue;
            //        }
            //        if (trackEvent.Start + trackEvent.Length > vegas.SelectionStart + vegas.SelectionLength)
            //        {
            //            break;
            //        }
            //        totalLength += trackEvent.Length;
            //    }
            //    MessageBox.Show(totalLength.ToString());
            //}
        }
    }
}
