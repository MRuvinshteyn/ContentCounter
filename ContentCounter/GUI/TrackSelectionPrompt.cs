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
        public TrackSelectionPrompt()
        {
            InitializeComponent();
        }

        public TrackSelectionPrompt(IEnumerable<string> tracks)
        {
            InitializeComponent();
        }
    }
}
