using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPooling
{
    public static class ObjectPool
    {
        public static List<GameObject> pooledObjects;

        public static void CreateObjectPool(GameObject objectToPool, int amountToPool)
        {
            for (int i = 0; i < amountToPool; i++)
            {
                pooledObjects.Add(objectToPool);
                pooledObjects[i].transform.gameObject.SetActive(false);
            }
        }

        public static void SetAllObjectsInactive()
        {

        }

        public static void SetAllObjectsActive()
        {

        }
    }
}
