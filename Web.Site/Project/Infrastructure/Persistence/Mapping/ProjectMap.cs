namespace Web.Site.Project.Infrastructure.Persistence.Mapping
{
    using Web.Site.Project.Domain.Entity;
    using FluentNHibernate.Mapping;

    public class ProjectMap  : ClassMap<Project>
    {
        public ProjectMap()
        {
            Id(x => x.Id).Column("user_id");
            Map(x => x.Name).Column("name");
            Component(x => x.Balance, m =>
            {
                m.Map(x => x.Amount, "price");
                m.Map(x => x.Currency, "currency");
            });
            References(x => x.Organization);
        }
    }
}
