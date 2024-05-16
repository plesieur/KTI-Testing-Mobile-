using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KTI_Testing__Mobile_.Models;

namespace MauiApp2.Models
{
    public static class ToolRepository
    {
        public static List<Tool> _tools = new List<Tool>() { 
        
            new(000001, "Hammer", "", 7),
            new(00002, "Handsaw", "", 7),
            new(00003, "Screwdriver", "", 7),
        };
        public static List<Tool> GetTools() => _tools;

        public static Tool GetToolById(int ToolId)
        {
            return _tools.FirstOrDefault(x => x.Id == ToolId);
        }

        public static List<Tool> SearchTools(string filterText)
        {
            var tools = _tools.Where(x => !string.IsNullOrWhiteSpace(x.Name) && x.Name.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();

            if (tools == null || _tools.Count <= 0)
            {
                tools = _tools.Where(x => !string.IsNullOrWhiteSpace(x.Amount.ToString()) && x.Amount.ToString().StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();
            } else
            {
                return tools;
            }

            return tools;
        }
    }
}
