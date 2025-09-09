using UnityEngine;
using System.Collections;

public class scrollsStatsSetter
{
    public void SetScrollsATK(int scrollsATK)
    {
        scrollsStatsATK.SetInt(scrollsATK);
    }
    public void SetScrollsDEF(int scrollsDEF)
    {
        scrollsStatsDEF.SetInt(scrollsDEF);
    }
    public void SetScrollsHP(int scrollsHP)
    {
        scrollsStatsHP.SetInt(scrollsHP);
    }
    public void SetScrollsSPD(double scrollsSPDBuff)
    {
        scrollsStatsSPD.SetInt(scrollsSPD);
    }
    public void SetScrollsJMPBuff(double scrollsJMPBuff)
    {
        scrollsStatsJMP.SetDouble(scrollsJMPBuff);
    }
    public void SetScrollsCRTRT(double scrollsCRTRT)
    {
        scrollsStatsCRTRT.SetInt(scrollsCRTRT);
    }
    public void SetScrollsCRTDMG(double scrollsCRTDMG)
    {
        scrollsStatsCRTDMG.SetInt(scrollsCRTDMG);
    }
    public void SetScrollsHBWidth(int scrollsHBwidth)
    {
        scrollsStatsHBWidth.SetInt(scrollsHBwidth);
    }
    public void SetScrollsHBHeight(int scrollsHBHeight)
    {
        scrollsStatsHBHeight.SetInt(scrollsHBHeight);
    }
    public void SetScrollsName(string changeScrollsName)
    {
        scrollsStatsName.SetString(changeScrollsName);
    }
    public void SetScrollsHealing(int scrollsHealing)
    {
        scrollsStatsHealing.SetString(scrollsHealing);
    }
    public void SetScrollsDuration(int scrollsDuration)
    {
        scrollsStatsDuration.SetString(scrollsDuration);
    }
    public void SetScrollsChargeTime(int scrollsChargeTime)
    {
        scrollsStatsChargeTime.SetInt(scrollsChargeTime);
    }
    public void SetScrollsCooldown(int scrollsCooldown)
    {
        scrollsStatsCooldown.SetInt(scrollsCooldown);
    }
}