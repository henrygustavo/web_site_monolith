namespace Web.Site.Organization.Infrastructure.Persistence.NHibernate.Mapping
{
    using Web.Site.Organization.Domain.Entity;
    using FluentNHibernate.Mapping;

    public class OrganizationMap : ClassMap<Organization>
    {
        public OrganizationMap()
        {
            Id(x => x.Id).Column("organization_id");
            Map(x => x.Name).Column("name");
            Map(x => x.Ruc).Column("ruc");
        }
    }
}
