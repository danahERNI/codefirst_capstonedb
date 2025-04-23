﻿namespace LO_DB_CF.Entities
{
    public class UserSkill
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int SkillId {  get; set; }
        public int Rating { get; set; }

        public User User { get; set; }
        public Skill Skill { get; set; }

    }
}
