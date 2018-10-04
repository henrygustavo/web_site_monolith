namespace Web.Site.Project.Domain.Entity
{
    using Web.Site.Common.Domain.ValueObject;
    using Web.Site.Organization.Domain.Entity;

    public class Project
    {
        public virtual int Id { get; set; }
        public virtual Organization Organization { get; set; }

        public virtual string  Name { get; set; }

        public virtual Money Balance { get; set; }

    }
}
