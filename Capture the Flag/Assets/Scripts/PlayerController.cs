using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Stats")]
    public float moveSpeed;
    public float jumpForce;
    public int curHp;
    public int maxHp;

    [Header("Camera")]
    public float lookSens;
    public float maxLookX;
    public float minLookX;
    private float rotX;

    private Camera camera;
    private Rigidbody rb;
    //private Weapon weapon;

    void Awake()
    {
        //weapon = GetComponent<Weapon>();
    }

    void Start()
    {
        //Get Components
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();

        /* Instatialize the UI
        GameUI.instance.UpdateHealthBar(curHp, maxHp);
        GameUI.instance.UpdateScoreText(0);
        GameUI.instance.UpdateAmmoText(weapon.curAmmo, weapon.maxAmmo); */
    }

    // applies damage
    public void TakeDamage(int damage)
    {
        curHp -= damage;
        
        if(curHp <= 0)
            Die();

        //GameUI.instance.UpdateHealthBar(curHp, maxHp);    
    }

    public void Die()
    {
        //GameManager.instance.LoseGame();
        Debug.Log("die");
    }

    public void GiveHealth(int amountToGive)
    {
        //curHp = Mathf.Clamp(curHp + amountToGive, 0, maxHp);
        //GameUI.instance.UpdateHealthBar(curHp, maxHp);
        Debug.Log("give health");
    }

    public void GiveAmmo(int amountToGive)
    {
        //weapon.curAmmo = Mathf.Clamp(weapon.curAmmo + amountToGive, 0, weapon.maxAmmo);
        //GameUI.instance.UpdateAmmoText(weaon.curAmmo, weapon.maxAmmo);
        Debug.Log("give ammo");
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;

        Vector3 dir = transform.right * x + transform.forward * z;

        dir.y = rb.velocity.y;
        rb.velocity = dir;
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSens; //look up and down
        rotX += Input.GetAxis("Mouse Y") * lookSens; //look side to side

        //restrict look up and down
        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);

        //drives camera roation
        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void Jump()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        
        if(Physics.Raycast(ray, 1.1f))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void Update()
    {
        Move();
        CameraLook();

        /* if(Input.GetButton("Fire1"))
        {
            if(weapon.CanShoot())
              weapon.Shoot();
        } */

        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        
        //dont do anything if agme is paused
        /* if(GameManager.instance.gamePaused == true)
        {
            return;
        } */
    }
}