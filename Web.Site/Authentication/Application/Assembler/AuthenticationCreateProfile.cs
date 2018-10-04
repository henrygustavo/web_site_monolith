namespace Web.Site.Authentication.Application.Assembler
{
    using AutoMapper;
    using Web.Site.Authentication.Application.Dto;
    using Web.Site.Organization.Domain.Entity;
    using Web.Site.User.Domain.Entity;
    using Web.Site.Project.Domain.Entity;
    using Web.Site.Common.Domain.ValueObject;

    public class AuthenticationCreateProfile : Profile
    {
        public AuthenticationCreateProfile()
        {
            CreateMap<AuthenticationDTO, User>()
               .ForMember(
                   dest => dest.UserName,
                   opts => opts.MapFrom(src => src.UserName)
               )
               .ForMember(
                   dest => dest.Password,
                   opts => opts.MapFrom(src => src.Password)
               );

            CreateMap<AuthenticationDTO, Organization>()
                .ForMember(
                    dest => dest.Name,
                    opts => opts.MapFrom(src => src.OrganizationName)
                )
                .ForMember(
                    dest => dest.Ruc,
                    opts => opts.MapFrom(src => src.OrganizationRuc)
                );

            CreateMap<AuthenticationDTO, Project>()
                .ForMember(
                    dest => dest.Balance,
                    opts => opts.MapFrom(
                        src => new Money(src.ProjectBalance, src.Currency)
                    )
                );
        }
    }
}
