using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMath : MonoBehaviour
{
    public Transform playerA;
    public Transform playerB;
    public float distance;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Vector3.Magnitude(playerA.position));
        Debug.Log(Vector3.Magnitude(playerB.position));
        distance = Vector3.Distance(playerA.position, playerB.position);
        Debug.Log("Dot Product of player A and B is: " + Vector3.Dot(playerA.position, playerB.position));
        Debug.Log("Cross Product of player A and B is: " + Vector3.Cross(playerA.position, playerB.position));

        StartCoroutine("TargetPlayerCoroutine");
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(playerA.position, playerB.position);
        if (distance < 2.0f)
        {
            playerA.gameObject.SetActive(false);
        }
        else
        {
            playerA.gameObject.SetActive(true);
        }
    }

    IEnumerator TargetPlayerCoroutine()
    {
        Debug.Log("Coroutine has started");
        Debug.Log("Time is: " + Time.time);

        while (distance > 0.05f)
        {
            playerB.position = Vector3.Lerp(playerB.position, playerA.position, speed * Time.deltaTime);
            yield return null;
        }
        

        yield return new WaitForSeconds(5f);


        Debug.Log("Coroutine has ended");
        Debug.Log("Time is: " + Time.time);





    }
}
