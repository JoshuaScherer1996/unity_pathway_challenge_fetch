using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private const float SpawnLimitXLeft = -22;
    private const float SpawnLimitXRight = 7;
    private const float SpawnPosY = 30;

    private const float StartDelay = 1.0f;
    private float _randomSpawnTime;

    // Start is called before the first frame update
    private void Start()
    {
        // Invoking the method to randomize the spawn times.
        RandomizeInterval();
        // Using Invoke instead of InvokeRepeating to be able to use dynamic time intervals.
        Invoke(nameof(SpawnRandomBall), StartDelay);
    }

    // Spawn random ball at random x position at top of play area.
    private void SpawnRandomBall()
    {
        
        // Generate random ball index and random spawn position.
        var spawnPos = new Vector3(Random.Range(SpawnLimitXLeft, SpawnLimitXRight), SpawnPosY, 0);
        
        // Generate a random index to spawn a random ball.
        var index = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location.
        Instantiate(
            ballPrefabs[index], 
            spawnPos, 
            ballPrefabs[0].transform.rotation
            );
        
        // Invoking the method to randomize the spawn times.
        RandomizeInterval();
        
        // Reusing the invoke method with the randomized spawn time.
        Invoke(nameof(SpawnRandomBall), _randomSpawnTime);
        
    }

    // Randomizes the interval between spawning the balls.
    private void RandomizeInterval()
    {
        _randomSpawnTime = Random.Range(1.0f, 5.0f);
    }

}
