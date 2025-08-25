using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Owin.Security.Infrastructure;
using PortalAPI.Models;
using PortalAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PortalAPI.Repository
{
    public class Account_Repository : Account_Interface
    {
        //Token
        private const string SECRET_KEY = "this is Secret HAH key for authnetication";
        public static readonly SymmetricSecurityKey SIGNING_KEY = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Account_Repository.SECRET_KEY));

        AISContext db;
        //PortalContext database;
        //DMS_KSA_Context dbDms;
        private readonly IConfiguration _configuration;
        public Account_Repository(AISContext _db, IConfiguration configuration)
        {
            db = _db;
            _configuration = configuration;
            //database = _database;
            //dbDms = _dbDms;
        }
        public List<VM_AccountToken> Login(VM_LoginToken Login)
        {
            bool bSucceeded = true;
            string Account = Login.Email.Split('@')[0];
            using (DirectoryEntry adsEntry = new DirectoryEntry("LDAP://DC=HAHCD,DC=LOCAL", Account, Login.Password))
            {
                using (DirectorySearcher adsSearcher = new DirectorySearcher(adsEntry))
                {
                    adsSearcher.Filter = string.Format("(SAMAccountName={0})", Account);
                    try
                    {
                        SearchResult adsSearchResult = adsSearcher.FindOne();
                        bSucceeded = true;
                    }
                    catch (Exception ex)
                    {
                        bSucceeded = false;
                    }
                    finally
                    {
                        adsEntry.Close();
                    }
                }
            }
            if (bSucceeded)
            {
                if (db != null)
                {
                    DateTime Exp;
                    if (Login.Remember)
                    {
                        Exp = DateTime.Now.AddDays(30);
                    }
                    else
                    {
                        Exp = DateTime.Now.AddDays(1);
                    }
                    string HRCode = "";
                    string EmpEmail = "";
                    var Emp = (from p in db.TwebWfEmployee where p.Email.StartsWith(Account + "@") && p.IsActive == true select p).FirstOrDefault();
                    if (Emp == null)
                    {
                        return null;
                    }
                    else
                    {
                        HRCode = Emp.UserHrCode;
                        EmpEmail = Emp.Email;
                    }
                    var Token = new JwtSecurityToken(
                        claims: new Claim[]
                        {
                            new Claim("Email",EmpEmail),
                            new Claim("UserHRCode", HRCode),
                            new Claim("Expiration",Exp.ToString("yyyy-MM-dd"))
                        },
                        notBefore: DateTime.UtcNow,
                        expires: Exp,
                        signingCredentials: new SigningCredentials(SIGNING_KEY, SecurityAlgorithms.HmacSha256)
                    );
                    var res = new JwtSecurityTokenHandler().WriteToken(Token);

                    List<VM_AccountToken> response = new List<VM_AccountToken>()
                    {
                        new VM_AccountToken(){
                            Email = EmpEmail,
                            UserHRCode = HRCode,
                            Token = res,
                            Expiration = Exp
                        }
                    };
                    return response.ToList();
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }

    public class CustomAuthenticationTokenProvider : AuthenticationTokenProvider
    {
        public override void Receive(AuthenticationTokenReceiveContext context)
        {
            context.DeserializeTicket(context.Token);

            if (context.Ticket != null &&
                context.Ticket.Properties.ExpiresUtc.HasValue &&
                context.Ticket.Properties.ExpiresUtc.Value.LocalDateTime < DateTime.Now)
            {
                //store the expiration in the owin context so that we can read it later a middleware
                context.OwinContext.Set("custom.ExpriredToken", true);
            }
        }
    }
}
