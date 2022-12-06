using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject WinPanel;
    [SerializeField] private GameObject LosePanel;
    [SerializeField] private GameObject InGamePanel;
    [SerializeField] private Text supperJump;

    [SerializeField]private Transform groundCheckTransform;
    [SerializeField] private LayerMask playerMask;

    private bool jumpKeyWasPressed;
    private float horizonatlInput;
    private Rigidbody rigidbodyComponent;
    private int superJumpsRemaining = 0;

    // Start is called before the first frame update
    void Awake()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
        supperJump.text = "SupperJump:" + 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the Space key is Pressed 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }

        horizonatlInput = Input.GetAxis("Horizontal");

    }
    private void FixedUpdate()
    {
        rigidbodyComponent.velocity = new Vector3(horizonatlInput, rigidbodyComponent.velocity.y, 0f);

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f,playerMask).Length == 0)
        {
            return;
        }

        //If the Space key is pressed then Upward force will ba add to it
        if (jumpKeyWasPressed)
        {
            int jumpPower = 340;
            if (superJumpsRemaining > 0f)
            {
                jumpPower = 440;
                superJumpsRemaining--;
            }

            rigidbodyComponent.AddForce(Vector3.up * jumpPower, ForceMode.Force);
            jumpKeyWasPressed = false;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            superJumpsRemaining++;
            supperJump.text = "SuperJump: " + superJumpsRemaining.ToString();
            Destroy(other.gameObject);
        }
        if (other.gameObject.layer == 10)
        {
            GetComponent<MeshRenderer>().enabled = false;
            rigidbodyComponent.isKinematic = true;
            LosePanel.gameObject.SetActive(true);
            InGamePanel.gameObject.SetActive(false);
        }
        if (other.gameObject.layer == 11)
        {
            GetComponent<MeshRenderer>().enabled = false;
            rigidbodyComponent.isKinematic = true;
            WinPanel.gameObject.SetActive(true);
            InGamePanel.gameObject.SetActive(false);
        }
    }

}
