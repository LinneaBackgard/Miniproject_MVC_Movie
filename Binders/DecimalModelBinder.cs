using System.Globalization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Miniproject_MVC_Movie.Binders
{
    public class DecimalModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            // Hämta värdet från formuläret (som text)
            var valueResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            if (valueResult == ValueProviderResult.None)
                return Task.CompletedTask;

            var valueAsString = valueResult.FirstValue;

            if (string.IsNullOrWhiteSpace(valueAsString))
                return Task.CompletedTask;

            // Gör både 8,3 och 8.3 till 8.3
            valueAsString = valueAsString.Replace(',', '.');

            if (decimal.TryParse(
                valueAsString,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out var result))
            {
                // Tala om för MVC: "här är ett korrekt decimalvärde"
                bindingContext.Result = ModelBindingResult.Success(result);
                return Task.CompletedTask;
            }

            // Om det inte går att tolka → visa fel
            bindingContext.ModelState.AddModelError(
                bindingContext.ModelName,
                "Rating must be a number."
            );

            return Task.CompletedTask;
        }
    }
}
