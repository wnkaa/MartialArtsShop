using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

using Sklep.Service.DTO;
namespace Sklep.Service
{
    public class AutoMapperBootstrap
    {
        public static void InitializeMaps()
        {
            //Maps for Item
            Mapper.CreateMap<Item, ItemDTO>();
            Mapper.CreateMap<ItemDTO, Item>();
            //Maps for CartItems
            Mapper.CreateMap<CartItem, CartItemDTO>();
            // if needed ForMember(ci=> ci.ItemID, opt => opt.MapFrom(s=>s.Items.FirstOrDefault().ItemID)).ForMember(ci=>ci.Item, opt=> opt.MapFrom(s=>s.Items.FirstOrDefault()));
            Mapper.CreateMap<CartItemDTO, CartItem>();
            //Maps for Address
            Mapper.CreateMap<Address, AddressDTO>();
            Mapper.CreateMap<AddressDTO, Address>();
            //Maps for User
            Mapper.CreateMap<User, UserDTO>();
            Mapper.CreateMap<UserDTO, User>();
            //Maps for Cart
            Mapper.CreateMap<Cart, CartDTO>();
            Mapper.CreateMap<CartDTO, Cart>();
            //Maps for Order
            Mapper.CreateMap<Order, OrderDTO>();
            Mapper.CreateMap<OrderDTO, Order>();
        }
    }
}