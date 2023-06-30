using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletControolller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "PlayerBullet") {
            Destroy(gameObject, 0.3f);
        }
        if (gameObject.tag == "Grenade") {
            Destroy(gameObject, 1f);
        }
    }
}
