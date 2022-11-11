// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using Ank9_UsingIdentity.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Ank9_UsingIdentity.Areas.Identity.Pages.Account
{
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<Ank9_UsingIdentityUser> _signInManager;
        private readonly ILogger<LogoutModel> _logger;

        public LogoutModel(SignInManager<Ank9_UsingIdentityUser> signInManager, ILogger<LogoutModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel {
            [Required]
            [Display(Name="Çıkış yapmak istediğinize emin misiniz?")]
            public bool CheckDelete { get; set; }
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            if (ModelState.IsValid && Input.CheckDelete)
            {

                await _signInManager.SignOutAsync();
                _logger.LogInformation("User logged out.");
                if (returnUrl != null)
                {
                    return LocalRedirect(returnUrl);
                }
                else
                {
                    // This needs to be a redirect so that the browser performs a new
                    // request and the identity for the user gets updated.
                    return RedirectToPage();
                }
            }
            else {
                ModelState.AddModelError(string.Empty, "Invalid logout attempt.");
                return Page();
            }

        }
    }
}
