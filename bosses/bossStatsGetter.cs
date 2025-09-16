using UnityEngine;
using System.Collections;

public class bossStatsGetter //Gets stats of bosses
{
    public int GetATK()
    {
        return bossStats.GetInt("ATK"); //Boss attack stat
    }
    public int GetDEF()
    {
        return bossStats.GetInt("DEF"); //Boss defense stat
    }
    public int GetHP()
    {
        return bossStats.GetInt("HP"); //Boss HP stat
    }
    public double GetCRTRT()
    {
        return bossStats.GetDouble("CRTRT"); //Boss crit rate stat
    }
    public double GetCRTDMG()
    {
        return bossStats.GetDouble("CRTDMG"); //Boss crit dmg
    }
    public int GetRange()
    {
        return bossStats.GetDouble("Range"); //Boss' attack range
    }
    public int GetHBWidth()
    {
        return bossStats.GetInt("width"); //Width of the boss' hit box
    }
    public int GetHBHeight()
    {
        return bossStats.GetInt("height"); //Height of the boss' hit box
    }
    public int GetHPBars()
    {
        return bossStats.GetInt("HPBars"); //Phases of the boss
    }
    public string GetName()
    {
        return bossStats.GetString("Name"); //Boss name
    }
}