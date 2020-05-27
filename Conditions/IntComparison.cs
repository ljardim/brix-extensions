using System;
using Brix.State;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [CreateAssetMenu(menuName = Constants.Menus.CONDITIONS + "Int Comparison")]
    public class IntComparison : Condition {
        [SerializeField]private IntReference valueToCheck;
        [SerializeField]private Constants.Comparison comparison = Constants.Comparison.Equals;
        [SerializeField]private IntReference expectedValue;
        public override bool CheckCondition() {
            int comparisonResult;
            switch (comparison) {
                case Constants.Comparison.Equals:
                    return valueToCheck.Value.Equals(expectedValue.Value);
                case Constants.Comparison.NotEquals:
                    return !valueToCheck.Value.Equals(expectedValue.Value);
                case Constants.Comparison.GreaterThan:
                    comparisonResult = valueToCheck.Value.CompareTo(expectedValue.Value);
                    return comparisonResult > 0;
                case Constants.Comparison.GreaterThanEquals:
                    comparisonResult = valueToCheck.Value.CompareTo(expectedValue.Value);
                    return comparisonResult > 0 || comparisonResult == 0;
                case Constants.Comparison.LessThan:
                    comparisonResult = valueToCheck.Value.CompareTo(expectedValue.Value);
                    return comparisonResult < 0;
                case Constants.Comparison.LessThanEquals:
                    comparisonResult = valueToCheck.Value.CompareTo(expectedValue.Value);
                    return comparisonResult < 0 || comparisonResult == 0;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}