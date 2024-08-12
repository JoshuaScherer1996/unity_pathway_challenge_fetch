using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private const float SpawnLimitXLeft = -22;
    private const float SpawnLimitXRight = 7;
    private const float SpawnPosY = 30;

    private const float StartDelay = 1.0f;
    private const float SpawnInterval = 4.0f;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomBall), StartDelay, SpawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    private void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        var spawnPos = new Vector3(Random.Range(SpawnLimitXLeft, SpawnLimitXRight), SpawnPosY, 0);
        
        // Generate a random index to spawn a random ball
        var index = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(
            ballPrefabs[index], 
            spawnPos, 
            ballPrefabs[0].transform.rotation
            );
    }

}
