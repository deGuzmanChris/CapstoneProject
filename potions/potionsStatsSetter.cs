using UnityEngine;
using System.Collections;

public class potionsStatsSetter
{
    public void SetPotionsATKBuff(int potionsATKBuff)
    {
        potionsStatsATKBuff.SetInt(potionsATKBuff);
    }
    public void SetPotionsDEFBuff(int potionsDEFBuff)
    {
        potionsStatsDEFBuff.SetInt(potionsDEFBuff);
    }
    public void SetPotionsHPBuff(int potionsHPBuff)
    {
        potionsStatsHPBuff.SetInt(potionsHPBuff);
    }
    public void SetPotionsSPDBuff(double potionsSPDBuff)
    {
        potionsSPDBuff.SetInt(potionsSPDBuff);
    }
    public void SetPotionsCRTRTBuff(double potionsCRTRTBuff)
    {
        potionsStatsCRTRTBuff.SetInt(potionsCRTRTBuff);
    }
    public void SetPotionsCRTDMGBuff(double potionsCRTDMGBuff)
    {
        potionsStatsCRTDMGBuff.SetInt(potionsCRTDMGBuff);
    }
    public void SetPotionsName(string changePotionsName)
    {
        potionsStatsName.SetString(changePotionsName);
    }
    public void SetPotionsHealing(int potionsHealing)
    {
        potionsStatsHealing.SetString(potionsHealing);
    }
    public void SetPotionsDuration(int potionsDuration)
    {
        potionsStatsDuration.SetString(potionsDuration);
    }
}