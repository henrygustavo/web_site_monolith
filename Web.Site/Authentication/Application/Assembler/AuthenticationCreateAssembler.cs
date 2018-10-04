namespace Web.Site.Authentication.Application.Assembler
{
    using AutoMapper;
    using Web.Site.Authentication.Application.Dto;
    using Web.Site.Organization.Domain.Entity;
    using Web.Site.User.Domain.Entity;
    using Web.Site.Project.Domain.Entity;
    public class AuthenticationCreateAssembler
    {
        private readonly IMapper _mapper;

        public AuthenticationCreateAssembler(IMapper mapper)
        {
            _mapper = mapper;
        }


        public Organization ToOrganizationEntity(AuthenticationDTO model)
        {
            return _mapper.Map<Organization>(model);
        }

        public User ToUserEntity(AuthenticationDTO model)
        {
            return _mapper.Map<User>(model);
        }

        public Project ToProjectEntity(AuthenticationDTO model)
        {
            return _mapper.Map<Project>(model);
        }
    }
}
