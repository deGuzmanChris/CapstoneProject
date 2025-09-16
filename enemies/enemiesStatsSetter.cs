using UnityEngine;
using System.Collections;

public class enemiesStatsSetter
{
    public void SetEnemiesATK(int enemiesATK)
    {
        enemiesStatsATK.SetInt(enemiesATK);
    }
    public void SetEnemiesDEF(int enemiesDEF)
    {
        enemiesStatsDEF.SetInt(enemiesDEF);
    }
    public void SetEnemiesHP(int enemiesHP)
    {
        enemiesStatsHP.SetInt(enemiesHP);
    }
    public void SetEnemiesSPD(double enemiesSPD)
    {
        enemiesSPD.SetInt(enemiesSPD);
    }
    public void SetEnemiesCRTRT(double enemiesCRTRT)
    {
        enemiesStatsCRTRT.SetInt(enemiesCRTRT);
    }
    public void SetEnemiesCRTDMG(double enemiesCRTDMG)
    {
        enemiesStatsCRTDMG.SetInt(enemiesCRTDMG);
    }
    public void SetEnemiesHBWidth(int enemiesHBwidth)
    {
        enemiesStatsHBWidth.SetInt(enemiesHBwidth);
    }
    public void SetEnemiesHBHeight(int enemiesHBHeight)
    {
        enemiesStatsHBHeight.SetInt(enemiesHBHeight);
    }
    public void SetEnemiesName(string changeEnemiesName)
    {
        enemiesStatsName.SetString(changeenemiesName);
    }
}