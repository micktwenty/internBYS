using Complains_System.Catalog.Admin.DepartmentManagement.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.Admin
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
