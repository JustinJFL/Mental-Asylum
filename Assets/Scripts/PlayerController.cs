using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float projectileSpeed;
    public GameObject projectile;
    public GameObject projectileSpawn;
    private Rigidbody projectileRB;
    // Start is called before the first frame update
    void Start()
    {
        projectileRB = projectile.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Getting inputs for basic player movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movePlayer = new Vector3(moveHorizontal,0,moveVertical);
        transform.rotation = Quaternion.LookRotation(movePlayer);

        transform.Translate(movePlayer * moveSpeed * Time.deltaTime, Space.World);



        //Making the character aim at the mouse, possible option for gameplay 
        //Keep spot light rotated 90 on y axis to avoid aim being off
        var mousePos = Input.mousePosition;
        var playerDirection = mousePos - Camera.main.WorldToScreenPoint(transform.position);
        var playerAngle = Mathf.Atan2 (playerDirection.y, playerDirection.x) * Mathf.Rad2Deg;
    
        transform.rotation = Quaternion.AngleAxis(playerAngle,Vector3.down);

        //Shooting projectile by mouse click input can be changed if necessary
        if(Input.GetMouseButtonDown(0))
        {
            GameObject shoot = Instantiate(projectile,projectileSpawn.transform.position,projectileSpawn.transform.rotation) as GameObject;
            //shoot.transform.Rotate(Vector3.down * 90);
            //projectileRB.AddForce(transform.forward * projectileSpeed,ForceMode.Impulse);
        }
    }
}
