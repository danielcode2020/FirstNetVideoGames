using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VIdeoGameManager1.DataAccess
{
    public class GameGenre
    {
        public int ID { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [JsonIgnore]
        public List<Game> Games { get; set; }


    }

    public class Game
    {
        public int ID { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        public GameGenre Genre { get; set; }

        public int PersonalRating { get; set; }

    }
}
