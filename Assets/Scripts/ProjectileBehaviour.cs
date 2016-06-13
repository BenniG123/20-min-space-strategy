using UnityEngine;
using System.Collections;

public class ProjectileBehaviour : MonoBehaviour {

    public float speed;
    public float lifetime;
    public bool isGuided;
    public Transform target;
    public int damage;
    public GameObject launch;
    public GameObject contact;

	// Use this for initialization
	void Start () {
        // Instantiate(launch, transform.position, transform.rotation);
        // GetComponent<Rigidbody>().velocity = transform.forward * speed;
        GameObject.Destroy(gameObject, lifetime);
    }
	
	// Update is called once per frame
	void Update () {

        if (isGuided)
        {
            transform.LookAt(target);
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

	}

    void OnCollisionEnter(Collision collision)
    {
        ShipAttributes s = collision.gameObject.GetComponent<ShipAttributes>();

        if (s != null)
        {
            s.TakeDamage(damage);
        }

        // Instantiate(contact, transform.position, transform.rotation);
        GameObject.Destroy(gameObject);
    }
}
