namespace Web.Site.User.Infrastructure.Persistence.NHibernate.Repository
{
    using Web.Site.Common.Infrastructure.Persistence.NHibernate;
    using Web.Site.User.Domain.Repository;
    using Web.Site.User.Domain.Entity;
    public class RoleNHibernateRepository : BaseNHibernateRepository<Role>, IRoleRepository
    {
        public RoleNHibernateRepository(UnitOfWorkNHibernate unitOfWork) : base(unitOfWork)
        {
        }
    }
}
