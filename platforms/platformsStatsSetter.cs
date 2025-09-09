using UnityEngine;
using System.Collections;

public class platformsStatsSetter
{
    public void SetPlatformsSemiSolid(bool platformsSemiSolid)
    {
        platformsStatsSemiSolid.SetInt(platformsSemiSolid);
    }
    public void SetPlatformsHBWidth(int platformsHBwidth)
    {
        platformsStatsHBWidth.SetInt(platformsHBwidth);
    }
    public void SetPlatformsHBHeight(int platformsHBHeight)
    {
        platformsStatsHBHeight.SetInt(platformsHBHeight);
    }
}