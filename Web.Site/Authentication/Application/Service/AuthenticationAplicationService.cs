namespace Web.Site.Authentication.Application.Service
{
    using Web.Site.Authentication.Application.Assembler;
    using Web.Site.Organization.Domain.Entity;
    using Web.Site.Project.Domain.Entity;
    using Web.Site.User.Domain.Entity;
    using System;
    using Web.Site.Authentication.Application.Dto;
    using Web.Site.Common.Application.Notification;
    using Web.Site.Common.Infrastructure.Persistence;
    using Web.Site.Organization.Domain.Repository;
    using Web.Site.Project.Domain.Repository;
    using Web.Site.User.Domain.Repository;
    public class AuthenticationAplicationService: IAuthenticationAplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IOrganizationRepository _organizationRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly AuthenticationCreateAssembler _authenticationCreateAssembler;

        public AuthenticationAplicationService(IUnitOfWork unitOfWork,
            IUserRepository userRepository,
            IOrganizationRepository organizationRepository,
            IProjectRepository projectRepository,
            AuthenticationCreateAssembler authenticationCreateAssembler)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _organizationRepository = organizationRepository;
            _projectRepository = projectRepository;
            _authenticationCreateAssembler = authenticationCreateAssembler;


        }

        public bool SignUp(AuthenticationDTO model)
        {

            Notification notification = ValidateModel(model);

            if (notification.HasErrors())
            {
                throw new ArgumentException(notification.ErrorMessage());
            }

            bool status = _unitOfWork.BeginTransaction();

            try
            {
                User user = _authenticationCreateAssembler.ToUserEntity(model);

                Organization organization = _authenticationCreateAssembler.ToOrganizationEntity(model);

                Project project = _authenticationCreateAssembler.ToProjectEntity(model);

                _userRepository.Create(user);

                organization.User = user;

                _organizationRepository.Create(organization);

                project.Organization = organization;

                _projectRepository.Create(project);

                _unitOfWork.Commit(status);
            }
            catch
            {
                _unitOfWork.Rollback(status);

                notification.AddError("there was error creating product");
                throw new ArgumentException(notification.ErrorMessage());

            }


            return true;

        }


        private Notification ValidateModel(AuthenticationDTO model)
        {
            Notification notification = new Notification();

            if (model == null)

            {
                notification.AddError("Invalid JSON data in request body");
                return notification;
            }

            return notification;

        }


    }
}
