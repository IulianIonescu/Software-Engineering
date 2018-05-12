using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IdentitySample.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;


namespace WebApplication1.Controllers
{

        [Authorize(Roles = "Teacher")]
        public class ManageStudentsController : Controller
        {
            public ManageStudentsController()
            {
            }

            public ManageStudentsController(ApplicationUserManager userManager, ApplicationRoleManager roleManager)
            {
                UserManager = userManager;
                RoleManager = roleManager;
            }

            private ApplicationUserManager _userManager;
            public ApplicationUserManager UserManager
            {
                get
                {
                    return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                }
                private set
                {
                    _userManager = value;
                }
            }

            private ApplicationRoleManager _roleManager;
            public ApplicationRoleManager RoleManager
            {
                get
                {
                    return _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
                }
                private set
                {
                    _roleManager = value;
                }
            }

            //
            // GET: /Users/
            public async Task<ActionResult> Index()
            {
                ApplicationRole studentRole = RoleManager.Roles.SingleOrDefault(role => role.Name.Equals("Student"));
                var userIds = studentRole.Users.Select(usr => usr.UserId);            
                var students =  UserManager.Users.Where( usr => userIds.Contains(usr.Id));
                return View(await students.ToListAsync());
            }

            //
            // GET: /Users/Details/5
            public async Task<ActionResult> Details(string id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var user = await UserManager.FindByIdAsync(id);

                ViewBag.RoleNames = await UserManager.GetRolesAsync(user.Id);

                return View(user);
            }

        //
        // GET: /Users/Create
        public async Task<ActionResult> Create()
        {
            //Get the list of Roles
            ViewBag.RoleId = new SelectList(await RoleManager.Roles.ToListAsync(), "Name", "Name");
            return View();
        }

        //
        // POST: /Users/Create
        [HttpPost]
        public async Task<ActionResult> Create(RegisterViewModel userViewModel, params string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = userViewModel.Email,
                    Email = userViewModel.Email,

                };

                var adminresult = await UserManager.CreateAsync(user, userViewModel.Password);

                //Add User to the selected Roles 
                if (adminresult.Succeeded)
                {
                    UserManager.AddToRoles(user.Id, "Student");
                }
                else
                {
                    ModelState.AddModelError("", adminresult.Errors.First());
                    ViewBag.RoleId = new SelectList(RoleManager.Roles, "Name", "Name");
                    return View();

                }
                return RedirectToAction("Index");
            }
            ViewBag.RoleId = new SelectList(RoleManager.Roles, "Name", "Name");
            return View();
        }


        //30.04
        //
        // GET: /Users/Create
        //
        // POST: /Users/AssignStudent
        [HttpPost]
            public async Task<ActionResult> AssignStudent(AssignStudentViewModel userViewModel)
            {
                if (ModelState.IsValid)
                {
                    var user = new ApplicationUser
                    {
                        UserName = userViewModel.Email,
                        Email = userViewModel.Email,

                    };

                    var adminresult = await UserManager.CreateAsync(user, userViewModel.Password);

                    //Add User to the selected Roles 
                    if (adminresult.Succeeded)
                    {
                        UserManager.AddToRoles(user.Id, "Student");
                    }
                    else
                    {
                        ModelState.AddModelError("", adminresult.Errors.First());
                        ViewBag.RoleId = new SelectList(RoleManager.Roles, "Name", "Name");
                        return View();

                    }
                    return RedirectToAction("Index");
                }
                ViewBag.RoleId = new SelectList(RoleManager.Roles, "Name", "Name");
                return View();
            }
            //
            // GET: /Users/Edit/1
            public async Task<ActionResult> Edit(string id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var user = await UserManager.FindByIdAsync(id);
                if (user == null)
                {
                    return HttpNotFound();
                }

           

            return View(new EditStudentViewModel()
                {
                    Id = user.Id,
                    Email = user.Email,
                    Groups = new List<GroupsViewModel>
                            {
                                new GroupsViewModel{ ID=1, Name="CEN3" },
                                new GroupsViewModel{ ID=2, Name="CR2" },
                                new GroupsViewModel{ ID=3, Name="CEN1" }
                            }
                     });
            }

            //
            // POST: /Users/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<ActionResult> Edit([Bind(Include = "Email,Id,Username")] EditStudentViewModel editUser, params string[] selectedRole)
            {


            if (ModelState.IsValid)
                {
                    var user = await UserManager.FindByIdAsync(editUser.Id);
                    if (user == null)
                    {
                        return HttpNotFound();
                    }

                    user.UserName = editUser.Email;
                    user.Email = editUser.Email;

                UserManager.AddToRoles(editUser.Id, "Student");
                return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Something failed.");
                return View();
            }

            //
            // GET: /Users/Delete/5
            public async Task<ActionResult> Delete(string id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var user = await UserManager.FindByIdAsync(id);
                if (user == null)
                {
                    return HttpNotFound();
                }
                return View(user);
            }

            //
            // POST: /Users/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<ActionResult> DeleteConfirmed(string id)
            {
                if (ModelState.IsValid)
                {
                    if (id == null)
                    {
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    }

                    var user = await UserManager.FindByIdAsync(id);
                    if (user == null)
                    {
                        return HttpNotFound();
                    }
                    var result = await UserManager.DeleteAsync(user);
                    if (!result.Succeeded)
                    {
                        ModelState.AddModelError("", result.Errors.First());
                        return View();
                    }
                    return RedirectToAction("Index");
                }
                return View();
            }
        }
    
}