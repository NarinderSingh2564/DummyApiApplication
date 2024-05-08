using System.ComponentModel.DataAnnotations;

namespace DummyApiApplication.Web.Data.DbClasses
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(15)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(10)]
        public string Password { get; set; }
       
        public bool IsActive { get; set; }

    }
}
