using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPooling
{
    public static class ObjectPool
    {
        public static List<GameObject> pooledObjects;

        public static void CreateObjectPool(GameObject parent, GameObject objectToPool, int amountToPool)
        {
            for (int i = 0; i < amountToPool; i++)
            {
                pooledObjects.Add(GameObject.Instantiate(objectToPool, new Vector3(0, 0, 0),
                    Quaternion.identity.normalized, parent.transform));

                SetObjectInactive(pooledObjects[i]);
            }
        }

        public static void SetObjectInactive(GameObject gObject)
        {
            gObject.transform.gameObject.SetActive(false);
        }

        public static void SetAllObjectsActive()
        {

        }
    }
}
