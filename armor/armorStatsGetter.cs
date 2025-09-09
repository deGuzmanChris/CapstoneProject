using UnityEngine;
using System.Collections;

public class armorStatsGetter //Get type of armor stats
{
    public int GetArmorATKBuff()
    {
        return armorStats.GetInt("ATKBuff"); //Armor attack buff
    }
    public int GetArmorDEFBuffBuff()
    {
        return armorStats.GetInt("DEFBuff"); //Armor defense buff
    }
    public int GetArmorHPBuff()
    {
        return armorStats.GetInt("HPBuff"); //Armor HP buff
    }
    public double GetArmorSPDBuff()
    {
        return armorStats.GetDouble("SPDBuff"); //Armor speed buff
    }
    public double GetArmorCRTRTBuff() //Armor crit rate buff
    {
        return armorStats.GetDouble("CRTRTBuff");
    }
    public double GetArmorCRTDMGBuff() //Armor crit dmg buff
    {
        return armorStats.GetDouble("CRTDMGBuff");
    }
    public double GetArmorJMPBuff() //Armor jump height buff
    {
        return armorStats.GetDouble("JMPBuff");
    }
    public string GetArmorName() //Armor name
    {
        return armorStats.GetString("Name");
    }

    public int GetArmorSpellSlotsBuff() //Armor Spell slot buff (This should purely be used of testing purposes. I don't see us making armor that gives spell slots)
    {
        return armorStats.GetInt("SpellSlotsBuff");
    }
}