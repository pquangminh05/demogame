using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float lifeTime = 0.5f;
//demo part6
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
