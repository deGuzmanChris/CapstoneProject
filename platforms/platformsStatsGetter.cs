using UnityEngine;
using System.Collections;

public class platformsStatsGetter
{
    public int GetHBWidth()
    {
        return platformsStats.GetDouble("Width");
    }
    public int GetHBHeight()
    {
        return platformsStats.GetDouble("Height");
    }
    public bool GetSemiSolid()
    {
        return platformsStats.GetBool("Semi-solid");
    }
}