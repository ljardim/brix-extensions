using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Player Move - Character Controller")]
    public class MovePlayerCharacterController : AtomAction {
        [Header("Inputs")]
        [SerializeField]private GameObjectReference player;
        [SerializeField]private FloatReference horizontal;
        [SerializeField]private FloatReference vertical;
        [SerializeField]private BoolReference isRunning;
        [SerializeField]private BoolReference isGrounded;

        [Header("Configuration")]
        [SerializeField]private BoolReference moveWhenNotGrounded = new BoolReference(true);
        [SerializeField]private FloatReference walkSpeed = new FloatReference(3f);
        [SerializeField]private FloatReference runSpeed = new FloatReference(7f);
        [SerializeField]private Vector3Reference gravityDrag = new Vector3Reference();

        private Vector3 _velocity;
        
        public override void Do() {
            var characterController = player.Value.GetComponent<CharacterController>();
            if (characterController == null) {
                Debug.Log("Player GameObject does not have a CharacterController component");
                return;
            }

            if (!moveWhenNotGrounded.Value && !isGrounded.Value) {
                return;
            }

            _velocity = Vector3.zero;
            _velocity.y = characterController.velocity.y;
            if (isGrounded.Value && _velocity.y < 0) {
                _velocity.y = 0f;
            }
            
            // Get Inputs
            var horizontalInput = horizontal.Value;
            var verticalInput = vertical.Value;
            
            // Determine Speed
            var speed = (isRunning.Value ? runSpeed.Value : walkSpeed.Value) * Time.deltaTime;

            // Calculate movement vector
            var forwardMovement = player.Value.transform.forward * verticalInput; 
            var rightMovement = player.Value.transform.right * horizontalInput;
            var moveVector = Vector3.ClampMagnitude(forwardMovement + rightMovement, 1f);
            
            // Move controller
            characterController.Move(moveVector * speed);

            // Apply gravity
            _velocity.y += Physics.gravity.y * Time.deltaTime;
            
            // Add drag to gravity
            _velocity.x /= 1 + gravityDrag.Value.x * Time.deltaTime;
            _velocity.y /= 1 + gravityDrag.Value.y * Time.deltaTime;
            _velocity.z /= 1 + gravityDrag.Value.z * Time.deltaTime;
            
            // Apply gravity movement
            characterController.Move(_velocity * Time.deltaTime);
        }
    }
}