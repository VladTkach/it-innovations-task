using FluentValidation;

namespace Library.WebApi.Validators.Book;

public static class CommonValidationRules
{
    public static IRuleBuilderOptions<T, string> ApplyCommonNameRule<T>(IRuleBuilderInitial<T, string> ruleBuilder)
    {
        return ruleBuilder
            .NotEmpty()
            .WithMessage("Name is required")
            .MaximumLength(100)
            .WithMessage("Name must be less than 100 characters");
    }

    public static IRuleBuilderOptions<T, string> ApplyCommonDescriptionRule<T>(IRuleBuilderInitial<T, string> ruleBuilder)
    {
        return ruleBuilder
            .NotEmpty()
            .WithMessage("Description is required")
            .MaximumLength(1000)
            .WithMessage("Description must be less than 1001 characters");
    }

    public static IRuleBuilderOptions<T, int> ApplyCommonPageCountRule<T>(IRuleBuilderInitial<T, int> ruleBuilder)
    {
        return ruleBuilder
            .NotEmpty()
            .WithMessage("Page count is required")
            .GreaterThan(0)
            .WithMessage("Page count must be greater than 0");
    }
    
    public static IRuleBuilderOptions<T, DateTime> ApplyCommonCreateAtRule<T>(IRuleBuilderInitial<T, DateTime> ruleBuilder)
    {
        return ruleBuilder
            .NotEmpty()
            .WithMessage("Create date is required")
            .LessThanOrEqualTo(DateTime.Now)
            .WithMessage("The date cannot be older than now");
    }
}