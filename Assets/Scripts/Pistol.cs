using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Pistol : Gun
{
    public AudioSource pistolAudio;
    public AudioClip shootSound;
    public override void Shoot()
    {
        base.Shoot();
        if (pistolAudio != null)
        {
            pistolAudio.PlayOneShot(shootSound);
        }

    }
}
