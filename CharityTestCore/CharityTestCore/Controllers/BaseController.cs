using CharityTestCore.Models;
using CharityTestCore.Service;
using CharityTestCore.Service.EPT;
using CharityTestCore.Service.UserManagment;
using Domain.DataBase;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CharityTestCore.Controllers
{
    public class BaseController : Controller
    {
        public readonly UserProfileModel? _userProfileModel;
        public BaseController(  )
        {
            //if (User != null)
            //{
            //    string username = User.Identity == null ? "" : User.Identity.Name;
            //    _userProfileModel = _userService.GetProfile(username);
            //}
        }

        public string OnGetUserId()
        {
            var claim = User.Claims.FirstOrDefault(o => o.Type == ClaimTypes.SerialNumber);
            if (claim == null)
                return string.Empty;
            return claim.Value;

        }
        public Guid OnGetUserGuid()
        {
            var claim = User.Claims.FirstOrDefault(o => o.Type == ClaimTypes.SerialNumber);
            if (claim == null || !Guid.TryParse(claim.Value, out Guid userId))
                return Guid.Empty;

            return userId;
        }

        public string OnGetUserRole()
        {
            var claim = User.Claims.FirstOrDefault(o => o.Type == ClaimTypes.Role);
            if (claim == null)
                return string.Empty;
            return claim.Value;

        }
    }
}
