namespace Record.Editor;

using FluentValidation;

public record Email(string Value);
    
public class EmailValidator : AbstractValidator<Email>
{
  public EmailValidator()
  {
    RuleFor(email => email.Value)
      .MaximumLength(10)
      .NotEmpty().WithMessage("Email is required")
      .EmailAddress().WithMessage("Email is not a valid email address");
  }
}