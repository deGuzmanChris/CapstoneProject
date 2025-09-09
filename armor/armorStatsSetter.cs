using UnityEngine;
using System.Collections;

public class armorStatsSetter //Set type for all armor stats
{
    public void SetArmorATKBuff(int armorATKBuff) //Armor attack buff
    {
        armorStatsATKBuff.SetInt(armorATKBuff);
    }
    public void SetArmorDEFBuff(int armorDEFBuff) //Armor defense buff
    {
        armorStatsDEFBuff.SetInt(armorDEFBuff);
    }
    public void SetArmorHPBuff(int armorHPBuff) //Armor HP buff
    {
        armorStatsHPBuff.SetInt(armorHPBuff);
    }
    public void SetArmorSPDBuff(double armorSPDBuff) //Armor speed buff
    {
        armorSPDBuff.SetInt(armorSPDBuff);
    }
    public void SetArmorCRTRTBuff(double armorCRTRTBuff) //Armor crit rate buff
    {
        armorStatsCRTRTBuff.SetInt(armorCRTRTBuff);
    }
    public void SetArmorCRTDMGBuff(double armorCRTDMGBuff) //Armor crit dmg buff
    {
        armorStatsCRTDMGBuff.SetInt(armorCRTDMGBuff);
    }
    public void SetArmorJMPBuff(double armorJMPBuff) //Armor jump height buff
    {
        armorStatsJMPBuff.SetDouble(armorJMPBuff);
    }
    public void SetArmorName(string changeArmorName) //Armor name
    {
        armorStatsName.SetString(changeArmorName);
    }
    public void SetArmorSpellSlotsBuff(int armorSpellSlotsBuff) //Armor Spell slot buff (This should purely be used of testing purposes. I don't see us making armor that gives spell slots)
    {
        armorStatsSpellSlots.SetInt(armorSpellSlotsBuff);
    }
}