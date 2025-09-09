using UnityEngine;
using System.Collections;

public class spritesGetter
{
    public int GetATK()
    {
        return spritesStats.GetInt("ATK");
    }
    public int GetDEF()
    {
        return spritesStats.GetInt("DEF");
    }
    public int GetHP()
    {
        return spritesStats.GetInt("HP");
    }
    public double GetSPD()
    {
        return spritesStats.GetDouble("SPD");
    }
    public double GetCRTRT()
    {
        return spritesStats.GetDouble("CRTRT");
    }
    public double GetCRTDMG()
    {
        return spritesStats.GetDouble("CRTDMG");
    }
    public int GetHBWidth()
    {
        return spritesStats.GetDouble("width");
    }
    public int GetHBHeight()
    {
        return spritesStats.GetDouble("height");
    }
}