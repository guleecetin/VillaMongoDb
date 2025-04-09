using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.SubHeaderDtos;

namespace Villa.WebUI.ViewComponents.UILayout
{
    public class _UISubHeader:ViewComponent
    {
        private readonly ISubHeaderService _subHeaderService;
        private readonly IMapper _mapper;

        public _UISubHeader(IMapper mapper, ISubHeaderService subHeaderService)
        {
            _mapper = mapper;
            _subHeaderService = subHeaderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _subHeaderService.TGetListAsync();
            var subheaderList = _mapper.Map<List<ResultSubHeaderDto>>(values);
            return View(subheaderList);
        }
    }
}
