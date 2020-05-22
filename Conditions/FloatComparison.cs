using Brix.State;
using ScriptableObjectArchitecture;
using UnityEngine;

namespace Brix.Extensions {
    [CreateAssetMenu(menuName = Constants.Menus.CONDITIONS + "Float Comparison")]
    public class FloatComparison : Condition {
        [SerializeField]private FloatReference valueToCheck;
        [SerializeField]private FloatReference expectedValue;
        public override bool CheckCondition() {
            return valueToCheck.Value.Equals(expectedValue.Value);
        }
    }
}