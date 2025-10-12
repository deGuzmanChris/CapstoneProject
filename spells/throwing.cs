using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwing : MonoBehaviour
{
    public GameObject projectilePrefab; // Assign your projectile prefab in the Inspector
    public Transform target; // A reference to the target
    public float throwRate; // Time in seconds between throws
    public float maxProjSPD; // Timer to track the projectile
    public float projectileMaxHeight; // Maximum height of the trajectory
    public AnimationCurve trajectoryAnimationCurve; // Animation curve for the trajectory
    public AnimationCurve axisCorrectionAnimationCurve; // Correcting the animation curve for the trajectory
    public AnimationCurve SPDAnimationCurve; // Animation curve for the projectile speed over time

    public void Update()
    {
        shootTimer -= Time.deltaTime;

        if (shootTimer <= 0f && Input.GetKeyDown(KeyCode.Q))
        {
            shootTimer = shootRate; // Reset the timer
            projectilePrefab projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity).GetComponent<projectile>();
            projectile.InitializeProjectile(target, maxProjSPD, projectileMaxHeight);
            projectile.InitializeAnimationCurve(trajectoryAnimationCurve, axisCorrectionAnimationCurve, SPDAnimationCurve);
        }
    }


}