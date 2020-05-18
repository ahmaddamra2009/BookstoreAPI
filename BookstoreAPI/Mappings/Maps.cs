using AutoMapper;
using BookstoreAPI.Data;
using BookstoreAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreAPI.Mappings
{
    public class Maps:Profile
    {
        public Maps()
        {
                    CreateMap<Author,AuthorDTO>().ReverseMap();
            CreateMap<Book, BookDTO>().ReverseMap();

        }
    }
}
