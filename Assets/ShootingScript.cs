using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    [SerializeField] private Transform gunTransform;
    [SerializeField] private Transform shootPosition;

    [Range(0,200)]
    [SerializeField] private float rotationSpeed;
    [SerializeField] private GameObject[] bullets;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gunTransform.Rotate(0,-rotationSpeed * Time.deltaTime,0);
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject bulletPrefab = bullets[Random.Range(0, bullets.Length)];
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.SetPositionAndRotation(shootPosition.position, shootPosition.rotation);
            Debug.Log("Pressed");
        }
    }
}
