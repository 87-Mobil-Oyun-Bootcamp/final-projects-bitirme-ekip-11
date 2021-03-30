using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicBehavior : EnemyBehavior
{
    GameObject obj;
    GameObject edgePoint;

    public float min = 2f;
    public float max = 3f;
    Vector3 vec = new Vector3(30f, 0, 0);

    Vector3 targetAngle = new Vector3(0f, 45f, 0f);
    private Vector3 currentAngle;
    float x;
    public DynamicBehavior(GameObject obj, GameObject edgePoint)
    {
        this.edgePoint = edgePoint;
        this.obj = obj;
        min = obj.transform.position.y;
        max = obj.transform.position.y + 3;
        currentAngle = edgePoint.transform.eulerAngles;
        x = UnityEngine.Random.Range(0, 4f);
    }
    public void Behave()
    {
        obj.transform.position = new Vector3(obj.transform.position.x, Mathf.PingPong(Time.time * x, max - min) + min, obj.transform.position.z);
        //obj.transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max - min) + min, obj.transform.position.y, obj.transform.position.z);
        //obj.transform.RotateAround(edgePoint.transform.position, vec, 20 * Time.deltaTime); 
        /*currentAngle = new Vector3(
            Mathf.LerpAngle(currentAngle.x, targetAngle.x, Time.deltaTime),
            Mathf.LerpAngle(currentAngle.y, targetAngle.y, Time.deltaTime),
            Mathf.LerpAngle(currentAngle.z, targetAngle.z, Time.deltaTime));

        edgePoint.transform.eulerAngles = currentAngle;*/
    }

    

}
