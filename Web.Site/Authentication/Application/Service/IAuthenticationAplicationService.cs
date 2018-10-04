namespace Web.Site.Authentication.Application.Service
{
    using Web.Site.Authentication.Application.Dto;

    public interface IAuthenticationAplicationService
    {
        bool SignUp(AuthenticationDTO model);
    }
}
