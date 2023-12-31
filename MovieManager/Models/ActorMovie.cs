﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieManager.Models
{
    public class ActorMovie
    {
        public Guid Id { get; set; }

        [ForeignKey("Actor")]
        [DisplayName("Actor Name")]
        public Guid? ActorId { get; set; }
        public Actor? Actor { get; set; }

        [ForeignKey("Movie")]
        [DisplayName("Movie Title")]
        public Guid? MovieId { get; set; }
        public Movie? Movie { get; set; }

    }
}
