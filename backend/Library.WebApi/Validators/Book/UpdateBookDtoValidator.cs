using FluentValidation;
using Library.Common.DTO.Book;

namespace Library.WebApi.Validators.Book;

public class UpdateBookDtoValidator: AbstractValidator<UpdateBookDto>
{
    public UpdateBookDtoValidator()
    {
        CommonValidationRules.ApplyCommonNameRule(RuleFor(b => b.Name));
        CommonValidationRules.ApplyCommonPageCountRule(RuleFor(b => b.PageCount));
        CommonValidationRules.ApplyCommonDescriptionRule(RuleFor(b => b.Description));
    }
}