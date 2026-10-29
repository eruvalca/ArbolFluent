using Microsoft.AspNetCore.Identity;
using OneOf;
using ArbolFluent.Data;

namespace ArbolFluent.Features.Account.Models;

[GenerateOneOf]
internal sealed partial class ExternalRegistrationOutcome : OneOfBase<RegistrationOutcome.Created, RegistrationOutcome.CreationRejected, ExternalRegistrationOutcome.ExternalLoginLinkFailed>
{
    internal sealed record ExternalLoginLinkFailed(ApplicationUser User, IReadOnlyList<IdentityError> Errors);
}
