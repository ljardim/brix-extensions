using Brix.State;
using ScriptableObjectArchitecture;
using UnityEngine;

namespace Brix.Extensions {
    [CreateAssetMenu(menuName = Constants.Menus.CONDITIONS + "Bool Comparison")]
    public class BoolComparison : Condition {
        [SerializeField]private BoolReference valueToCheck;
        [SerializeField]private BoolReference expectedValue;
        public override bool CheckCondition() {
            return valueToCheck.Value.Equals(expectedValue.Value);
        }
    }
}