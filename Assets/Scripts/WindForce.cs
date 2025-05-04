using UnityEngine;

public class WindForce : MonoBehaviour
{
    public float minAngle = 0f;
    public float maxAngle = 360f;

    [SerializeField] float minForce;
    [SerializeField] float maxForce;

    [SerializeField] float changeInterval;

    private AreaEffector2D effector;
    private float timer;

    void Start()
    {
        effector = GetComponent<AreaEffector2D>();
        RandomizeWind();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= changeInterval)
        {
            RandomizeWind();
            timer = 0f;
        }
    }

    void RandomizeWind()
    {
        effector.forceAngle = Random.Range(minAngle, maxAngle);
        effector.forceMagnitude = Random.Range(minForce, maxForce);
    }
}
