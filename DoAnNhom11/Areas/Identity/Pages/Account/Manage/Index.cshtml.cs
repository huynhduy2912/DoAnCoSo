// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using DoAnNhom11.Models;
using DoAnNhom11.Extensions;

namespace DoAnNhom11.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
            public string FullName { get; set; }
            public string Avatar { get; set; }
            public string Address { get; set; }
            [EmailAddress]
            public string Email { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var fullName = user.FullName;
            var address = user.Address;
            var avatar = user.Avatar;
            Username = userName;


            Input = new InputModel
            {
                Email = email,
                Address = address,
                FullName = fullName,
                PhoneNumber = phoneNumber,
                Avatar = avatar
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            ViewData["Avatar"] = user.Avatar;
            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(IFormFile imageUrl)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }
            if (imageUrl != null&& user.Avatar != ("/images/" + imageUrl.FileName))
            {
                user.Avatar = await UploadImage.SaveImage(imageUrl);
                var result = await _userManager.UpdateAsync(user);

            }
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Thông tin bạn thay đổi không hợp lệ";
                    return RedirectToPage();
                }
            }
            var email = await _userManager.GetEmailAsync(user);
            if (Input.Email != email)
            {
                var setEmail = await _userManager.SetEmailAsync(user, Input.Email);
                if (!setEmail.Succeeded)
                {
                    StatusMessage = "Thông tin bạn thay đổi không hợp lệ";
                    return RedirectToPage();
                }
            }

            if(user.FullName != Input.FullName)
            {
                user.FullName = Input.FullName;
                var result = await _userManager.UpdateAsync(user);

                if (!result.Succeeded)
                {
                    StatusMessage = "Thông tin bạn thay đổi không hợp lệ";
                }
            }
            if (user.Address != Input.Address)
            {

                user.Address = Input.Address;
                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    StatusMessage = "Thông tin bạn thay đổi không hợp lệ";

                }
            }
            StatusMessage = "Thay đổi thông tin thành công";

            await _signInManager.RefreshSignInAsync(user);
            return RedirectToPage();
        }
    }
}
