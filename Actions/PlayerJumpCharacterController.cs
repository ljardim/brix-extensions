using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Player Jump - Character Controller")]
    public class PlayerJumpCharacterController : AtomAction {
        [Header("Inputs")]
        [SerializeField]private GameObjectReference player;

        [Header("Configuration")]
        [SerializeField]private FloatReference jumpHeight = new FloatReference(4f);
        [SerializeField]private Vector3Reference gravityDrag = new Vector3Reference();

        public override void Do() {
            var characterController = player.Value.GetComponent<CharacterController>();
            if (characterController == null) {
                Debug.Log("Player GameObject does not have a CharacterController component");
                return;
            }

            // Start with current y velocity
            var velocity = Vector3.zero;
            velocity.y = characterController.velocity.y;
            
            // Add Jump height
            velocity.y += Mathf.Sqrt(jumpHeight.Value * -2f * Physics.gravity.y);

            // Add gravity
            velocity.y += Physics.gravity.y * Time.deltaTime;
            
            // Add drag to gravity
            velocity.x /= 1 + gravityDrag.Value.x * Time.deltaTime;
            velocity.y /= 1 + gravityDrag.Value.y * Time.deltaTime;
            velocity.z /= 1 + gravityDrag.Value.z * Time.deltaTime;
            
            // Apply gravity movement
            characterController.Move(velocity * Time.deltaTime);
        }
    }
}