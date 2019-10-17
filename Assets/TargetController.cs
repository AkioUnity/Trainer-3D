using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public Transform parent;
    public GameObject rotateObj;
    public Transform target;
    public Transform targetCenter;
    public Transform player;

    private float x1=117;
    private float x2=130;
    
    private float z1=-78;
    private float z2=-97;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveTarget());
    } 

    IEnumerator MoveTarget()
    {
        while (true)
        {
            transform.position=new Vector3(Random.Range(x1,x2),parent.position.y,Random.Range(z1,z2));
            transform.LookAt(player);
            iTween.RotateTo(rotateObj,iTween.Hash("z",0,"time",1,"islocal",true));
//            iTween.RotateTo(rotateObj,new Vector3(0,0,0),1);
            yield return new WaitForSeconds(4);
            iTween.RotateTo(rotateObj,iTween.Hash("z",-90,"time",1,"islocal",true));
//            iTween.RotateTo(rotateObj,new Vector3(0,0,-90),1);
            yield return new WaitForSeconds(1);
            RemoveBullet();
        }
    }

    void RemoveBullet()
    {
        foreach (Transform child in target.transform) {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Transform child in targetCenter.transform) {
            GameObject.Destroy(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
