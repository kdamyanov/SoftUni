using SimpleMvc.Framework.Attributes.Validation;

namespace Judge.App.Infrastructure.Validation
{
    public class RequiredAttribute : PropertyValidationAttribute
    {
        public override bool IsValid(object value)
            => new System
                .ComponentModel
                .DataAnnotations
                .RequiredAttribute()
                .IsValid(value);
    }
}
