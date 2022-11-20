using Microsoft.Xna.Framework.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSounds
{
    public class Content
    {
        public List<Sound>? Sounds { get; set; }
    }

    public class Sound
    {
        public string? Name { get; set; }
        public string? FromFile { get; set; }
        public bool Loop { get; set; } = false;
        public int InstanceLimit { get; set; } = 1;
        public CueDefinition.LimitBehavior LimitBehavior { get; set; } = CueDefinition.LimitBehavior.FailToPlay;
    }
}
