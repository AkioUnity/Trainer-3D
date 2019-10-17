using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AScore : MonoBehaviour
{
    public bool isCenter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(isCenter+ "other:"+other.transform.position);
    }

    public void SetScore()
    {
        UIManager.inst.AddScore(isCenter);
    }
}
