using UnityEngine;

public class CoolDown : MonoBehaviour
{
    public float cooldownTimer;
    private float nextFireTime;

    public bool IsCoolingDown => Time.time < nextFireTime;
    public void StartCoolDown() => nextFireTime = Time.time + cooldownTimer;
}
