namespace Web.Site.User.Domain.Entity
{
    using Web.Site.Organization.Domain.Entity;
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string  UserName { get; set; }

        public  virtual string Password { get; set; }

        public virtual Role Role { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
