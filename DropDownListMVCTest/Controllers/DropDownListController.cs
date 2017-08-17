using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownListMVCTest.Controllers
{
    public class DropDownListController : Controller
    {

        public ActionResult Index(ViewModel.Programming programming)
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="1", Text="ActionScript"},
                new SelectListItem(){ Value="2", Text="AppleScript"},
                new SelectListItem(){ Value="3", Text="Asp"},
                new SelectListItem(){ Value="4", Text="BASIC"},
                new SelectListItem(){ Value="5", Text="C"},
                new SelectListItem(){ Value="6", Text="C++"},
                new SelectListItem(){ Value="7", Text="Clojure"},
                new SelectListItem(){ Value="8", Text="COBOL"},
                new SelectListItem(){ Value="9", Text="ColdFusion"},
                new SelectListItem(){ Value="10", Text="Erlang"},
                new SelectListItem(){ Value="11", Text="Fortran"},
                new SelectListItem(){ Value="12", Text="Groovy"},
                new SelectListItem(){ Value="13", Text="Haskell"},
                new SelectListItem(){ Value="14", Text="instinctcoder.com"},
                new SelectListItem(){ Value="15", Text="Java"},
                new SelectListItem(){ Value="16", Text="JavaScript"},
                new SelectListItem(){ Value="17", Text="Lisp"},
                new SelectListItem(){ Value="18", Text="Perl"},
                new SelectListItem(){ Value="19", Text="PHP"},
                new SelectListItem(){ Value="20", Text="Python"},
                new SelectListItem(){ Value="21", Text="Ruby"},
                new SelectListItem(){ Value="22", Text="Scala"},
                new SelectListItem(){ Value="23", Text="Scheme"},
            };


            programming = new ViewModel.Programming();
            programming.languanges = new SelectList(list, "Value", "Text");


            return View(programming);
        }
    }
}