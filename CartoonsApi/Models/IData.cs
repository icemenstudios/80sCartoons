using System;
using System.Collections.Generic;

namespace CartoonsApi.Models
{
    public interface IData
    {
        public List<Cartoons> CartoonsList { get; set; }

        List<Cartoons> CartoonsInitializeData();

        Cartoons GetCartoonsId(int? id);

    }

    



}
