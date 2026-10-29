using ArbolFluent.Data;
using Microsoft.AspNetCore.Identity;

namespace ArbolFluent.Features.Account.Components;

public sealed partial class ManageNavMenu
{
    private bool _hasExternalLogins;

    protected override async Task OnInitializedAsync()
    {
        _hasExternalLogins = (await SignInManager.GetExternalAuthenticationSchemesAsync()).Any();
    }
}
