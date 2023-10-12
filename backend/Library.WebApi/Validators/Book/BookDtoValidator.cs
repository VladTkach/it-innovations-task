﻿using FluentValidation;
using Library.Common.DTO.Book;

namespace Library.WebApi.Validators.Book;

public class BookDtoValidator: AbstractValidator<BookDto>
{
    public BookDtoValidator()
    {
        CommonValidationRules.ApplyCommonNameRule(RuleFor(b => b.Name));
        CommonValidationRules.ApplyCommonPageCountRule(RuleFor(b => b.PageCount));
        CommonValidationRules.ApplyCommonDescriptionRule(RuleFor(b => b.Description));
        CommonValidationRules.ApplyCommonCreateAtRule(RuleFor(b => b.CreatedAt));
    }
}