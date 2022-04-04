using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace _API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public string Achievments { get; set; }

        [NotMapped] // не сохранять поле в бд
        public List<int> AchievmentsList { get; set; }

        // Создание JSON-строки из объекта
        private string GetJsonFromList(List<int> list)
        {
            return JsonConvert.SerializeObject(list);
        }
        // Получаем объект из JSON-строки
        private List<int> GetListFromJson(string json)
        {
            return JsonConvert.DeserializeObject<List<int>>(json);
        }
    }
}
