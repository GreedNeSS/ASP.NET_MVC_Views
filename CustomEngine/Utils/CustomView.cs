using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace CustomEngine.Utils
{
    public class CustomView : IView
    {
        public string Path { get; set; }

        public CustomView(string viewPath)
        {
            Path = viewPath;
        }
        public async Task RenderAsync(ViewContext context)
        {
            string content = string.Empty;
            
            using (StreamReader viewReader = new StreamReader(Path))
            {
                content = await viewReader.ReadToEndAsync();
            }

            await context.Writer.WriteAsync(content);
        }
    }
}
