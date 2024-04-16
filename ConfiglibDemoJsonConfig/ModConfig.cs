using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiglibDemoJsonConfig
{
    class ModConfig
    {
        public static ModConfig Instance { get; set; } = new ModConfig();

        /// <summary>
        /// Drop rate for branchy leaves.
        /// </summary>
        public float BranchyDropRate { get { return _branchyDropRate; } set { _branchyDropRate = value >= 0 ? value : 0; } }
        private float _branchyDropRate = 0.8f;

        /// <summary>
        /// Drop rate for normal leaf tiles.
        /// </summary>
        public float LeavesDropRate { get { return _leavesDropRate; } set { _leavesDropRate = value >= 0 ? value : 0; } }
        private float _leavesDropRate = 1.0f;

        /// <summary>
        /// Whether the change of additional drops should be decreased as you get drops.
        /// </summary>
        public bool DiminishingDrops { get { return _diminishingDrops; } set { _diminishingDrops = value; } }
        private bool _diminishingDrops = false;

        /// <summary>
        /// Whether the axe used should take extra damage from each additional log dropped.
        /// </summary>
        public bool ExtraAxeDamage { get { return _extraAxeDamage; } set { _extraAxeDamage = value; } }
        private bool _extraAxeDamage = false;
    }
}
