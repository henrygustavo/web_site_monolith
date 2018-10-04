using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Site.Common.Domain.Enum;

namespace Web.Site.Authentication.Application.Dto
{
    public class AuthenticationDTO
    {
        public string OrganizationName { get; set; }
        public string OrganizationRuc { get; set; }

        public string  UserName { get; set; }

        public  string Password { get; set; }

        public  string ProjectName { get; set; }

        public decimal ProjectBalance { get; set; }

        public Currency Currency { get; set; }
    }
}
