using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public Transform target; // A reference to the target
    public float projSPD; // Speed of the projectile
    public float maxProjSPD; // Maximum speed of the projectile
    public float trajectoryMaxHeight; // Maximum height of the trajectory
    public float distanceFromTarget = 0.1f; // Distance to consider as "reached" the target
    public AnimationCurve trajectoryAnimationCurve; // Animation curve for the trajectory
    public AnimationCurve axisCorrectionAnimationCurve; // Correcting the animation curve for the trajectory
    public AnimationCurve SPDAnimationCurve; // Animation curve for the projectile speed over time
    public Vector3 trajectoryStartPoint; // Starting point of the trajectory
    public Vector3 trajectoryEndPoint; // Ending point of the trajectory

    public void Start()
    {
        trajectoryStartPoint = transform.position;
    }

    public void Update()
    {
        UpdateProjectilePosition();

        if (Vector3.Distance(transform.position, target.position) < distanceFromTarget)
        {
            Destroy(gameObject); // Destroy the projectile when it reaches the target
        }
    }

    public void UpdateProjectilePosition()
    {
        Vector3 trajectoryRange = target.position - trajectoryStartPoint;

        if(trajectoryRange.x < 0)
        {
            //Shooter is to the right of the target
            moveSpeed = -moveSpeed;
        }

        float nextPositionX = transform.position.x + projSPD * Time.deltaTime;
        float normalizedPositionX = (nextPositionX - trajectoryStartPoint.x) / trajectoryRange.x;

        float nextPositionYNormalized = trajectoryAnimationCurve.Evaluate(normalizedPositionX);

        float normalizedYCorrection = axisCorrectionAnimationCurve.Evaluate(normalizedPositionX);
        float nextPositionYCorrectionAbsolute = nextPositionYNormalized * trajectoryRange.y;

        float nextPositionY = trajectoryStartPoint.y + nextPositionYNormalized * trajectoryMaxHeight + nextPositionYCorrectionAbsolute;

        Vector3 newPosition = new Vector3(nextPositionX, nextPositionY, 0);

        CalculateProjectileSpeed(nextPositionX);

        transform.position = newPosition;
    }

    public void CalculateProjectileSpeed(float nextPositionX)
    {
        float moveSPDNormalized = SPDAnimationCurve.Evaluate(nextPositionX);

        projSPD = moveSPDNormalized * maxProjSPD;
    }

    public void InitializeProjectile(Transform target, float maxProjSPD, float trajectoryMaxHeight)
    {
        this.maxProjSPD = maxProjSPD;
        this.target = target;

        float xDistanceToTarget = target.position.x - transform.position.x;
        this.trajectoryMaxHeight = trajectoryMaxHeight;
    }

    public void InitializeAnimationCurve(AnimationCurve trajectoryAnimationCurve, AnimationCurve axisCorrectionAnimationCurve, AnimationCurve SPDAnimationCurve)
    {
        this.trajectoryAnimationCurve = trajectoryAnimationCurve;
        this.axisCorrectionAnimationCurve = axisCorrectionAnimationCurve;
        this.SPDAnimationCurve = SPDAnimationCurve;
    }
}