using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform mainTransform;
    [Range(1,1000)]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float duration;

    private float startTime;
    void Start()
    {
        startTime = Time.time;
        StartCoroutine(FireRoutine());


        IEnumerator FireRoutine()
        {
            float currentTime = 0;
            while (currentTime < duration)
            {
                currentTime += Time.deltaTime;

                    Debug.LogFormat("CurrentTime={0} and duration={1}",currentTime,duration);
                    mainTransform.position += mainTransform.up * moveSpeed * Time.deltaTime;
                    yield return null;
               
            }
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
