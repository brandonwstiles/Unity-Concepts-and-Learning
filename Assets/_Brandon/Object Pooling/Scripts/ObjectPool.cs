using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPooling
{
    public static class ObjectPool
    {
        private static List<GameObject> pooledObjects;
        private static Transform objectDefaultTransform;

        //Create pool with parent
        public static void CreateObjectPool(GameObject parent, GameObject objectToPool, int amountToPool)
        {
            for (int i = 0; i < amountToPool; i++)
            {
                Input.GetKey("W");
                pooledObjects.Add(GameObject.Instantiate(objectToPool, Vector3.zero,
                    Quaternion.identity.normalized, parent.transform));

                SetObjectInactive(pooledObjects[i]);
            }
        }

        

        public static GameObject SelectDisabledObjectFromPool()
        {
            foreach (var pooledObject in pooledObjects)
            {
                if (!pooledObject.activeSelf)
                    return pooledObject;              
            }
            return null;
            //Consider returning something more appropriate
        }

        public static void ReturnObjectToPool(GameObject pooledObject)
        {
            SetObjectInactive(pooledObject);
            ResetObject(pooledObject);
        }

        private static void SetObjectInactive(GameObject pooledObject)
        {
            pooledObject.transform.gameObject.SetActive(false);
        }

        private static void SetAllObjectsActive()
        {

        }

        private static void ResetObject(GameObject pooledObject)
        {

        }

        private static void SetObjectDefaultTransform(GameObject parent)
        {
            objectDefaultTransform = parent.transform;
            //Consider different default position
        }
    }
}
