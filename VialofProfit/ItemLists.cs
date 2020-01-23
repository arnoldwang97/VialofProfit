using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VialofProfit
{
    static class ItemLists
    {
        public static Dictionary<string, ArrayList> baseDict = new Dictionary<string, ArrayList>
        {
            {"armour", new ArrayList() { "Apep's Slumber", "Architect's Hand", "Mask of the Spirit Drinker", "Dance of the Offered" } },
            {"accessory", new ArrayList() {"Coward's Chains", "Sacrificial Heart"} },
            {"weapon", new ArrayList() {"Story of the Vaal"} },
            {"flask", new ArrayList() {"Soul Catcher" } },
            {"jewel", new ArrayList() {"Tempered Mind", "Tempered Spirit", "Tempered Flesh"} }

        };

        public static Dictionary<string, ArrayList> upgradeDict = new Dictionary<string, ArrayList>
        {
            {"armour", new ArrayList() { "Apep's Supremacy", "Slavedriver's Hand", "Mask of the Stitched Demon", "Omeyocan" } },
            {"accessory", new ArrayList() {"Coward's Legacy", "Zerphi's Heart"} },
            {"weapon", new ArrayList() {"Fate of the Vaal"} },
            {"flask", new ArrayList() {"Soul Ripper" } },
            {"jewel", new ArrayList() {"Transcendent Mind", "Transcendent Spirit", "Transcendent Flesh" } }

        };

        public static string[] baseNames = { "Apep's Slumber", "Coward's Chains", "Architect's Hand", "Story of the Vaal",
                                            "Sacrificial Heart", "Mask of the Spirit Drinker", "Soul Catcher", "Dance of the Offered",
                                            "Tempered Mind", "Tempered Spirit", "Tempered Flesh" };

        public static string[] vialNames = { "Vial of Awakening", "Vial of Consequence", "Vial of Dominance", "Vial of Fate", "Vial of Sacrifice",
                                             "Vial of Summoning", "Vial of the Ghost", "Vial of the Ritual", "Vial of Transcendence",
                                             "Vial of Transcendence", "Vial of Transcendence"};

        public static string[] upgradeNames = { "Apep's Supremacy", "Coward's Legacy", "Slavedriver's Hand", "Fate of the Vaal",
                                            "Zerphi's Heart", "Mask of the Stitched Demon", "Soul Ripper", "Omeyocan",
                                            "Transcendent Mind", "Transcendent Spirit", "Transcendent Flesh" };

        

    }


}
