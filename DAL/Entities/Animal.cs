﻿using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace DAL.Entities
{
    public class Animal : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string ImageUrl { get; set; } = string.Empty;
        public int InformationAnimalId { get; set; }
        public InformationAnimal? InformationAnimal { get; set; }
        public List<HuntingSeason> HuntingSeasons { get; set; } = new List<HuntingSeason>();
    }
}
