using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class PlatformSpawner : MonoBehaviour
{
    public List<GameObject> platforms;
    private float offset = 40f;

    void Start()
    {
        if(platforms != null && platforms.Count>0)
        {
            platforms = platforms.OrderBy(r => r.transform.position.z).ToList();
        }
    }

    public void MovePlatform()
    {
        GameObject movedPlatform = platforms[0];
        platforms.Remove(movedPlatform);
        float newZ = platforms[platforms.Count - 1].transform.position.z + offset;
        movedPlatform.transform.position = new Vector3(0, 0, newZ);
        platforms.Add(movedPlatform);
    }
}
