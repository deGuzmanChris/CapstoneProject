using UnityEngine;
using System.Collections;

public class potionsStatsGetter
{
    public int GetPotionsATKBuff()
    {
        return potionsStats.GetInt("ATKBuff");
    }
    public int GetPotionsDEFBuffBuff()
    {
        return potionsStats.GetInt("DEFBuff");
    }
    public int GetPotionsHPBuff()
    {
        return potionsStats.GetInt("HPBuff");
    }
    public double GetPotionsSPDBuff()
    {
        return potionsStats.GetDouble("SPDBuff");
    }
    public double GetPotionsCRTRTBuff()
    {
        return potionsStats.GetDouble("CRTRTBuff");
    }
    public double GetPotionsCRTDMGBuff()
    {
        return potionsStats.GetDouble("CRTDMGBuff");
    }
    public double GetPotionsJMPBuff()
    {
        return potionsStats.GetDouble("JMPBuff");
    }
    public string GetPotionsName()
    {
        return potionsStats.GetString("Name");
    }

    public int GetPotionsSpellSlotsBuff()
    {
        return potionsStats.GetInt("SpellSlotsBuff");
    }
    public int GetPotionsHealing()
    {
        return potionsStats.GetInt("Healing");
    }
    public int GetPotionsDuration()
    {
        return potionsStats.GetInt("Duration");
    }
}