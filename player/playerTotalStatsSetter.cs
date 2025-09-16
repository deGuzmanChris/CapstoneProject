using UnityEngine;
using System.Collections;

public class playerStatsSetter
{
    public void SetPlayerTotalATK(int basePlayerATK, int armorBuffATK, int potionBuffATK)
    {
        playerTotalStatsATK.SetInt(playerATK + armorBuff + potionBuff);
    }
    public void SetPlayerTotalDEF(int basePlayerDEF, int armorBuffDEF, int potionBuffDEF)
    {
        playerTotalStatsDEF.SetInt(playerDEF + armorBuffDEF + potionBuffDEF);
    }
    public void SetPlayerTotalHP(int basePlayerHP, int armorBuffHP, int potionBuffHP)
    {
        playerTotalStatsHP.SetInt(playerHP + armorBuffHP + potionBuffHP);
    }
    public void SetPlayerTotalSPD(double basePlayerSPD, double armorBuffSPD, double potionBuffSPD)
    {
        playerTotalSPD.SetInt(playerSPD + armorBuffSPD + potionBuffSPD);
    }
    public void SetPlayerTotalCRTRT(double basePlayerCRTRT, double armorBuffCRTRT, double potionBuffCRTRT)
    {
        playerTotalStatsCRTRT.SetInt(playerCRTRT + armorBuffCRTRT + potionBuffCRTRT);
    }
    public void SetPlayerTotalCRTDMG(double basePlayerCRTDMG, double armorBuffCRTDMG, double potionBuffCRTDMG)
    {
        playerTotalStatsCRTDMG.SetInt(playerCRTDMG + armorBuffCRTDMG + potionBuffCRTDMG);
    }
    public void SetPlayerTotalJMP(double basePlayerJMP, double armorBuffJMP, double potionBuffJMP)
    {
        playerTotalStatsSlots.SetInt(basePlayerJMP + armorBuffJMP + potionBuffJMP);
    }
    public void SetPlayerName(string changePlayerName)
    {
        playerTotalStatsName.SetString(changePlayerName);
    }
    public void SetPlayerTotalSlots(int basePlayerSlots, int addedSpellSlots)
    {
        playerTotalStatsSlots.SetInt(basePlayerSlots + addedSpellSlots);
    }
    public void SetTotalPlayerHBWidth(int playerHBwidth)
    {
        playerStatsHBWidth.SetInt(playerHBwidth);
    }
    public void SetTotalPlayerHBHeight(int playerHBHeight)
    {
        playerStatsHBHeight.SetInt(playerHBHeight);
    }
}