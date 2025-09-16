using UnityEngine;
using System.Collections;

public class playerBaseStatsGetter : sprite
{
    public int GetBaseATK()
    {
        return basePlayerStats.GetInt("ATK");
    }
    public int GetBaseDEF()
    {
        return basePlayerStats.GetDouble("DEF");
    }
    public int GetBaseHP()
    {
        return basePlayerStats.GetDouble("HP");
    }
    public double GetBaseSPD()
    {
        return basePlayerStats.GetDouble("SPD");
    }
    public double GetBaseCRTRT()
    {
        return basePlayerStats.GetDouble("CRTRT");
    }
    public double GetBaseCRTDMG()
    {
        return basePlayerStats.GetDouble("CRTDMG");
    }
    public double GetJMP()
    {
        return basePlayerStats.GetDouble("JMP");
    }

    public string GetName()
    {
        return basePlayerStats.GetString("Name");
    }

    public int GetSpellSlots()
    {
        return basePlayerStats.GetInt("Spell slots");
    }
    public int GetHBWidth()
    {
        return basePlayerStats.GetInt("Width");
    }
    public int GetHBHeight()
    {
        return basePlayerStats.GetInt("Height");
    }
}