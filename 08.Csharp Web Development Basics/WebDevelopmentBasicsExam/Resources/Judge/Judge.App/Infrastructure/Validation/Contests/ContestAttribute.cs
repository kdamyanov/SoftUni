using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleMvc.Framework.Attributes.Validation;

namespace Judge.App.Infrastructure.Validation.Contests
{
    class ContestAttribute:PropertyValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var contest = value as string;
            if (contest == null)
            {
                return true;
            }

            return contest.Length > 0
                   && char.IsUpper(contest[0])
                   && contest.Length >= 3
                   && contest.Length <= 100;
        }
    }
}
