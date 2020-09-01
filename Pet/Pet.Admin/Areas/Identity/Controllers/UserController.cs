using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Microsoft.VisualBasic;
using Pet.Application;
using Pet.Core;
using Pet.Core.Domain.Identity;
using Pet.Core.Dto;
using Pet.Core.Enums.Domain.Identity;
using Pet.Core.Extensions;
using Pet.Core.Helper.Enums;
using Pet.Core.Helper.Secrets;
using Pet.Core.Models.Commons;
using Pet.Core.Models.Users;
using Pet.Services.interfaces;

namespace Pet.Admin.Areas.Identity.Controllers
{
    [Area("Identity")]
    [Route("Identity/[controller]/[action]/{id?}")]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetQueryList(string search, int page, int limit, int total = 0)
        {
            IPageList<UserPageModel> pageList = _userService.GetPageList(search, page, limit, total);

            return LayuiPageResult(pageList);
        }

        public IActionResult Add()
        {
            var list = EnumHelper.GetListSelectListItem<AppUserTypeStauts>(0);
            ViewBag.UserTypes = list;
            var dto = new UserDto();
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody][NotNull] UserDto model)
        {
            var exist = await _userService.AnyAsync(model.Name);
            if (exist)
            {
                ModelState.AddModelError(nameof(model.Name),L["DuplicateName"]);
            }
            if (!ModelState.IsValid)
            {
                return Error(ModelState.Values);
            }

            var user = _mapper.Map<AppUser>(model);
            await _userService.InsertAsync(user);
            return Success(user.Id);
        }


        public async Task<IActionResult> Edit(int id = 0)
        {
            var user = await _userService.FindAsync(id);
            var list = EnumHelper.GetListSelectListItem<AppUserTypeStauts>((int)user.UserType);
            ViewBag.UserTypes = list;
            var dto = _mapper.Map<UserDto>(user);
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromBody][NotNull] UserDto model)
        {
            if (!ModelState.IsValid)
            {
                return Error(ModelState.Values);
            }
            var user = await _userService.FindAsync((int)model.Id);
            user = _mapper.Map<AppUser>(model);
            user.PasswordHash = MD5Helper.MD5Encrypt(model.PassWord, user.SecurityStamp);
            await _userService.UpdateAsync(user);
            return Success(user.Id);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromBody] DeleteInput model)
        {
            var user = await _userService.FindAsync(model.Id);
            await _userService.DeleteAsync(user);
            return Success(user.Id);
        }

        [HttpPost]
        public async Task<IActionResult> BatchDelete([FromBody] DeleteBatchInput model)
        {
            var users = await _userService.GetListAsync(model.Ids);
            await _userService.DeleteAsync(users);
            return Success(model.Ids);
        }

    }
}
