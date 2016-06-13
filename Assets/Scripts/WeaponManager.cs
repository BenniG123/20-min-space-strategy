using UnityEngine;
using System.Collections;

public class WeaponManager : MonoBehaviour {

    public Transform target;
    public GameObject projectile;
    public Transform turret;
    public float fireRate;

	// Use this for initialization
	void Start () {
	    StartCoroutine(FireProjectile());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator FireProjectile()
    {
        while (true)
        {
            yield return new WaitForSeconds(1/ fireRate);
            turret.LookAt(target);
            Instantiate(projectile, turret.position, turret.rotation);
            if (projectile.GetComponent<ProjectileBehaviour>().isGuided)
            {
                projectile.GetComponent<ProjectileBehaviour>().target = target;
            }
        }
    }
}
