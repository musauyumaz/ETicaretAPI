using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Application.DTOs.Configuration
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public List<Action> Actions { get; set; } = new();
    }
}
