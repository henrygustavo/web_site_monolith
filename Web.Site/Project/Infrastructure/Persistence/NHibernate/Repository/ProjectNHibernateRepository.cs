namespace Web.Site.Project.Infrastructure.Persistence.NHibernate.Repository
{
    using Web.Site.Common.Infrastructure.Persistence.NHibernate;
    using Web.Site.Project.Domain.Repository;
    using Domain.Entity;
    public class ProjectNHibernateRepository : BaseNHibernateRepository<Project>, IProjectRepository
    {
        public ProjectNHibernateRepository(UnitOfWorkNHibernate unitOfWork) : base(unitOfWork)
        {
        }
    }
}
