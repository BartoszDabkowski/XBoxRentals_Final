﻿using System.ComponentModel.DataAnnotations;

namespace XBoxRentals.Dtos
{
    public class MembershipTypeDto
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public short SignUpFee { get; set; }

        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set; }
    }
}