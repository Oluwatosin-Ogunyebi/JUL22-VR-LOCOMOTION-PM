using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class paintBullet : MonoBehaviour
{
    public TrailRenderer bulletTR;
    public Material bulletMat;

    public Color bulletColor;
    private void Awake()
    {   
        
        this.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        bulletColor = this.GetComponent<MeshRenderer>().material.color;
        bulletTR.material = this.GetComponent<MeshRenderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<MeshRenderer>() != null)
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = bulletColor;
        }
        
    }
}
