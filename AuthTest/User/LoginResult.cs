using System.Security.Claims;

namespace AuthTest.User;

public class ClaimHolder()
{
    public string claimType { get; set; }
    public string claimValue { get; set; }
}


public class LoginResult
{
    public bool isSuccess { get; set; }
    public string message { get; set; }
    public List<ClaimHolder> claims { get; set; }

    public List<Claim> GetClaimsList()
    {
      return claims.Select(holder => new Claim(holder.claimType, holder.claimValue)).ToList();
    }
}