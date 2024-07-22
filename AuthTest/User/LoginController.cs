using AuthTest.User;
using Microsoft.AspNetCore.Mvc;

namespace AuthTest.User;


[Route("/api")]
[ApiController]
public class LoginController:ControllerBase
{
    [HttpPost]
    [Route("login")]
    public async Task<LoginResult> Login([FromForm] string userName , [FromForm] string userPassword)
    {
        if (userName.Equals("ali@gmail.com") && userPassword.Equals("1234"))
        {
            return new LoginResult()
            {
                isSuccess = true,
                message = "Login Successful",
                claims = new List<ClaimHolder>(new[]
                {
                    new ClaimHolder() { claimValue = "Email", claimType = userName }
                })

            };
            
        }
        else
        {
            return new LoginResult()
            {
                isSuccess = false,
                message = "Login Failed"

            }; 
        }
    }
}