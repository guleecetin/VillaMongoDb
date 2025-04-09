using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.ContactDtos;

namespace Villa.WebUI.ViewComponents.Default_Index
{
    public class _DefaultContact:ViewComponent
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public _DefaultContact(IMapper mapper, IContactService contactService)
        {
            _mapper = mapper;
            _contactService = contactService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _contactService.TGetListAsync();
            var contacts = _mapper.Map<List<ResultContactDto>>(values);
            return View(contacts);
        }
    }
}
