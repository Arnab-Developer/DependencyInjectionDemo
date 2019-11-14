using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ApoUtilityPrototype1.DomainModels
{
    [DataContract]
    public class UserAccount
    {
        [DataMember]
        [Key]
        public int UserId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}