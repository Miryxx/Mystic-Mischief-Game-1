using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using UnityEngine.SceneManagement;

public class ThirdPersonController : MonoBehaviour
{
    public Reload reload;
    public bool canMove;
    private ThirdPersonControl playerInputs;
    private InputAction move;
    ControlsforPlayer controls;
    private CapsuleCollider CapsuleCollider;

    private Rigidbody rb;
    [SerializeField]
    private float moveForce = 3.5f;
    
    public float jumpForce = 10f;
    [SerializeField]
    private float maxSpeed = 5f;
    [SerializeField]
    private Vector3 forceDirection = Vector3.zero;

    [SerializeField]
    private Camera playerCamera;
    public float Stamina;
    public float runSpeed;
    public float applySpeed;
    private bool flying;
    private Vector3 oldHVelocity;
    public Vector3 glideSpeed;
    public Vector3 diveSpeed;
    public float diveTim;
    [HideInInspector]
    public bool Saved;
    [HideInInspector]
    public bool Loaded;
    public float powerValue;
    public bool Targeted;
    public bool inWater;
    public PlayerAnimation playerAnimation;
            public AudioClip HurtClip;

    public bool isGrounded{get; set;}
    [SerializeField] private GameObject camGround;
    [SerializeField] private GameObject camFly;
    [SerializeField] private GameObject flyingEffets;


    //[HideInInspector]
    public float rbSpeed;
    public int maxHealth = 4;
    public int currentHealth;
    public Animator animator;
    public SaveGeneral save;
    private bool jumpInAir;

    //public GameObject healthBar;
    //public GameObject staminaBar;

    private AudioSource caw;
    


    // Start is called before the first frame update
    private void Awake()
    {
        // Checkpoint();
        rb = this.GetComponent<Rigidbody>();
        playerInputs = new ThirdPersonControl();

        //playerInputs.Enable();
        controls = new ControlsforPlayer();
        controls.Enable();
        move = controls.Actions.Movement;
        Stamina = 4;
        CapsuleCollider = transform.GetComponent<CapsuleCollider>();
        isGrounded = true;
        //if(healthBar != null)
        //{
        //    healthBar.GetComponent<HealthBar>().SetMaxHealth(4);
        //}
        currentHealth = maxHealth;

        caw = GetComponent<AudioSource>();
        
    }
    private void FixedUpdate()
    {
        if (canMove)
        {
            forceDirection += move.ReadValue<Vector2>().x * GetCameraRight(playerCamera) * moveForce;
            forceDirection += move.ReadValue<Vector2>().y * GetCameraForward(playerCamera) * moveForce;
        }

        rb.AddForce(forceDirection, ForceMode.Impulse);
        forceDirection = Vector3.zero;

        //  if(rb.velocity.y < 0f)
        //  {
        //      rb.velocity -= Vector3.down * Physics.gravity.y * Time.fixedDeltaTime;
        //  }

        Vector3 horizontalVelocity = rb.velocity;
        horizontalVelocity.y = 0;
        if (horizontalVelocity.sqrMagnitude > maxSpeed * maxSpeed)
        {
            rb.velocity = horizontalVelocity.normalized * maxSpeed + Vector3.up * rb.velocity.y;
        }


        IsGrounded();
        LookAt();

        Vector3 Turn = new Vector3(0, 0, 0);
        Vector3 MaxRotation = new Vector3(0, 10, 0);
        bool Left = controls.Actions.GlideLeft.ReadValue<float>() > 0.1f;
        bool Right = controls.Actions.GlideRight.ReadValue<float>() > 0.1f;
        Vector3 velocity = rb.velocity;
        Vector3 lastPosition = transform.position;

        //If the player is diving this code sets the animator and player in the diving state.
        bool dive = false;
        if (dive == false)
        {
            oldHVelocity = new Vector3(velocity.x, 0, velocity.z);
            animator.SetBool("IsDiving", false);
        }

        //This code regenerates the stamina when the player lands on the ground.
        if (isGrounded == true)
        {
            Stamina += Time.fixedDeltaTime;
            if (Stamina >= 4)
            {
                Stamina = 4;
            }
            animator.SetBool("IsDiving", false);
            flyingEffets.SetActive(false);
        }

        flying = controls.Actions.Glide.ReadValue<float>() > 0.1f;
        bool diving = controls.Actions.Dive.ReadValue<float>() > 0.1f;
        //This code makes the player dive using velocity calculations and the constant force component on the gameobject.
        if (diving && isGrounded == false)
        {
            diveTim += Time.fixedDeltaTime;
            dive = true;
            Vector3 newHVelocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            GetComponent<ConstantForce>().force = diveSpeed;
            flyingEffets.SetActive(false);
            
        }

        //When the player has glided for long enough it stores energy and when the player stops diving and is still flying it releases the energy in an upwards momentum.
        else
        {
            glideSpeed.z = glideSpeed.z + diveTim - Time.fixedDeltaTime;
            glideSpeed.y = glideSpeed.y + diveTim - (Time.fixedDeltaTime * 2);
            //The code below makes sure that each part of the glidespeed Vector3 does not add to much momentum after the player stops diving. These are caps for each float so that it does not exceed to much.
            if (diveTim > 10)
            {
                diveTim = 0;
                glideSpeed.z = 100;
            }
            if (glideSpeed.z <= 100)
            {
                glideSpeed.z = 100;
            }
            if (glideSpeed.y <= 9.8f)
            {
                glideSpeed.y = 9.8f;
            }
            if (glideSpeed.z >= 130)
            {
                glideSpeed.z = 100;
            }
            if (glideSpeed.y >= 25)
            {
                glideSpeed.y = 9.8f;
            }
            //This makes the players momentum slowely return to what it normally is when the player flies.
            diveTim -= Time.fixedDeltaTime;
            GetComponent<ConstantForce>().force = new Vector3(0, 0, 0);
            Vector3 newHVelocity = new Vector3(rb.velocity.x, 0, rb.velocity.z) + oldHVelocity;
        }
        //This lets the float for calculating how long the player dives not go below zero.
        if (diveTim <= 0)
        {
            diveTim = 0;
        }

        //This lets the player fly after jumping in the air.
        if (isGrounded == false && canMove && jumpInAir == true)
        {
            Stamina += (Time.fixedDeltaTime * 0.5f);
            if (Stamina >= 4)
            {
                Stamina = 4;
            }
            GetComponent<ConstantForce>().relativeForce = glideSpeed + Turn;

            flyingEffets.SetActive(true);
        }
        //This makes the flying stop.
        else 
        { 
            GetComponent<ConstantForce>().relativeForce = new Vector3(0, 0, 0); 
        }

    }

    private void Update()
    {
        if (playerInputs.PlayerOnGround.Jump.triggered)
        {
            DoJump();
        }

        bool diving = controls.Actions.Dive.ReadValue<float>() > 0.1f;
        if (diving && isGrounded == false)
        {
            animator.SetBool("IsDiving", true);
        }
        if (diving == false && isGrounded == false)
        {
            animator.SetBool("IsDiving", false);
        }

        if (controls.Test.HeathTest.WasPerformedThisFrame())
        {
            TakeDamage(1);
            Debug.Log("Taking Damage...");
        }
        if (currentHealth <= 0)
        {
            //LoadCheckpoint();
            // currentHealth = maxHealth;
            SceneManager.LoadScene("LoseScreen");
        }
        //if(staminaBar != null)
        //{
        //    staminaBar.GetComponent<StaminaBar>().UpdateStamina(Stamina);
        //}
    }


    public void TakeDamage(int damage)
    {
        playerAnimation.PlaySound(HurtClip);
        currentHealth -= damage;
        Debug.Log(currentHealth);

        //healthBar?.GetComponent<HealthBar>().SetHealth(currentHealth);
        Debug.Log("In TakeDamage");
        
    }

    private void LookAt()
    {
        Vector3 direction = rb.velocity;
        direction.y = 0f;
        if(move.ReadValue<Vector2>().sqrMagnitude > 0.1f)
        {
            this.rb.rotation = Quaternion.LookRotation(direction, Vector3.up);
        }
        else
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
    private Vector3 GetCameraRight(Camera playerCamera)
    {
        Vector3 right = playerCamera.transform.right;
        right.y = 0;
        return right.normalized;
    }

    private Vector3 GetCameraForward(Camera playerCamera)
    {
        Vector3 forward = playerCamera.transform.forward;
        forward.y = 0;
        return forward.normalized;
    }

    private void OnEnable()
    {
        playerInputs.Enable();
        //controls.Actions.Jump.started += DoJump;
        controls.Actions.Caw.started += Caw;
        move = controls.Actions.Movement;
        //playerInputs.PlayerOnGround.Enable();
        controls.Enable();

        camGround.SetActive(true);
        camFly.SetActive(false);

    }
    private void OnDisable()
    {
        playerInputs.Disable();
        //controls.Actions.Jump.started -= DoJump;
        controls.Actions.Caw.started -= Caw;
        //playerInputs.PlayerOnGround.Disable();
        controls.Disable();

        camGround.SetActive(false);
        camFly.SetActive(false);
    }

    private void IsGrounded()
    {
        float bufferDistance = 0.1f;
        float groundCheckDistance = (GetComponent<CapsuleCollider>().height/2)+bufferDistance;
        RaycastHit hit;
        if(Physics.Raycast(transform.position,-transform.up, out hit,groundCheckDistance))
        {
            isGrounded=true;
            camGround.SetActive(true);
            camFly.SetActive(false);
            animator.SetBool("Grounded", true);
            jumpInAir = false;
        }
        else
        {
            isGrounded = false;
            animator.SetBool("Grounded", false);
            camGround.SetActive(false);
            camFly.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //This pushes the player back when they hit a wall.
        if(other.gameObject.CompareTag("wall")){
            Vector3 direction = other.contacts[0].point - transform.position;
            direction = -direction.normalized;
            rb.AddForce((-transform.forward * 1000) * powerValue);
        }
        //This pushes the player back when they hit an enemy.
        if(other.gameObject.CompareTag("enemy")){
            Vector3 direction = other.contacts[0].point - transform.position;
            direction = -direction.normalized;
            rb.AddForce((-transform.forward * 1000) * powerValue);
        }
        //This stops the player from moving when they are in the water
        if(other.gameObject.CompareTag("Water")){
        moveForce = 0.5f;
            isGrounded = false;
            inWater = true;
        }
        //This makes the player take damage when they run into the Attackpos gameobject of the dragon.
        if (other.gameObject.CompareTag("Attackpos"))
        {
            TakeDamage(4);
        }
        //This makes the player take damage when they are hit by a projectile.
        if (other.gameObject.CompareTag("Projectile"))
        {
            TakeDamage(1);
        }
    }
    void OnCollisionExit(Collision other)
    {
        //This lets the player move again when they jump out of water.
        if(other.gameObject.CompareTag("Water")){
            inWater = false;
            moveForce = 3.5f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //This saves a checkpoint.
        if (other.gameObject.tag == "Checkpoint")
        {
            Checkpoint();
        }
        //In the fire level this lets the dragon know what room the player is in.
        if(other.gameObject.CompareTag("RoomEnter"))
        {
            other.GetComponent<FireDragonPerch>().playerInRoom = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //Im the fire level this lets the dragon know when they exited the room they were in.
        if(other.gameObject.CompareTag("RoomEnter"))
        {
            other.GetComponent<FireDragonPerch>().playerInRoom = false;
        }
    }

    private void DoJump()
    {
            if (Stamina > 0 && isGrounded == true)
            {
                animator.SetTrigger("Jump");    
                forceDirection += Vector3.up * jumpForce;
                Stamina -= 1;
                //StaminaBar.instance.UseStamina(1);
                Debug.Log("In DoJump Function");
            }
            if (Stamina > 0 && isGrounded == false)
            {
                animator.SetTrigger("Jump");    
                forceDirection += Vector3.up * jumpForce;
                Stamina -= 1;
                //StaminaBar.instance.UseStamina(1);
                Debug.Log("In DoJump Function");
                jumpInAir = true;
            }
    }
    public void SavePlayer ()
    {
        SaveSystem.SavePlayer(this);
        Saved = true;
    }
    public void LoadPlayer ()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        currentHealth = data.health;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
        Stamina = data.Stamina;
        //staminaBar.GetComponent<StaminaBar>().UpdateStamina(Stamina);
        //healthBar?.GetComponent<HealthBar>().SetHealth(currentHealth);
    }

    public void Checkpoint ()
    {
        // save.SaveEnemyCheckPoint();
        SaveSystem.SavePlayer(this);
        // SaveSystem.Checkpoint(this);
        // Saved = true;
        Debug.Log("Saved");
    }
    public void LoadCheckpoint ()
    {
        PlayerData data = SaveSystem.LoadCheckpoint();
        currentHealth = data.health;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
        Stamina = data.Stamina;
        //staminaBar.GetComponent<StaminaBar>().UpdateStamina(Stamina);
        //healthBar?.GetComponent<HealthBar>().SetHealth(currentHealth);
    }
    private void Caw(InputAction.CallbackContext obj)
    {
        caw.Play();
    }

}
