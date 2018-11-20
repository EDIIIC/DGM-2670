using UnityEngine;

public class BulletEmission : MonoBehaviour
{

    public GameObject projectile;
    public Transform shotPos;
    public float shotForce;
    private Rigidbody rigid;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        //if (Input.GetKeyDown (KeyCode.F)) 
        {
            GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation);
            shot.GetComponent<Rigidbody2D>().AddForce(shotPos.up * shotForce);
        }
    }
}