using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public Transform arrow;
    public Transform target1;
    public Transform target2;


    IEnumerator Start()
    {
        while (true)
        {
            yield return StartCoroutine(MoveObject(transform, arrow.position, target1.position, 1));
            yield return StartCoroutine(MoveObject(transform, arrow.position, target2.position, 1));

        }
    }
    private void Update()
    {
        StartCoroutine(removeArrow());
    }
    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        float i = 0.0f;
        float rate = 1.0f / time;
        
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
            
        }
    }

    IEnumerator removeArrow()
    {
        int i = 5;
        while (i > 0)
        {
            i--;
            yield return new WaitForSeconds(1F);
        }
        Destroy(gameObject);
    }



}
