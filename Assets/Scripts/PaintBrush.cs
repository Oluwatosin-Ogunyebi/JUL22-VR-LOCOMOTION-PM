using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBrush : MonoBehaviour
{
    public Transform paintBrushTip;
    public GameObject paintPrefab;
    public Material defaultMat;

    private GameObject _tempPaint;
    private Material _tempMaterial;

    public List<GameObject> gameObjectsList;



    public void StartPainting()
    {
        _tempPaint = Instantiate(paintPrefab, paintBrushTip.position, paintBrushTip.rotation);
        _tempPaint.transform.SetParent(paintBrushTip);

        if (_tempMaterial != null)
        {
            _tempPaint.GetComponent<TrailRenderer>().material = _tempMaterial;
        }
        else
        {
            _tempPaint.GetComponent<TrailRenderer>().material = defaultMat;
        }

        gameObjectsList.Add(paintPrefab);
        gameObjectsList.Remove(paintPrefab);
        gameObjectsList.RemoveAt(1);

        for (int i = 0; i < gameObjectsList.Count; i++)
        {
            Debug.Log("Object here is: " + gameObjectsList[i]);
        }

        foreach (var item in gameObjectsList)
        {
            Debug.Log("Object here in for each is: " + item);
        }
        
    }

    public void StopPainting()
    {
        if (_tempPaint != null)
        {
            _tempPaint.transform.SetParent(null);
            _tempPaint = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Paint"))
        {
            _tempMaterial = other.GetComponent<MeshRenderer>().material;
            paintBrushTip.GetComponent<MeshRenderer>().material.color = _tempMaterial.color;
        }
    }
}
