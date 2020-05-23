using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    public class OnEnableAssignGameObject : MonoBehaviour {
        [SerializeField]private GameObjectVariable target;

        private void OnEnable() {
            target.Value = gameObject;
            Destroy(this);
        }
    }
}