using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SoftUniClone.Models;
using SoftUniClone.Web.Models;

namespace SoftUniClone.Web.Controllers
{

    [Route("api/token")]
    [ApiController]
    [IgnoreAntiforgeryToken]
    public class ApiAuthController : Controller
    {

        private readonly UserManager<User> userManager;

        public ApiAuthController(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        
        [AllowAnonymous]
        [HttpPost("")]
        public async Task<IActionResult> GenerateToken([FromBody]LoginModel loginModel)
        {
            var user = await this.userManager.FindByNameAsync(loginModel.Username);

            bool passwordMatches = await this.userManager.CheckPasswordAsync(user, loginModel.Password);

            if (!passwordMatches) {
                return Unauthorized();  
            }





            string keyword = "supersecret";
            var keywordInBytes = Encoding.UTF8.GetBytes(keyword); 
            var key = new SymmetricSecurityKey(keywordInBytes);  

            string algorithumString = "SH256";
            var signinCredentialsCreated = new SigningCredentials( key, algorithumString);

            var tokenInitializer = new JwtSecurityToken(
                issuer: "localhost",
                audience: "localhost",
                expires: DateTime.Now + TimeSpan.FromHours(24),
                signingCredentials  : signinCredentialsCreated  
                );


            string actualJwtToken = new JwtSecurityTokenHandler().WriteToken(tokenInitializer);

            return Ok(actualJwtToken);
        }
    }
}
