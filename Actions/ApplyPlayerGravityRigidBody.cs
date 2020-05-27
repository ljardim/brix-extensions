using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Player Gravity - RigidBody")]
    public class ApplyPlayerGravityRigidBody : AtomAction {
        [Header("Inputs")]
        [SerializeField]private GameObjectReference player;
        [SerializeField]private BoolReference isGrounded;

        [Header("Configuration")]
        [SerializeField]private BoolReference shouldCheckGrounded = new BoolReference(true);
        [SerializeField]private FloatReference gravity = new FloatReference(10.0f);

        public override void Do() {
            var rigidbody = player.Value.GetComponent<Rigidbody>();
            if (rigidbody == null) {
                Debug.Log("Player GameObject does not have a RigidBody component");
                return;
            }
            
            if (shouldCheckGrounded.Value && isGrounded.Value) {
                return;
            }
            
            rigidbody.freezeRotation = true;
            rigidbody.useGravity = false;
            rigidbody.isKinematic = false;
            
            rigidbody.AddForce(new Vector3 (0, -gravity * rigidbody.mass, 0));
        }
    }
}