using UnityEngine;
using System.Collections;

public class playerTotalStatsGetter
{
    public int GetTotalATK()
    {
        return totalPlayerStats.GetInt("ATK");
    }
    public int GetTotalDEF()
    {
        return totalPlayerStats.GetInt("DEF");
    }
    public int GetTotalHP()
    {
        return TotalPlayerStats.GetInt("HP");
    }
    public double GetTotalSPD()
    {
        return TotalPlayerStats.GetDouble("SPD");
    }
    public double GetTotalCRTRT()
    {
        return totalPlayerStats.GetDouble("CRTRT");
    }
    public double GetTotalCRTDMG()
    {
        return totalPlayerStats.GetDouble("CRTDMG");
    }
    public double GetJMP()
    {
        return totalPlayerStats.GetDouble("JMP");
    }

    public string GetName()
    {
        return totalPlayerStats.GetString("Name");
    }

    public int GetSpellSlots()
    {
        return totalPlayerStats.GetInt("Spell slots");
    }
    public int GetHBWidth()
    {
        return basePlayersStats.GetInt("Width");
    }
    public int GetHBHeight()
    {
        return basePlayersStats.GetInt("Height");
    }
}