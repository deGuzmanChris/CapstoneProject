using UnityEngine;
using System.Collections;

public class scrollsStatsGetter
{
    public int GetATK()
    {
        return scrollsStats.GetInt("ATK");
    }
    public int GetDEF()
    {
        return scrollsStats.GetInt("DEF");
    }
    public int GetHP()
    {
        return scrollsStats.GetInt("HP");
    }
    public double GetSPDBuff()
    {
        return scrollsStats.GetDouble("SPD");
    }
    public double GetCRTRT()
    {
        return scrollsStats.GetDouble("CRTRT");
    }
    public double GetCRTDMG()
    {
        return scrollsStats.GetDouble("CRTDMG");
    }
    public double GetJMPBuff()
    {
        return scrollsStats.GetDouble("JMP");
    }
    public string GetName()
    {
        return scrollsStats.GetString("Name");
    }
    public int GetHBWidth()
    {
        return scrollssStats.GetInt("width");
    }
    public int GetHBHeight()
    {
        return scrollssStats.GetInt("height");
    }
    public int GetHealing()
    {
        return scrollsStats.GetInt("Healing");
    }
    public int GetDuration()
    {
        return scrollsStats.GetInt("Duration");
    }
    public int GetChargeTime()
    {
        return scrollsStats.GetInt("Charge time");
    }
    public int GetCooldown()
    {
        return scrollsStats.GetInt("Cooldown");
    }
}