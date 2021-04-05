using System;
using System.Collections.Generic;
using System.Linq;

namespace CartoonsApi.Models
{
    public class Data: IData
    {
        public List<Cartoons> CartoonsList { get; set; }

        public List<Cartoons> CartoonsInitializeData()
        {
            CartoonsList = new List<Cartoons>()
            {
                new Cartoons(){Id = 1, Title= "Visionaries: Knights of the Magical Light", Genre = new string [] {"Animation", "Action", "Adventure" }, Rating = 7.8m,
                    Thumbnail="", Images = new string [] {"https://m.media-amazon.com/images/M/MV5BN2YxN2NiN2ItODA0My00YmVmLTkxZWEtZmQyOTUzODNjY2ViXkEyXkFqcGdeQXVyNDUxNjc5NjY@._V1_UY268_CR4,0,182,268_AL_.jpg" },
                    ReleaseYear = 1987, Runtime = 30,
                    Summary = "The planet Prysmos - post-technological loss. Two groups rise to dominance from the devastation to wage war upon each other. One is controlled by honest and law-abiding people and the other by criminals and villains. Following an open challenge thrown down by the great wizard Merklynn, fourteen surviving knights are granted powers of transformation and magical energy. The groups are now divided between the good Spectral Knights and the evil Darkling Lords. The battle for supremacy begins...",
                    Trailer = "https://youtu.be/ZviemBWC8SU" },
                new Cartoons(){Id = 2, Title= "Voltron: Defender of the Universe", Genre = new string [] {"Animation", "Family", "Sci-Fi" }, Rating = 7.9m,
                    Thumbnail="https://m.media-amazon.com/images/M/MV5BZDUyNGFiM2QtMzFkMC00YjhjLTk3NjktYmMwZDY1Njg2OTZjXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY209_CR3,0,140,209_AL_.jpg",
                    Images = new string [] {"https://m.media-amazon.com/images/M/MV5BNTY2OTkzOTAxNF5BMl5BanBnXkFtZTgwOTkyMDQ0MjE@._V1_UY100_CR16,0,100,100_AL_.jpg",
                        "https://m.media-amazon.com/images/M/MV5BMjMxNTE2NTQ2MF5BMl5BanBnXkFtZTgwMzgyMDQ0MjE@._V1_UY100_CR16,0,100,100_AL_.jpg",
                    "https://m.media-amazon.com/images/M/MV5BZDYyYTMxMzUtYWU2OS00Yzg2LTk2YWYtY2VkNTcxNWEyMTgxXkEyXkFqcGdeQXVyNTM3MDMyMDQ@._V1_UY100_CR17,0,100,100_AL_.jpg"},
                    ReleaseYear = 1984, StopYear = 1985, Runtime = 24,
                    Summary = "This series focuses on five lion robots and their pilots as they fight the evil forces of King Zarkon and Prince Lotor.",
                    Trailer = "https://youtu.be/xEFJo85EZVw" },
                new Cartoons(){Id = 3, Title= "Transformers", Genre = new string [] {"Animation", "Action", "Adventure" }, Rating = 8.0m,
                    Thumbnail="https://m.media-amazon.com/images/M/MV5BYjZkN2E5MDMtM2U1ZS00MGE2LTg1NzktYzZhYmVkNmJkYTk2XkEyXkFqcGdeQXVyNjExODE1MDc@._V1_UY268_CR5,0,182,268_AL_.jpg",
                    Images = new string [] {"https://m.media-amazon.com/images/M/MV5BOGQ3NzQxYzUtMDMwMC00NWUyLThlYWUtYzg2NzQ4Mjg5MzQ5XkEyXkFqcGdeQXVyNTM3MDMyMDQ@._V1_UY100_CR16,0,100,100_AL_.jpg",
                        "https://m.media-amazon.com/images/M/MV5BZmJhNGI3ZTktYTg0Yi00YjE1LTk2ZGUtNjViYmYzMTJlMzVlXkEyXkFqcGdeQXVyNzg3MjI0NTM@._V1_UY100_CR16,0,100,100_AL_.jpg",
                    "https://m.media-amazon.com/images/M/MV5BMjQ1NDBiYTctN2QyMS00Y2IxLWI2YTQtMWU1YjQyNDA4MzNhXkEyXkFqcGdeQXVyNzg3MjI0NTM@._V1_UY100_CR16,0,100,100_AL_.jpg"},
                    ReleaseYear = 1984, StopYear = 1987, Runtime = 30,
                    Summary = "Two opposing factions of transforming alien robots engage in a battle that has the fate of Earth in the balance.",
                    Trailer = "https://youtu.be/Ae-Pl-Q34ng" },
                new Cartoons(){Id = 4, Title= "G.I. Joe", Genre = new string [] {"Animation", "Action", "Adventure" }, Rating = 7.7m,
                    Thumbnail="https://m.media-amazon.com/images/M/MV5BNTE3ODc0ZWUtNWU5Ni00YzA2LWExMDktNTIyMTQ3YmIwNjM5XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY209_CR2,0,140,209_AL_.jpg",
                    Images = new string [] {"https://m.media-amazon.com/images/M/MV5BOTljYjBmNjctODAyNy00MDVkLTkxZmEtMjVhZDM4MTUyYjAzXkEyXkFqcGdeQXVyMjk4MzkyMzY@._V1_UY100_CR16,0,100,100_AL_.jpg",
                        "https://m.media-amazon.com/images/M/MV5BMzkwNjFiOWMtYjAzNC00NzI2LWJhM2QtN2U4YmM3MmEyOTQ0XkEyXkFqcGdeQXVyMjk4MzkyMzY@._V1_UY100_CR16,0,100,100_AL_.jpg",
                    "https://m.media-amazon.com/images/M/MV5BN2QwZDJhMjktOGY4Mi00NzBlLTk2NjQtYWZhMTA0OWFhMDNmXkEyXkFqcGdeQXVyMjk4MzkyMzY@._V1_UY100_CR39,0,100,100_AL_.jpg"},
                    ReleaseYear = 1985, StopYear = 1986, Runtime = 30,
                    Summary = "An elite special missions force fights against the terrorist forces of Cobra.",
                    Trailer = "https://youtu.be/4Ah2I166f_U" },
            };

            return CartoonsList;
        }

        public Cartoons GetCartoonsId(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return CartoonsList.SingleOrDefault(a => a.Id == id);
            }
        }
    }
}
