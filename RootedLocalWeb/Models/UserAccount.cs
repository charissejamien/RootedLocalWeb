using Postgrest.Attributes;
using Postgrest.Models;


[Table("Users")]
    public class UserAccount : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id {get; set;}
        [Column("fullName")]
        public string fullName {get; set;} = "";
        [Column("emailAddress")]
        public string emailAddress {get; set;} = "";
    }