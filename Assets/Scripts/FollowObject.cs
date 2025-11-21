using UnityEngine;

public class FollowObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Transform followObject;
    void Start()
    {
        return;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(followObject.position.x, followObject.position.y, gameObject.transform.position.z);
    }
}
