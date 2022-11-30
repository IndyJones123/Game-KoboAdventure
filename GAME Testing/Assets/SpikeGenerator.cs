using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{

    public GameObject spike;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;

    public float SpeedMultiplier;

    // Start is called before the first frame update
    void Awake()
    {
        currentSpeed = MinSpeed;
        generateSpike();      
    }

    public void GenerateNextSpikeWithGap()
    {
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generateSpike", randomWait);    
    }

    void generateSpike()
    {
        GameObject SpikeIns = Instantiate(spike, transform.position, transform.rotation);

        SpikeIns.GetComponent<SpikeScript>().spikeGenerator = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentSpeed < MaxSpeed)
        {
            currentSpeed += SpeedMultiplier;
        }
    }
}
