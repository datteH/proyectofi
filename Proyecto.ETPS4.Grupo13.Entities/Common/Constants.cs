using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Entities.Common
{
    public static class Constants
    {
        public static string CorsPolicy = nameof(CorsPolicy);
        public static string SqlConnection = nameof(SqlConnection);
        public static string DbName = "etps4-grupo13"; // Db name
        public static string ManagementAPI = nameof(ManagementAPI);
        public static string ProjectIdentityScheme = nameof(ProjectIdentityScheme);
        public static string ProjectAuthenticationDefaultScheme = nameof(ProjectAuthenticationDefaultScheme);
        public static string ProjectAuthenticationCookeName = nameof(ProjectAuthenticationCookeName);
    }
}
