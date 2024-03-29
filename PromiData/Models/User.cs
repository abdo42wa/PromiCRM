﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PromiData.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        [ForeignKey(nameof(UserType))]
        public int TypeId { get; set; }
        public virtual UserType UserType { get; set; }
        public byte[] UserPhoto { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<WeeklyWorkSchedule> WeeklyWorkSchedules { get; set; }
        public virtual ICollection<SalesChannel> SalesChannels { get; set; }
        public virtual ICollection<RecentWork> RecentWorks { get; set; }
        public virtual ICollection<UserService> UserServices { get; set; }
        public virtual ICollection<UserBonus> UserBonuses { get; set; }
    }
}
