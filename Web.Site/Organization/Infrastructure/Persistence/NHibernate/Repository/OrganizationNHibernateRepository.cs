namespace Web.Site.Organization.Infrastructure.Persistence.NHibernate.Repository
{
    using Web.Site.Common.Infrastructure.Persistence.NHibernate;
    using Web.Site.Organization.Domain.Repository;
    using Domain.Entity;

    public class OrganizationNHibernateRepository : BaseNHibernateRepository<Organization>, IOrganizationRepository
    {
        public OrganizationNHibernateRepository(UnitOfWorkNHibernate unitOfWork) : base(unitOfWork)
        {
        }
    }
}
