using ContentCounter.GUI;
using ScriptPortal.Vegas;

namespace ContentCounter
{
    public class EntryPoint
    {
        public void FromVegas(Vegas vegas)
        {
            TrackSelectionPrompt prompt = new TrackSelectionPrompt(vegas);
            prompt.Show();
        }
    }
}
