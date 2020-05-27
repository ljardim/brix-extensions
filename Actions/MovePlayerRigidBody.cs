using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Player Move - RigidBody")]
    public class MovePlayerRigidBody : AtomAction {
        [Header("Inputs")]
        [SerializeField]private GameObjectReference player;
        [SerializeField]private FloatReference horizontal;
        [SerializeField]private FloatReference vertical;
        [SerializeField]private BoolReference isRunning;
        [SerializeField]private BoolReference isGrounded;

        [Header("Configuration")]
        [SerializeField]private BoolReference moveWhenNotGrounded = new BoolReference(false);
        [SerializeField]private FloatReference walkSpeed = new FloatReference(5f);
        [SerializeField]private FloatReference runSpeed = new FloatReference(8f);
        [SerializeField]private FloatReference maxVelocityChange = new FloatReference(10.0f);

        public override void Do() {
            var rigidbody = player.Value.GetComponent<Rigidbody>();
            if (rigidbody == null) {
                Debug.Log("Player GameObject does not have a RigidBody component");
                return;
            }
            var collider = player.Value.GetComponent<Collider>();
            if (collider == null) {
                Debug.Log("Player GameObject does not have a Collider component");
                return;
            }
        
            if (!moveWhenNotGrounded.Value && !isGrounded.Value) {
                return;
            }
            
            var horizontalInput = isGrounded.Value ? horizontal.Value : horizontal.Value / 2;
            var verticalInput = isGrounded.Value ? vertical.Value : vertical.Value / 2;
            var speed = isRunning.Value ? runSpeed.Value : walkSpeed.Value;
            
            var moveAmount = Mathf.Clamp01(Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));
            if (isGrounded.Value && moveAmount < 0.1f) {
                collider.material.staticFriction = 0.6f;
                collider.material.dynamicFriction = 0.6f;
                return;
            }
            
            collider.material.staticFriction = 0;
            collider.material.dynamicFriction = 0;
        
            var playerTransform = player.Value.transform;
            var currentVelocity = rigidbody.velocity;
        
            var targetVelocity = new Vector3(horizontalInput, currentVelocity.y, verticalInput);
            targetVelocity = playerTransform.TransformDirection(targetVelocity);
            targetVelocity *= speed;
        
            var velocityChange = targetVelocity - currentVelocity;
            velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange.Value, maxVelocityChange.Value);
            velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange.Value, maxVelocityChange.Value);
            velocityChange.y = 0;
        
            rigidbody.AddForce(velocityChange, ForceMode.VelocityChange);
        }
    }
}