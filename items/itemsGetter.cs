using UnityEngine;
using System.Collections;

public class itemsStatsGetter
{
    public int GetItemsATKBuff()
    {
        return itemsStats.GetInt("ATKBuff");
    }
    public int GetItemsDEFBuffBuff()
    {
        return itemsStats.GetInt("DEFBuff");
    }
    public int GetItemsHPBuff()
    {
        return itemsStats.GetInt("HPBuff");
    }
    public double GetItemsSPDBuff()
    {
        return itemsStats.GetDouble("SPDBuff");
    }
    public double GetItemsCRTRTBuff()
    {
        return itemsStats.GetDouble("CRTRTBuff");
    }
    public double GetItemsCRTDMGBuff()
    {
        return itemsStats.GetDouble("CRTDMGBuff");
    }
    public double GetItemsJMPBuff()
    {
        return itemsStats.GetDouble("JMPBuff");
    }
    public string GetItemsName()
    {
        return itemsStats.GetString("Name");
    }

    public int GetItemsSpellSlotsBuff()
    {
        return itemsStats.GetInt("SpellSlotsBuff");
    }
}