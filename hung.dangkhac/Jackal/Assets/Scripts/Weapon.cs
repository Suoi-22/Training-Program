using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject playerBullet;
    public GameObject grenade;
    public Vector3 grenadeDir;
    public Transform bulletSpawnPoint;
    public float bulletSpped;
    public float grenadeSpeed;
    private void Awake() {
        grenadeDir = new Vector3(0, 1, 0);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) {
            var bullet = Instantiate(playerBullet, bulletSpawnPoint.position, transform.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.transform.up * bulletSpped;
        }
        if (Input.GetKeyDown(KeyCode.X) && GameObject.FindWithTag("Grenade") == null) {
            var grenadeClone = Instantiate(grenade, bulletSpawnPoint.position, transform.rotation);
            grenadeClone.GetComponent<Rigidbody2D>().velocity = grenadeDir * grenadeSpeed;
        }
    }
}
