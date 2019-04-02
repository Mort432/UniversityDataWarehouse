using UniversityDataWarehouse.Data.Entities;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class PermissionSeed
    {
        public static Permission AdminPermission { get; } = new Permission()
        {
            User = UserSeed.Admin,
            PermissionType = PermissionEnum.Admin
        };
        
        public static Permission TeacherPermission { get; } = new Permission()
        {
            User = UserSeed.Teacher,
            PermissionType = PermissionEnum.Basic
        };

        public static Permission[] ToArray()
        {
            return new[]
            {
                AdminPermission,
                TeacherPermission
            };
        }
    }
}