using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities
{
    public class Permission
    {
        [Key]
        [Column(Order=1)]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        
        [Key]
        [Column(Order=2)]
        public PermissionEnum PermissionType { get; set; }
    }

    public enum PermissionEnum
    {
        Basic,
        Admin
    }
}