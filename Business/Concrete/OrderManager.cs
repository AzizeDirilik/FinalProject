﻿using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Add(Order order)
        {
           _orderDal.Add(order);
            return new SuccessResult(message: Messages.OrderAdded);
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult(message: Messages.OrderDeleted);
        }

        public IDataResult<List<Order>> GetAll()
        {
           return new SuccessDataResult<List<Order>>(_orderDal.GetAll(), message: Messages.OrdersListed); 
        }

        public IDataResult<Order> GetById(int id)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(o => o.OrderId == id), message: Messages.OrdersListedById);   
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(message: Messages.OrderUpdated);
        }
    }
}
