using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Grupparbete.Areas.API.Models;
using System.Text;

namespace Grupparbete.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public IActionResult Login([FromBody] User user)
        {
            if (user.UserName.Equals("admin") && user.Password.Equals("password"))
            {
                user.Id = Guid.NewGuid().ToString();
                var token = GenerateJwtToken(user);
                return Ok(token);
            }

            return BadRequest("Invalid User");
        }

        private string GenerateJwtToken(User user)
        {
            var securityKey = Encoding.UTF8.GetBytes(_configuration["Jwt:Secret"]);

            var claims = new Claim[] {
                    new Claim(ClaimTypes.Name,user.Id.ToString()),
                    new Claim(ClaimTypes.Name,user.UserName)
                };

            var credentials = new SigningCredentials(new SymmetricSecurityKey(securityKey), SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
              _configuration["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddDays(7),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
