using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using Complains_System.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Complains_System.EF;

namespace Complains_System.CustomHandle
{
    public class RolesAuthorizationHandler : AuthorizationHandler<RolesAuthorizationRequirement>, IAuthorizationHandler
    {
        private readonly ComplainsDbContext _context;
        public RolesAuthorizationHandler(ComplainsDbContext context)
        {
            _context = context;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                       RolesAuthorizationRequirement requirement)
        {
            if (context.User == null || !context.User.Identity.IsAuthenticated)
            {
                context.Fail();
                return Task.CompletedTask;
            }

            var validRole = false;
            if (requirement.AllowedRoles == null ||
                requirement.AllowedRoles.Any() == false)
            {
                validRole = true;
            }
            else
            {
                var claims = context.User.Claims;
                if (claims == null) {
                    context.Fail();
                    return Task.CompletedTask;
                }
                var userName = claims.FirstOrDefault(c => c.Type == "UserName").Value;
                var roles = requirement.AllowedRoles;

                var query = from c in _context.AppRoles
                            join d in _context.AppUserRoles on c.Id equals d.RoleId
                            join e in _context.AppUsers on d.UserId equals e.Id
                            select new { c, d, e };
                validRole = query.Where(p => roles.Contains(p.c.Name) && p.e.UserName == userName).Any();
            }

            if (validRole)
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }
            return Task.CompletedTask;
        }
    }
}
