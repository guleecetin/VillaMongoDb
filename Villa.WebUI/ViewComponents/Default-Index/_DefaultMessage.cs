using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Villa.Business.Abstract;

namespace Villa.WebUI.ViewComponents.Default_Index
{
    public class _DefaultMessage:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
