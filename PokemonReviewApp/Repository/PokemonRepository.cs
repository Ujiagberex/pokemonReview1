﻿using PokemonReviewApp.Data;
using PokemonReviewApp.Interface;
using PokemonReviewApp.Model;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private DataContext _context;
        public PokemonRepository(DataContext context) 
        {
            _context = context;
        }
        

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }
    }
}
