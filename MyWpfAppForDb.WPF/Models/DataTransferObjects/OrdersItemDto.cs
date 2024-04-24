﻿using System;
using System.Collections.Generic;

namespace MyWpfAppForDb.WPF.Models.DataTransferObjects
{
    public partial class OrdersItemDto : ModelGtoBase
    {
        private int _ordersItemId;

        public int OrdersItemId
        {
            get => _ordersItemId;
            set
            {
                _ordersItemId = value;
                OnPropertyChanged();
            }
        }

        private int? _orderId;

        public int? OrderId
        {
            get => _orderId;
            set
            {
                _orderId = value;
                OnPropertyChanged();
            }
        }

        private int? _productId;

        public int? ProductId
        {
            get => _productId;
            set
            {
                _productId = value;
                OnPropertyChanged();
            }
        }

        public virtual OrderDto Order { get; set; }
        public virtual ProductDto Product { get; set; }
    }
}
