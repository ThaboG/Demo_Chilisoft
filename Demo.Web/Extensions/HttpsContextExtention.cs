using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web
{
    public static class HttpsContextExtention
    {
        public static Guid UserID(this HttpContext httpContext)
        {
            Guid.TryParse(httpContext.User.Claims.FirstOrDefault(c => c.Type == "UserID").Value, out Guid UserID);
            return UserID;
        }

        public static bool IsAdmin(this HttpContext httpContext)
        {
            return (httpContext.GetUserType()?.UserType ?? Enums.UserTypes.Client) == Enums.UserTypes.Admin;
        }

        public static void SetUserType(this HttpContext httpContext, DAL.Entities.Users User)
        {
            httpContext.Session.SetString("UserType", User.UserType.ToJson());
        }

        public static DAL.Entities.UserTypes GetUserType(this HttpContext httpContext)
        {
            var UserTypeString = httpContext.Session.GetString("UserType");

            return !string.IsNullOrEmpty(UserTypeString) ?
                UserTypeString.JsonToObject<DAL.Entities.UserTypes>()
                : new DAL.Entities.UserTypes();
        }

        public static Guid GetGuid(this HttpContext httpContext)
        {
            return Guid.NewGuid();
        }
    }
}
