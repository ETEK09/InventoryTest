using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace InventoryTest.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty] /*attribute is used to bind data from HTTP requests to properties of a Razor Pages               model.*/
        public Credential Credential { get; set; }
        public void OnGet()
        {
            this.Credential = new Credential() { UserName = "admin" };
        }

        public void OnPost() 
        {
        
        
        }
    }

    public class Credential
    {
        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
       
        [Required(ErrorMessage = "Password is required")]

        [DataType(DataType.Password)]    /*is used to specify the data type of a property when creating                                   forms and performing model validation, primarily for password                                   input fields.*/
        public string Password { get; set; }
    }



    //public class Credential
    //{
    //    [Required]
    //    public string UserName { get; set; }

    //    [DataType(DataType.Password)]  /*is used to specify the data type of a property when creating                                   forms and performing model validation, primarily for password                                   input fields.*/

    //    [Required]
    //    public string Password { get; set; }


    //}
}
