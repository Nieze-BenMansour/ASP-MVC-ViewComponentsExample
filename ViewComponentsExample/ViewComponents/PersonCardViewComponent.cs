using Microsoft.AspNetCore.Mvc;

namespace ViewComponentsExample.ViewComponents;

public class PersonCardViewComponent : ViewComponent
{
    public Task<IViewComponentResult> InvokeAsync(int id)
    {
        return Task.FromResult<IViewComponentResult>(View("CardDesign", id));
    }
}
