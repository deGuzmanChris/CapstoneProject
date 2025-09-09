using UnityEngine;
using System.Collections;

public class enemiesStatsGetter
{
    public int GetATK()
    {
        return enemiesStats.GetInt("ATK");
    }
    public int GetDEF()
    {
        return enemiesStats.GetInt("DEF");
    }
    public int GetHP()
    {
        return enemiesStats.GetInt("HP");
    }
    public double GetCRTRT()
    {
        return enemiesStats.GetDouble("CRTRT");
    }
    public double GetCRTDMG()
    {
        return enemiesStats.GetDouble("CRTDMG");
    }
    public int GetRange()
    {
        return enemiesStats.GetDouble("Range");
    }
    public int GetHBWidth()
    {
        return enemiesStats.GetDouble("Width");
    }
    public int GetHBHeight()
    {
        return enemiesStats.GetDouble("height");
    }
    public string GetName()
    {
        return enemiesStats.GetString("Name");
    }
}