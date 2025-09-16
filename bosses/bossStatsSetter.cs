using UnityEngine;
using System.Collections;

public class bossStatsSetter
{
    public void SetBossATK(int bossATK) //Boss attack stat
    {
        bossStatsATK.SetInt(bossATK);
    }
    public void SetBossDEF(int bossDEF) //Boss defense stat
    {
        bossStatsDEF.SetInt(bossDEF);
    }
    public void SetBossHP(int bossHP) //Boss HP stat
    {
        bossStatsHP.SetInt(bossHP);
    }
    public void SetBossSPD(double bossSPD) //Boss' movement speed
    {
        bossSPD.SetInt(bossSPD);
    }
    public void SetBossCRTRT(double bossCRTRT) //Boss crit rate
    {
        bossStatsCRTRT.SetInt(bossCRTRT);
    }
    public void SetBossCRTDMG(double bossCRTDMG) //Boss crit dmg
    {
        bossStatsCRTDMG.SetInt(bossCRTDMG);
    }
    public void SetBossHBWidth(int bossHBwidth) //Width of the boss' hit box
    {
        bossStatsHBWidth.SetInt(bossHBwidth);
    }
    public void SetBossHBHeight(int bossHBHeight) //Height of the boss' hit box
    {
        bossStatsHBHeight.SetInt(bossHBHeight);
    }
    public void SetBossName(string changebossName)
    {
        bossStatsName.SetString(changebossName);
    }
}