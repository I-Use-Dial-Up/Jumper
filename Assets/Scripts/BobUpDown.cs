using JetBrains.Annotations;
using UnityEngine;

public class BobUpDown : MonoBehaviour
{
    private Vector3 startPosition;

    float speed = 6f;
    float amplitude = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        float verticalOffset = Mathf.Sin( Time.time * speed) * amplitude;
        Vector3 targetPosition = new Vector3(startPosition.x, startPosition.y + verticalOffset, startPosition.z);
        transform.position = targetPosition;



    }
}
