using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBullet : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnBullet;
    public float velocityBullet;

    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBulletF);
    }

    private void FireBulletF(ActivateEventArgs arg)
    {
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnBullet.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnBullet.forward * velocityBullet;
        Destroy(spawnedBullet, 5);
    }
}
