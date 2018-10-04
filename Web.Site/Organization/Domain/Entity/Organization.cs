namespace Web.Site.Organization.Domain.Entity
{
    using Web.Site.User.Domain.Entity;
    public class Organization
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Ruc { get; set; }

        public virtual User User { get; set; }

    }
}
