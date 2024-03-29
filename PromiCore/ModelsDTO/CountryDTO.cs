﻿using System.Collections.Generic;

namespace PromiCore.ModelsDTO
{
    public class CreateCountryDTO
    {

        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Continent { get; set; }

    }

    public class UpdateCountryDTO: CreateCountryDTO
    {

    }
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public virtual IList<OrderDTO> Orders { get; set; }
    }
}
