using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.CartDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services
{
    public class CartService : ICartService {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;

        public CartService(ICartRepository cartRepository, IMapper mapper) {
            _cartRepository = cartRepository;
            _mapper = mapper;
        }

        
    }
}