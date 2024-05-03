using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.Models
{
    public static class ToolRepository
    {
        public static List<Tools> _tools = new List<Tools>() { 
        
            new Tools { Name="Hammer", Quantities="Quantity: ", Quantity =7, toolId = 00001},
            new Tools { Name="Handsaw", Quantities="Quantity: ", Quantity =7, toolId = 00002},
            new Tools { Name="Screwdriver", Quantities="Quantity: ", Quantity =7, toolId = 00003},
            new Tools { Name="Spaghetti", Quantities="Quantity: ", Quantity =7, toolId = 00004},
            new Tools { Name="Meatballs", Quantities="Quantity: ", Quantity =7, toolId = 00005},
            new Tools { Name="M Tool Box", Quantities="Quantity: ", Quantity = 4, toolId = 00006}
        };
        public static List<Tools> GetTools() => _tools;

        public static Tools GetToolById(int ToolId)
        {
            return _tools.FirstOrDefault(x => x.toolId == ToolId);
        }

        public static List<Tools> SearchTools(string filterText)
        {
            var tools = _tools.Where(x => !string.IsNullOrWhiteSpace(x.Name) && x.Name.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();

            if (tools == null || tools.Count <= 0)
            {
                tools = _tools.Where(x => !string.IsNullOrWhiteSpace(x.Quantities) && x.Quantities.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();
            } else
            {
                return tools;
            }

            return tools;
        }
    }
}
