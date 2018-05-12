using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace IdentitySample.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "RoleName")]
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class LaboratoriesViewModel
    {
        public int ID { set; get; }
        public string Name { set; get; }
    }


    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }


        public List<LaboratoriesViewModel> EditLaboratories { set; get; }
        public int SelectedLaboratoryId { set; get; }
    }

    public class GroupsViewModel
    {
        public int ID { set; get; }
        public string Name { set; get; }
    }

    public class EditStudentViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        public List<GroupsViewModel> Groups { set; get; }
        public int SelectedGroupId { set; get; }
    }
}