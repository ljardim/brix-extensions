using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Player Jump - RigidBody")]
    public class PlayerJumpRigidBody : AtomAction {
        [Header("Inputs")]
        [SerializeField]private GameObjectReference player;

        [Header("Configuration")]
        [SerializeField]private FloatReference jumpHeight = new FloatReference(4f);

        public override void Do() {
            var rigidbody = player.Value.GetComponent<Rigidbody>();
            if (rigidbody == null) {
                Debug.Log("Player GameObject does not have a RigidBody component");
                return;
            }

            rigidbody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
    }
}