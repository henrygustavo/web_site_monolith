namespace Web.Site.User.Domain.Entity
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string  UserName { get; set; }

        public  virtual string Password { get; set; }

        public virtual Role Role { get; set; }
    }
}
