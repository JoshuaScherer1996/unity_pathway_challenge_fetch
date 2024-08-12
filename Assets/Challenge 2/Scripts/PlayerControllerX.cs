using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // Declaring and Initializing variables.
    public GameObject dogPrefab;
    private const float CoolDown = 0.5f;
    private float _nextSpawnTime;

    // Update is called once per frame.
    void Update()
    {
        // On spacebar press, send dog. Also checks if the current time has advanced beyond the _nextSpawnTime.
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _nextSpawnTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            
            _nextSpawnTime = Time.time + CoolDown;
        }
    }
}
