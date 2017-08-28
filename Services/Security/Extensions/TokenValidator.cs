using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace App.Services.Security.Extensions
{
  public class TokenValidator : ISecurityTokenValidator
  {
    public bool CanValidateToken => throw new System.NotImplementedException();

    public int MaximumTokenSizeInBytes { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public bool CanReadToken(string securityToken)
    {
      throw new System.NotImplementedException();
    }

    ClaimsPrincipal ISecurityTokenValidator.ValidateToken(string securityToken, TokenValidationParameters validationParameters, out SecurityToken validatedToken)
    {
        throw new System.NotImplementedException();
    }
  }
}