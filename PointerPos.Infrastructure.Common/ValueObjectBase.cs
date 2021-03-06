﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPOS.Infrastructure.Common
{
    /// <summary>
    /// Value objects will inherit this class
    /// </summary>
    public abstract class ValueObjectBase
    {
        private List<BusinessRule> _brokenRules = new List<BusinessRule>();

        public ValueObjectBase() { }

        /// <summary>
        /// Inherited class will validate itself using this method
        /// </summary>
        protected abstract void Validate();

        public void ThrowExceptionIfInvalid()
        {
            _brokenRules.Clear();
            Validate();
            if (_brokenRules.Count > 0)
            {
                StringBuilder issues = new StringBuilder();
                foreach (BusinessRule businessRule in _brokenRules)
                {
                    issues.AppendLine(businessRule.RuleDescription);
                }

                throw new ValueObjectIsInvalidException(issues.ToString());
            }
        }

        /// <summary>
        /// Add any broken rule through this method
        /// </summary>
        /// <param name="businessRule"></param>
        protected void AddBrokenRule(BusinessRule businessRule)
        {
            _brokenRules.Add(businessRule);
        }
    }
}
