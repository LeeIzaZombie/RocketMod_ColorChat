using UnityEngine;
using Rocket.Unturned;
using SDG;
using Rocket.Unturned.Plugins;

namespace ColorSay
{
    public class PluginColorSay: RocketPlugin //Apparently can't load commands without a parent plugin.
    {
        public string Name
        {
            get { return "colorsay"; }
        }

        protected override void Load()
        { }
    }
}
