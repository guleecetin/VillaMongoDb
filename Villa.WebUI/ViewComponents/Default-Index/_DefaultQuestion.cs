using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.QuestDtos;

namespace Villa.WebUI.ViewComponents.Default_Index
{
    public class _DefaultQuestion:ViewComponent
    {
        private readonly IQuestService _questService;
        private readonly IMapper _mapper;

        public _DefaultQuestion(IMapper mapper, IQuestService questService)
        {
            _mapper = mapper;
            _questService = questService;
        }

        public async Task <IViewComponentResult>  InvokeAsync()
        {
            var values = await _questService.TGetListAsync();
            var questionList = _mapper.Map<List<ResultQuestDto>>(values);
            return View(questionList);
        }
    }
}
